using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluorineFx.IO;
using FluorineFx.Messaging.Messages;
using System.IO;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FluorineFx;//处理AMF协议的类库命名空间
using System.Drawing;
using SharpPcap;//从网卡获取网络数据包的命名空间
using SharpPcap.Packets;
using System.Net;
using FluorineFx.Json;
using System.Security.Cryptography;//加解密的命名空间
using System.Threading;
using System.Data;

namespace Games
{
    public partial class Sanguo
    {
        public static string IECookieString = "";//获得游戏用户名的http协议的cookie
        
        public string ActiveNetWorkCard = "";//获得网卡名
        PcapDevice mActiveDevice;//当前正在运行的网卡设备
              
        MemoryStream mCapStream = new MemoryStream();//从网卡上获得的数据流
        MemoryStream mReqStream = new MemoryStream();//申请的数据流
        
        public bool mHooked = false;
        public System.Net.IPAddress ip;
 
        #region Net sniffer
        //监听网卡，从网卡时截获数据包
        public void HookNetwork()
        {
            List<PcapDevice> allDevices = Pcap.GetAllDevices();
            int tmpActiveDrivice = 0;
            for (int i = 0; i < allDevices.Count; i++)
            {
                if (ActiveNetWorkCard.Length > 0 && ActiveNetWorkCard == allDevices[i].Name)
                {
                    allDevices[i].Open();
                    if (allDevices[i].Opened)
                    {
                        tmpActiveDrivice = i;
                        break;
                    }
                }
                else if (ActiveNetWorkCard.Length == 0 && allDevices[i].Opened)
                {
                    tmpActiveDrivice = i;
                    break;
                }
            }
            mActiveDevice = allDevices[tmpActiveDrivice];

            mActiveDevice.OnPacketArrival += new Pcap.PacketArrivalEvent(ActiveDevice_OnPacketArrival);
            mActiveDevice.Open(true, 500);
            mActiveDevice.SetFilter("ether[12:2]=0x8864 or tcp ");
 
            try
            {
                mActiveDevice.Capture(-1);
            }
            catch{}
        }

        bool mKeepRequest = false;
        string mReqBuffer = "";//http协议的申请消息字符串       
        
        void ActiveDevice_OnPacketArrival(object sender,PcapCaptureEventArgs e) //Packet packet)
        {            
            if (e.Packet is ARPPacket || e.Packet is UDPPacket)
                return;
            if (mHooked && mLoginUser.Actived)
            {                
                try
                {
                    mActiveDevice.StopCapture();
                    mActiveDevice.Close();                    
                    return;
                }
                catch { }
                return;
            }
            byte[] tmpPacketData = null;
            TCPPacket tmpTcpPacket = null;
            if (e.Packet is TCPPacket)
            {
                tmpTcpPacket = (e.Packet as TCPPacket);
            }
            else
                if (e.Packet is EthernetPacket)
                {
                    IPv4Packet tmpIpPacket = new IPv4Packet(e.Packet.Header.Length, e.Packet.Bytes);
                    byte[] tmpBuf = new byte[e.Packet.Data.Length - 8];
                    Array.Copy(e.Packet.Data, 8, tmpBuf, 0, tmpBuf.Length);
                    MemoryStream tmpMs = new MemoryStream();
                    tmpMs.Write(e.Packet.Header, 0, e.Packet.Header.Length);
                    tmpMs.Write(tmpBuf, 0, tmpBuf.Length);
                    try
                    {
                        tmpTcpPacket = new TCPPacket(e.Packet.Header.Length, tmpMs.ToArray());
                    }
                    catch { tmpTcpPacket = null; }
                }
            if (tmpTcpPacket != null )
            {
                tmpPacketData = tmpTcpPacket.Data;
            }
            if (tmpPacketData != null)
            {
                string tmpStr = Encoding.UTF8.GetString(tmpPacketData);                
                if (((tmpStr.IndexOf("POST") > -1 && tmpStr.IndexOf("application/x-amf") > -1) || mKeepRequest) && tmpStr.Length > 0)
                {
                    mReqBuffer += tmpStr;
                    mReqStream.Write(tmpPacketData, 0, tmpPacketData.Length);                    
                    int tmpLen = mReqBuffer.IndexOf("\r\n\r\n") + 4;                    

                    Match tmpMatch = Regex.Match(mReqBuffer, @"Content-length: (?'T'(\d)*)", RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    if (tmpMatch.Success)
                    {          
                        if (mKeepRequest == false)
                        {
                            tmpStr = tmpStr.Substring(0, tmpLen);
                            IECookieString=tmpStr.Replace(tmpMatch.Groups[2].Value, @"%LEN%");
                            RequestMessageCookie = IECookieString.Substring(IECookieString.IndexOf("Cookie: ")).Replace("Cookie: ", "").Replace("\r\n\r\n", "");
                        }
                        if (mReqStream.Length < tmpLen + Convert.ToInt32(tmpMatch.Groups[2].Value))
                        {
                            mKeepRequest = true;                           
                        }
                        else
                        {                         
                            if (mReqStream.Length == tmpLen + Convert.ToInt32(tmpMatch.Groups[2].Value))
                            {
                                try
                                {                                 
                                    byte[] tmpBuf = mReqStream.ToArray();
                                    byte[] tmpData = new byte[Convert.ToInt32(tmpMatch.Groups[2].Value)];
                                    Array.Copy(tmpBuf, tmpLen, tmpData, 0, tmpData.Length);
                                    mReqStream = new MemoryStream();
                                    mReqStream.Write(tmpData, 0, tmpData.Length);
                                                                        
                                    mReqStream.Seek(0, SeekOrigin.Begin);
                                    AMFDeserializer tmpAmfSer = new AMFDeserializer(mReqStream);
                                    AMFMessage tmpMsg = tmpAmfSer.ReadAMFMessage();
                                    AMFMessage tmpRvMsg = tmpMsg;

                                    if (tmpRvMsg != null && tmpRvMsg.Bodies.Count > 0 && tmpRvMsg.Bodies[0].Content != null &&
                                        tmpRvMsg.Bodies[0].Content is object[] &&(tmpRvMsg.Bodies[0].Content as object[]).Length > 0 &&
                                        (tmpRvMsg.Bodies[0].Content as object[])[0] is RemotingMessage &&
                                        ((tmpRvMsg.Bodies[0].Content as object[])[0] as RemotingMessage).body != null
                                        )
                                    {
                                        if (((tmpRvMsg.Bodies[0].Content as object[])[0] as RemotingMessage).source.ToLower() == "citycommand")
                                        {
                                            if (((tmpRvMsg.Bodies[0].Content as object[])[0] as RemotingMessage).body is Array)
                                            {
                                                object[] tmpObj = ((((tmpRvMsg.Bodies[0].Content as object[])[0] as RemotingMessage).body as Array) as object[])[0] as object[];
                                                if (tmpObj.Length == 4 &&tmpObj[0] is int &&tmpObj[1] is int &&tmpObj[2] is double)
                                                {
                                                    User tmpUser = new User();
                                                    tmpUser.UserID = Convert.ToString(tmpObj[0]);
                                                    object tmpTime = tmpObj[2];
                                                    tmpUser.Cookie = Convert.ToDouble(tmpTime);
                                                    tmpUser.Actived = true;
                                                    this.LoginUser = tmpUser;
                                                    this.LoginUser.isDropped = false;                                                    
                                                    
                                                    mHooked = true;
                                                    ip=tmpTcpPacket.DestinationAddress;                                                    
                                                    
                                                    return;
                                                }
                                            }
                                        }
                                        if (((tmpRvMsg.Bodies[0].Content as object[])[0] as RemotingMessage).source.ToLower() == "command")
                                        {
                                            if (((tmpRvMsg.Bodies[0].Content as object[])[0] as RemotingMessage).body is Array)
                                            {
                                                object[] tmpObj = ((((tmpRvMsg.Bodies[0].Content as object[])[0] as RemotingMessage).body as Array) as object[])[0] as object[];
                                                
                                                if (tmpObj.Length == 5 &&tmpObj[0] is int &&tmpObj[1] is double)
                                                {
                                                    User tmpUser = new User();
                                                    tmpUser.UserID = Convert.ToString(tmpObj[0]);
                                                    object tmpTime = tmpObj[1];
                                                    tmpUser.Cookie = Convert.ToDouble(tmpTime);
                                                    tmpUser.Actived = true;
                                                    this.LoginUser = tmpUser;
                                                    this.LoginUser.isDropped = false;                                                    
                                                   
                                                    mHooked = true;
                                                    return;
                                                }
                                            }
                                        }
                                    }
                                }
                                catch { }
                            }
                            mReqStream = new MemoryStream();
                            mReqBuffer = "";
                        }
                    }
                }
                else
                {
                    mReqBuffer = "";                   
                    mKeepRequest = false;
                    mCapStream = new MemoryStream();
                    mReqStream = new MemoryStream();
                }
            }            
        }
        #endregion

        ~Sanguo()
        {
        }

        public string PhpSessID = "";//http协议的申请消息的SessID字符串

        User mLoginUser;

        public User LoginUser
        {
            get { return mLoginUser; }
            set { mLoginUser = value; }
        }

        
        public Sanguo()
        {
        }

        //游戏内城市的属性封装类定义
        public class City
        {
            public int cityid;
            public string name;
            public ASObject Army;
            public ASObject[] Heros;
            public ASObject resources;
            public ASObject Builders;
            public ASObject Technology;
            public int TroopArmyCount;
            public City()
            {
                name = "";
                Army = new ASObject();
                for (int i = 1; i < 13; i++)
                    Army.Add(Convert.ToString(i),0);
                Heros = null;
                resources = new ASObject();
                Builders = new ASObject();
                Technology = new ASObject();
                TroopArmyCount = 0;
            }
        }

        //游戏用户登录游戏的属性的封装类定义
        public class User
        {
            public int Flag_1;
            public string UserID;
            public Double Cookie;
            public bool isDropped;
            public bool Actived;
            public string username;
            public City[] UserCities;
            public ASObject CitySort;
            public User()
            {
                Flag_1 = 0;
                UserID = "";
                Cookie = 0;
                isDropped = false;
                Actived = false;
                username ="";
                CitySort = new ASObject();
            }
        }

        public static string MsgPassword = "WAIGUASB";//消息的密钥和公共密钥结合使用
        public static string GameUIAddress = "";
        public static string GameClientGUID = "";
        public static string RequestMessageCookie = "";//申请消息的cookie
        public static string swfPassfile="";//获取密钥的swf的网页文件

        //委托，用于实现消息处理
        public delegate void ReceivedHandler(SocketSendReceiveMs pTagSocket, AcknowledgeMessage pArg);
        
        //用Socket发送消息的封装类定义
        public class SocketSendReceiveMs
        {
            public AutoResetEvent ThreadEvent = new AutoResetEvent(false);
            public int HttpLength = -1;
            public int tmpLen = 0;
            public string ExecuteMessageId = "";
            public byte[] recvBytes = new byte[1024];
            public MemoryStream Stream1 = new MemoryStream();
            public Socket c;
            public AMFMessage SendMsg;
            public AcknowledgeMessage ReceMsg;
            public ReceivedHandler Received;

            public object ReslutValue = null;
            public SocketSendReceiveMs()//构造函数
            {
                c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                c.ReceiveTimeout = 100;
            }
        }        
        
        //Http消息的编号
        static int mResponseID = 0;
        public static string ResponseID
        {
            get
            {
                mResponseID++;
                return string.Format("/{0}", mResponseID);
            }
        }

        public string str="";
        int mMessageTimeout = 6000;

        //处理发送HTTP消息的函数
        SocketSendReceiveMs SendMessage(string pReqStr, AMFMessage pMsg, ReceivedHandler pReceved)
        {
             SocketSendReceiveMs tmpSocketSRMsg = new SocketSendReceiveMs();
             tmpSocketSRMsg.SendMsg = pMsg;
             MemoryStream tmpReqStr = new MemoryStream();
             MemoryStream tmpAMFStr = new MemoryStream();
             AMFSerializer tmpAmfSer = new AMFSerializer(tmpAMFStr);

             tmpAmfSer.WriteMessage(pMsg);
             pReqStr = pReqStr.Replace("%LEN%", Convert.ToString(tmpAMFStr.Length));
             byte[] tmpBuf = Encoding.UTF8.GetBytes(pReqStr);
             tmpReqStr.Write(tmpBuf, 0, tmpBuf.Length);
             tmpBuf = tmpAMFStr.ToArray();
             tmpReqStr.Write(tmpBuf, 0, tmpBuf.Length);
             tmpSocketSRMsg.Received = pReceved;
             int port = 80;
             IPEndPoint ipEnd = new IPEndPoint(ip, port);
            
             try 
             {
                 tmpSocketSRMsg.c.Connect(ipEnd); 
             } 
             catch(Exception se) 
             { 
               MessageBox.Show("连接错误"+se.Message,"提示信息",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
               return null;
             }
             try 
             {
                 tmpSocketSRMsg.c.Send(tmpReqStr.ToArray(), tmpReqStr.ToArray().Length, 0);
             } 
             catch(Exception ce) 
             { 
               MessageBox.Show("发送错误:"+ce.Message,"提示信息",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information); 
             }

             tmpSocketSRMsg.c.BeginReceive(tmpSocketSRMsg.recvBytes, 0, 1024, SocketFlags.None, new AsyncCallback(ReceiveCallBack), tmpSocketSRMsg);
             tmpReqStr.Close();
             tmpAMFStr.Close();
           
             return tmpSocketSRMsg;        
        }

        //处理Http消息的回归调用函数
        void ReceiveCallBack(IAsyncResult ar)
        {
            SocketSendReceiveMs tmpSRMsg = (SocketSendReceiveMs)ar.AsyncState;
            int re = 0;

            try
            {
                re = tmpSRMsg.c.EndReceive(ar);
            }
            catch (Exception se)
            {
                MessageBox.Show("goupi错误" + se.Message, "提示信息", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
            if (re > 0)
            {
                tmpSRMsg.Stream1.Write(tmpSRMsg.recvBytes, 0, re);
                
            }
            if (tmpSRMsg.Stream1.CanRead && tmpSRMsg.Stream1.Length > 0 && tmpSRMsg.HttpLength < 0)
            {
                string tmpHttpRsp = Encoding.UTF8.GetString(tmpSRMsg.Stream1.ToArray());                
                if (tmpHttpRsp.IndexOf("\r\n\r\n") > 0)
                {
                    try
                    {
                        Match tmpMatch = Regex.Match(tmpHttpRsp, @"Content-length: (?'T'(\d)*)", RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Multiline);
                        tmpSRMsg.tmpLen = tmpHttpRsp.IndexOf("\r\n\r\n") + 4;
                        tmpSRMsg.HttpLength = tmpSRMsg.tmpLen + Convert.ToInt32(tmpMatch.Groups[2].Value);
                    }
                    catch{ }
                }
            }
            if (tmpSRMsg.HttpLength == tmpSRMsg.Stream1.Length)
            {
                byte[] tmpBuf = tmpSRMsg.Stream1.ToArray();
                byte[] tmpData = new byte[tmpSRMsg.HttpLength - tmpSRMsg.tmpLen];

                Array.Copy(tmpBuf, tmpSRMsg.tmpLen, tmpData, 0, tmpData.Length);
                MemoryStream mCapStream = new MemoryStream();
                mCapStream.Write(tmpData, 0, tmpData.Length);      
                mCapStream.Seek(0, SeekOrigin.Begin);
                try
                {
                    AMFDeserializer tmpAmfSer = new AMFDeserializer(mCapStream);
                    AMFMessage tmpMsg = tmpAmfSer.ReadAMFMessage();
                    AMFMessage tmpRvMsg = tmpMsg;
                    AcknowledgeMessage tmpAckMsg = (AcknowledgeMessage)tmpRvMsg.Bodies[0].Content;
                    if (tmpSRMsg.Received != null)
                    {
                        tmpSRMsg.ReceMsg = tmpAckMsg;
                        tmpSRMsg.Received(tmpSRMsg, tmpAckMsg);
                    }
                }
                catch (Exception se)
                {
                    MessageBox.Show("反序列化错误" + se.Message, "提示信息", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    return;
                }
                
                mCapStream.Close();
                tmpSRMsg.Stream1.Close();
                tmpSRMsg.c.Close();
                tmpSRMsg.HttpLength = -1;                
            }
            else
            {
                try
                {
                    tmpSRMsg.c.BeginReceive(tmpSRMsg.recvBytes, 0, 1024, SocketFlags.None, new AsyncCallback(ReceiveCallBack), tmpSRMsg);
                }
                catch { }
            }
        }

        //AMF协议的数据发送函数
        AMFMessage SendCommand(string pOpertation, string pSource, object pParam, bool isEnc)
        {
            try
            {
                AMFMessage tmpMsg = new AMFMessage(3);
                RemotingMessage tmpCmd = new RemotingMessage();

                tmpCmd.clientId = Guid.NewGuid().ToString().ToUpper();
                tmpCmd.destination = "amfphp";
                tmpCmd.messageId = Guid.NewGuid().ToString().ToUpper();
                tmpCmd.headers.Add(RemotingMessage.FlexClientIdHeader, "nil");
                tmpCmd.operation = pOpertation;
                tmpCmd.source = pSource;

                if (!isEnc)
                {
                    tmpCmd.body = new object[] { pParam };
                }
                else
                {
                    string tmpJsonStr = "";
                    using (MemoryStream tmpMs = new MemoryStream())
                    {
                        using (TextWriter tmpTw = new StreamWriter(tmpMs))
                        {
                            using (JsonWriter tmpJw = new JsonWriter(tmpTw))
                            {
                                FillJsonWrite(tmpJw, pParam);
                                tmpJsonStr = Encoding.UTF8.GetString(tmpMs.ToArray());
                                tmpJw.Close();
                            }
                            tmpTw.Close();
                        }
                        tmpMs.Close();
                    }
                    
                    tmpJsonStr = Enc(tmpJsonStr, MsgPassword);                              
                    object[] objs = new object[4];
                    object[] parList = pParam as object[];
                    objs[0] = Convert.ToInt32(parList[0]);
                    objs[1] = Convert.ToInt32(parList[1]);

                    TimeSpan toNow = DateTime.Now.Subtract(_dtStart);
                    objs[2] = toNow.Ticks / 10000000;
                    objs[3] = getSign(Convert.ToInt32(parList[0]), Convert.ToInt32(parList[1]), Convert.ToInt32(objs[2]));
                    tmpCmd.body = new object[] { tmpJsonStr, objs };                    
                }
                AMFBody tmpMsgBody = new AMFBody("null", ResponseID, new object[] { tmpCmd });
                tmpMsg.AddBody(tmpMsgBody);

                return tmpMsg;
            }
            catch (Exception se)
            {
                MessageBox.Show("生成AMF消息错误" + se.Message, "提示信息", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                return null;
            }
        }

        //验证接收到的AMF消息
        AcknowledgeMessage TestReslutCmdMsg(SocketSendReceiveMs pTagSocket, AcknowledgeMessage pRltMsg)
        {
            AcknowledgeMessage tmpAckMsg = pRltMsg;         
            if (pTagSocket.SendMsg != null && pTagSocket.SendMsg.Bodies.Count > 0 &&
                pTagSocket.SendMsg.Bodies[0].Content is Array &&
                ((object[])(pTagSocket.SendMsg.Bodies[0].Content as Array))[0].GetType() == typeof(RemotingMessage))
                {
                    RemotingMessage tmpCmdMsg = (RemotingMessage)((object[])(pTagSocket.SendMsg.Bodies[0].Content as Array))[0];
                    if (tmpAckMsg.correlationId != tmpCmdMsg.messageId)
                        throw new Exception("AMF反馈消息与请求不匹配!!");
                    object[] tmpObj = (tmpAckMsg.body as Array) as object[];
                    if (tmpObj != null && tmpObj.Length == 2 && tmpObj[1].Equals("invalid_user_auth"))
                    {
                        tmpAckMsg = null;                        
                    }                    
                }           
            return tmpAckMsg;
        }

        //模拟游戏内的城市消息命令函数
        public void SendCityCommand(int pCityId, int pCmdID)
        {
            if (LoginUser == null) return;
            int pUserID = Convert.ToInt32(mLoginUser.UserID);
            SocketSendReceiveMs tmpsocket = SendMessage(IECookieString, SendCommand("sendCommand", "CityCommand", new object[] { pUserID, pCityId, mLoginUser.Cookie, pCmdID }, false ), (ReceivedHandler)OnCityCmd_SendCommand);
            if (tmpsocket != null)
                tmpsocket.ThreadEvent.WaitOne();
        }
        
        //城市命令介绍消息解析函数
        void OnCityCmd_SendCommand(SocketSendReceiveMs pTagSocket, AcknowledgeMessage pArg)
        {
            if (LoginUser == null) return;
            AcknowledgeMessage tmpAckMsg = pArg; //TestReslutCmdMsg(pTagSocket, pArg);
            int tmpCid = Convert.ToInt32(((((pTagSocket.SendMsg.Bodies[0].Content as object[])[0] as FluorineFx.Messaging.Messages.RemotingMessage).body as object[])[0] as object[])[1]);
            if (tmpAckMsg != null)
            {
                object[] tmpAry = (tmpAckMsg.body as Array) as object[];
                int tmpCmdID = Convert.ToInt32(tmpAry[1]);
                switch (tmpCmdID)
                {
                    case 0:                        
                        break;
                    case 1:
                        break;
                    case 2:                        
                        object[] tmpObj = ((tmpAry[2] as Array) as object[])[0] as object[];
                        int pCityId=Convert.ToInt32((tmpObj[0] as ASObject)["cid"]);
                        int sort=0;
                        for(int i=0;i<LoginUser.UserCities.Length;i++)
                            if (pCityId == LoginUser.UserCities[i].cityid)
                            {
                                sort = i;
                                break;
                            }
                        for (int i = 0; i < tmpObj.Length; i++)
                            LoginUser.UserCities[sort].Army.Add((string)(tmpObj[i] as ASObject)["sid"], (object)(tmpObj[i] as ASObject)["count"]);                      
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }                                        
            }
            pTagSocket.ThreadEvent.Set();
        }
        
        //把数据转换成JSON格式
        static void FillJsonWrite(JsonWriter pWriter, object pObj)
        {
            if (pObj is Array)
            {
                pWriter.WriteStartArray();
                Array tmpObjs = (pObj as Array);
                for (int i = 0; i < tmpObjs.Length; i++)
                {
                    if (tmpObjs.GetValue(i) is Array)
                    {
                        FillJsonWrite(pWriter, tmpObjs.GetValue(i));
                    }
                    else
                    {
                        JsonAppend(pWriter, tmpObjs.GetValue(i));
                    }
                }
                pWriter.WriteEndArray();
            }
            else
            {
                JsonAppend(pWriter, pObj);
            }
            pWriter.Flush();
        }
       
        //获取游戏开始的密钥
        static string GetNewHead()
        {
            string tmpStr = "";
            switch (GameClientGUID.Length)
            {
                case 0:
                    {
                        WebClient tmpWc = new WebClient();
                        if (!String.IsNullOrEmpty(RequestMessageCookie))
                        {
                            tmpWc.Headers.Add("Cookie", RequestMessageCookie);
                        }
                        else
                        {
                            return "";
                        }


                        string tmpPasswordUrl = "";
                        if (!GameUIAddress.ToLower().StartsWith("http://"))
                            GameUIAddress = "http://" + GameUIAddress;
                                                   
                        tmpStr = tmpWc.DownloadString(string.Format(GameUIAddress));

                        if (tmpStr.IndexOf("getSwfPassFile") > -1)
                        {
                            tmpPasswordUrl = tmpStr.Substring(tmpStr.IndexOf("getSwfPassFile"));
                            tmpPasswordUrl = tmpPasswordUrl.Substring(0, tmpPasswordUrl.IndexOf(";"));
                            tmpPasswordUrl = tmpPasswordUrl.Substring(tmpPasswordUrl.IndexOf("'")).Replace("'", "");
                           
                            GameClientGUID = ParsePublicKey(tmpStr);
                            if (!GameUIAddress.EndsWith("/"))
                            {
                                swfPassfile = GameUIAddress + "/";
                            }
                            else
                                swfPassfile = GameUIAddress + tmpPasswordUrl;
                        }
                        else
                            swfPassfile = "找不到密码钥匙！";
                    }
                    break;
                default:
                    tmpStr = GameClientGUID;
                    break;
            }
            
            return tmpStr;
        }
        public static string GetNewHead(string pServer)
        {
            if (pServer.ToLower().StartsWith("http://"))
                GameUIAddress = pServer;
            else
                GameUIAddress = "http://" + pServer;
            return GetNewHead();
        }        
        //通过程序与网页的SWf交互，实现获得密钥的函数
        public void Getswf()
        {            
            string text = System.IO.File.ReadAllText(@"c:\rxsg\html\app1.html");
            if (text.IndexOf("LoadPass") > -1)
            {
                string tmpstr = text.Substring(text.IndexOf("LoadPass"));
                tmpstr = tmpstr.Substring(0, tmpstr.IndexOf(")"));
                tmpstr = tmpstr.Substring(tmpstr.IndexOf("(")).Replace("(\"", "");
                tmpstr = tmpstr.Replace("\"", "");
                text = text.Replace(tmpstr, swfPassfile);
                System.IO.File.WriteAllText(@"c:\rxsg\html\app1.html", text);                
            }
            else
                return;
        }

        //DES加密实现
        static string Enc(string pString, string pKey)
        {
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    DES tmpDes = DES.Create();
                    tmpDes.Mode = CipherMode.ECB;
                    byte[] byte1 = Encoding.ASCII.GetBytes(pKey);
                    byte[] byte2 = new byte[8];
                    if (pKey.Length < 8)
                    {
                        for (int i = 0; i < pKey.Length; i++)
                            byte2[i] = byte1[i];
                        int len = 8 - pKey.Length;
                        for (int i = 0; i < len; i++)
                            byte2[pKey.Length + i] = 0x00;
                    }
                    else
                        byte2 = byte1;
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, tmpDes.CreateEncryptor(byte2, Encoding.ASCII.GetBytes(pKey)), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(Encoding.UTF8.GetBytes(pString), 0, Encoding.UTF8.GetBytes(pString).Length);
                        cryptoStream.FlushFinalBlock();
                        byte[] bytes = memoryStream.ToArray();
                        string tmpStr = Convert.ToBase64String(bytes);
                        
                        return tmpStr;
                    }
                }
            }
            catch { return ""; }            
        }

        //JSON数据转换函数
        static void JsonAppend(JsonWriter pWriter, object pObj)
        {
            switch (pObj.GetType().Name)
            {
                case "Int32":
                    pWriter.WriteValue(Convert.ToInt32(pObj));
                    break;
                case "DateTime":
                    pWriter.WriteValue(Convert.ToDateTime(pObj));
                    break;
                case "Boolean":
                    pWriter.WriteValue(Convert.ToBoolean(pObj));
                    break;
                case "String":
                    pWriter.WriteValue(Convert.ToString(pObj));
                    break;
                case "Char":
                    pWriter.WriteValue(Convert.ToChar(pObj));
                    break;
                case "Byte":
                    pWriter.WriteValue(Convert.ToByte(pObj));
                    break;
                case "Int64":
                    pWriter.WriteValue(Convert.ToInt64(pObj));
                    break;
                case "Single":
                    pWriter.WriteValue(Convert.ToSingle(pObj));
                    break;
                case "Double":
                    pWriter.WriteValue(Convert.ToDouble(pObj));
                    break;
                case "Int16":
                    pWriter.WriteValue(Convert.ToInt16(pObj));
                    break;
                case "Decimal":
                    pWriter.WriteValue(Convert.ToDecimal(pObj));
                    break;
                case "SByte":
                    pWriter.WriteValue(Convert.ToSByte(pObj));
                    break;
                case "UInt32":
                    pWriter.WriteValue(Convert.ToUInt32(pObj));
                    break;
                case "UInt16":
                    pWriter.WriteValue(Convert.ToUInt16(pObj));
                    break;
                case "UInt64":
                    pWriter.WriteValue(Convert.ToUInt64(pObj));
                    break;
                default:
                    pWriter.WriteUndefined();
                    break;
            }
            pWriter.Flush();
        }
        
        //分析JS的词法
        public static string ParsePublicKey(string pHtmlSource)
        {
            string tmpStr = pHtmlSource;
            string[] tmpAry = tmpStr.Split(new string[] { "<script>" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tmpAry.Length; i++)
            {
                if (tmpAry[i].Trim().IndexOf("Microsoft Internet Explorer") > 0)
                {
                    tmpStr = tmpAry[i].Trim();
                    tmpStr = tmpStr.Substring(0, tmpStr.IndexOf("</script>"));
                    break;
                }
            }
            string tmpTagChar = tmpStr.Substring(tmpStr.IndexOf("var a="));
            tmpTagChar = tmpTagChar.Substring(0, tmpTagChar.IndexOf(";"));
            tmpTagChar = tmpTagChar.Substring(tmpTagChar.IndexOf(",") + 1, tmpTagChar.IndexOf(")") - tmpTagChar.IndexOf(",") - 1);
            tmpStr = tmpStr.Substring(tmpStr.IndexOf(tmpTagChar));
            tmpStr = tmpTagChar.Replace("'", "");
            tmpAry = tmpStr.Split(new string[] { tmpTagChar }, StringSplitOptions.RemoveEmptyEntries);
            if (tmpAry.Length > 2)
            {
                tmpStr = tmpAry[1];
                tmpStr = tmpStr.Substring(0, tmpStr.IndexOf(";")).Replace("'", "").Replace("=", "").Trim();
            }
            return tmpStr;
        }
        
        //当前时间全局变量
        private static DateTime _dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
        //加密中实现字符的变化函数
        private static string getSign(int _arg1, int _arg2, int _arg3)
        {
            var x = _arg1;
            var y = _arg2;
            var z = _arg3;
            var r = 0;

            var _local31 = ((x << 205) | (_arg1 >> (32 - 205)));
            var _local32 = ((x & y) | (~(x) & z));

            int rol = (((Math.Abs(_local31) + 0) - Math.Abs(_local32)));

            r = rol;
            return ((Math.Abs(r) + ""));
        }
        
        //以下两个函数实现获得游戏中的城市信息
        public void GetUserCities()
        {
            if (LoginUser == null ) return;
            int pUserID = Convert.ToInt32(mLoginUser.UserID);
            SocketSendReceiveMs tmpsocket = SendMessage(IECookieString, SendCommand("sendCommand", "Command", new object[] { pUserID, mLoginUser.Cookie, 2, "city", "getUserCities" }, true), (ReceivedHandler)OnGetUserCities);
            if(tmpsocket!=null)
                tmpsocket.ThreadEvent.WaitOne(mMessageTimeout);
        }
        void OnGetUserCities(SocketSendReceiveMs pTagSocket, AcknowledgeMessage pArg)
        {            
            if (LoginUser == null)return;            
            AcknowledgeMessage tmpAckMsg = pArg;//TestReslutCmdMsg(pTagSocket, pArg);
            
            if (tmpAckMsg != null)
            {
                if (mLoginUser != null)
                {
                    object[] tmpAry = (tmpAckMsg.body as Array) as object[];
                    object[] tmpObj = (tmpAry[4] as Array) as object[];
                    int citycount = tmpObj.Length;
                    mLoginUser.UserCities = new City[citycount];                    
                                        
                    for (int i = 0; i < citycount; i++)
                    {
                        City tmpCity = new City();                    
                        tmpCity.cityid=Convert.ToInt32((tmpObj[i] as FluorineFx.ASObject)["cid"]);
                        
                        int tmp=Convert.ToInt32((tmpObj[i] as FluorineFx.ASObject)["cid"]);
                        int y=tmp/1000;
                        int x = tmp - y * 1000;
                        tmpCity.name=(tmpObj[i] as FluorineFx.ASObject)["name"] + "(" + Convert.ToString(x) + "," + Convert.ToString(y) + ")";
                        mLoginUser.UserCities[i] = tmpCity;
                        mLoginUser.CitySort.Add(Convert.ToString(tmpCity.cityid), i.ToString());
                    }                    
                }                
            }
            pTagSocket.ThreadEvent.Set();
        }

        //以下两个函数实现获得游戏用户在游戏中的城市信息
        public void GetCityInfo(int pCid)
        {
            if (LoginUser == null) return;
            int pUserID = Convert.ToInt32(mLoginUser.UserID);
            SocketSendReceiveMs tmpSktData = SendMessage(IECookieString, SendCommand("sendCommand", "Command", new object[] { pUserID, mLoginUser.Cookie, 2, "city", "getCityInfo", pCid }, true), (ReceivedHandler)OnGetCityInfo);
            tmpSktData.ThreadEvent.WaitOne(mMessageTimeout);            
        }
        void OnGetCityInfo(SocketSendReceiveMs pTagSocket, AcknowledgeMessage pArg)
        {
            if (LoginUser == null) return;
            AcknowledgeMessage tmpAckMsg = pArg;
            if (tmpAckMsg != null)
            {
                if (mLoginUser != null)
                {
                    object[] tmpAry = (tmpAckMsg.body as Array) as object[];                    
                    tmpAry = (tmpAry[4] as Array) as object[];                    
                    ASObject tmpAS=tmpAry[0] as ASObject;
                    int cid = Convert.ToInt32(tmpAS["cid"]);
                    int tmp = Convert.ToInt32(mLoginUser.CitySort[Convert.ToString(cid)]);
                    if (mLoginUser.username.Equals(""))
                    {
                        tmpAS = ((tmpAry[1] as Array) as object[])[0] as ASObject;
                        mLoginUser.username = (string)tmpAS["name"];
                    }
                   
                    #region 资源信息
                    ASObject tmpDetail = ((tmpAry[1] as Array) as object[])[1] as ASObject;                    
                    string food = Convert.ToString(tmpDetail["food"]);
                    int Len=food.IndexOf(".");
                    if (Len > -1)
                        food = food.Substring(0, Len );
                    string wood = (string)tmpDetail["wood"];
                    Len = wood.IndexOf(".");
                    if (Len > -1)
                        wood = wood.Substring(0, Len );
                    string rock = (string)tmpDetail["rock"];
                    Len = rock.IndexOf(".");
                    if (Len > -1)
                        rock = rock.Substring(0, Len );
                    string iron = (string)tmpDetail["iron"];
                    Len = iron.IndexOf(".");
                    if (Len > -1)
                        iron = iron.Substring(0, Len );
                    string gold = (string)tmpDetail["gold"];
                    Len = gold.IndexOf(".");
                    if (Len > -1)
                        gold = gold.Substring(0, Len );
                    string food_add = (string)tmpDetail["food_add"];
                    Len = food_add.IndexOf(".");
                    if (Len > -1)
                        food_add = food_add.Substring(0, Len);

                    mLoginUser.UserCities[tmp].resources.Clear();
                    mLoginUser.UserCities[tmp].resources.Add("food", food);
                    mLoginUser.UserCities[tmp].resources.Add("wood", wood);
                    mLoginUser.UserCities[tmp].resources.Add("rock", rock);
                    mLoginUser.UserCities[tmp].resources.Add("iron", iron);
                    mLoginUser.UserCities[tmp].resources.Add("gold", gold);
                    mLoginUser.UserCities[tmp].resources.Add("food_add", food_add);
                    mLoginUser.UserCities[tmp].resources.Add("food_army_use", (string)tmpDetail["food_army_use"]);
                    #endregion

                    #region 将领信息
                    object[] tmpDetailAry = (tmpAry[1] as Array) as object[];
                    if (tmpDetailAry[2] is Array)
                    {
                        tmpDetailAry = (tmpDetailAry[2] as Array) as object[];                        
                        if (tmpDetailAry.Length>0)
                        {                            
                            mLoginUser.UserCities[tmp].Heros = new ASObject[tmpDetailAry.Length];
                            for (int i = 0; i < tmpDetailAry.Length; i++)
                            {
                                ASObject tmpASObj = new ASObject();
                                tmpASObj.Add("heroid", (tmpDetailAry[i] as ASObject)["hid"]);
                                tmpASObj.Add("name", (tmpDetailAry[i] as ASObject)["name"]);
                                tmpASObj.Add("state", (tmpDetailAry[i] as ASObject)["state"]);
                                tmpASObj.Add("speed", (tmpDetailAry[i] as ASObject)["speed_add_on"]);
                                mLoginUser.UserCities[tmp].Heros[i] = tmpASObj;
                            }
                        }                    
                    }
                    #endregion

                    #region 军队信息
                    tmpDetailAry = (tmpAry[1] as Array) as object[];
                    if (tmpDetailAry[3] is Array)
                    {
                        tmpDetailAry = (tmpDetailAry[3] as Array) as object[];
                        if (tmpDetailAry.Length > 0)
                        {
                            foreach (ASObject tmpObj in tmpDetailAry)
                            {
                                int tmpCnt = Convert.ToInt32(tmpObj["count"]);
                                if (tmpCnt > 0)
                                {
                                    string sid = Convert.ToString(tmpObj["sid"]);
                                    mLoginUser.UserCities[tmp].Army[sid] = (object)tmpCnt;
                                }
                            }
                        }
                    }                    
                    #endregion
                  
                    #region 建筑信息
                    tmpDetailAry = (tmpAry[2] as Array) as object[];
                    mLoginUser.UserCities[tmp].Builders.Clear();
                    int k = 0;
                    foreach (ASObject tmpObj in tmpDetailAry)
                    {
                        BuildInfo tmpBuild = new BuildInfo();
                        tmpBuild.id=Convert.ToInt32(tmpObj["id"]);
                        tmpBuild.XY = Convert.ToInt32(tmpObj["xy"]);
                        tmpBuild.bname = Convert.ToString(tmpObj["bname"]);
                        tmpBuild.BuildID = Convert.ToInt32(tmpObj["bid"]);
                        tmpBuild.level = Convert.ToInt32(tmpObj["level"]);
                        tmpBuild.state = Convert.ToInt32(tmpObj["state"]);
                        tmpBuild.state_startTime = Convert.ToDouble(tmpObj["state_starttime"]);
                        tmpBuild.state_endTime = Convert.ToDouble(tmpObj["state_endtime"]);
                        tmpBuild.state_leftTime = Convert.ToDouble(tmpObj["state_timeleft"]);

                        mLoginUser.UserCities[tmp].Builders.Add(Convert.ToString(k), tmpBuild);
                        k++;
                    }
                    #endregion

                    #region 科技信息
                    tmpDetailAry = (tmpAry[3] as Array) as object[];
                    mLoginUser.UserCities[tmp].Technology.Clear();
                    foreach (ASObject tmpObj in tmpDetailAry)
                    {
                        int tmpTech = Convert.ToInt32(tmpObj["tid"]);
                        int Level = Convert.ToInt32(tmpObj["level"]);
                        mLoginUser.UserCities[tmp].Technology.Add(Convert.ToString(tmpTech), Level);
                    }
                    #endregion
                }
            }
            pTagSocket.ThreadEvent.Set();
        }

        //出征军队的信息
        public class CampaignArmy
        {
            public ASObject ArmyInfo=new ASObject();            
            public void init()
            {
                ArmyInfo.Clear();
                for (int i = 1; i < 13; i++)
                    ArmyInfo.Add(Convert.ToString(i), Convert.ToString(0));
            }
        }

        //建筑信息
        public class BuildInfo
        {
            public int id;  
            public int BuildID;
            public int XY;
            public string bid;
            public int level;
            public string bname;
            public int state;
            public double state_startTime;
            public double state_endTime;
            public double state_leftTime;
            
            public BuildInfo()
            {
                id = 0;
                BuildID = 0;
                bname = "";
                XY = 0;
                level = 0;
                state = 0;
                bid = "";
                state_startTime = 0;
            }
        }

        //军队信息的类定义
        public struct ArmyInfo
        {
            public int typeId;
            public string name;
            public int speed;
            public int carry;
            public int food_use;            
        }
        public ArmyInfo Soldier1, Soldier2, Soldier3, Soldier4, Soldier5, Soldier6, Soldier7, Soldier8, Soldier9, Soldier10, Soldier11, Soldier12;
        //设置军队信息，和游戏定义相对应
        public  void setArmyInfo()
        {
            Soldier1.typeId = 1;
            Soldier1.name="农夫";
            Soldier1.speed = 180;
            Soldier1.carry = 200;
            Soldier1.food_use = 2;

            Soldier2.typeId = 2;
            Soldier2.name = "义兵";
            Soldier2.speed = 200;
            Soldier2.carry = 20;
            Soldier2.food_use = 3;

            Soldier3.typeId = 3;
            Soldier3.name = "斥候";
            Soldier3.speed = 3000;
            Soldier3.carry = 5;
            Soldier3.food_use = 5;

            Soldier4.typeId = 4;
            Soldier4.name = "长枪兵";
            Soldier4.speed = 300;
            Soldier4.carry = 40;
            Soldier4.food_use = 6;

            Soldier5.typeId = 5;
            Soldier5.name = "刀盾兵";
            Soldier5.speed = 275;
            Soldier5.carry = 30;
            Soldier5.food_use = 7;

            Soldier6.typeId = 6;
            Soldier6.name = "弓箭兵";
            Soldier6.speed = 250;
            Soldier6.carry = 25;
            Soldier6.food_use = 9;

            Soldier7.typeId = 7;
            Soldier7.name = "轻骑兵";
            Soldier7.speed = 1000;
            Soldier7.carry = 100;
            Soldier7.food_use = 18;

            Soldier8.typeId = 8;
            Soldier8.name = "铁骑兵";
            Soldier8.speed = 600;
            Soldier8.carry = 80;
            Soldier8.food_use = 35;

            Soldier9.typeId = 9;
            Soldier9.name = "辎重车";
            Soldier9.speed = 150;
            Soldier9.carry = 5000;
            Soldier9.food_use = 10;

            Soldier10.typeId = 10;
            Soldier10.name = "床弩";
            Soldier10.speed = 120;
            Soldier10.carry = 35;
            Soldier10.food_use = 50;

            Soldier11.typeId = 11;
            Soldier11.name = "冲车";
            Soldier11.speed = 160;
            Soldier11.carry = 45;
            Soldier11.food_use = 100;

            Soldier12.typeId = 12;
            Soldier12.name = "投石车";
            Soldier12.speed = 100;
            Soldier12.carry = 75;
            Soldier12.food_use = 250;
        }
        public int[] sortArmy = { 12, 10, 9, 11, 1, 2, 6, 5, 4, 8, 7, 3 };

        //获得出征军队的参数信息
        public List<object> GetTroopParam(int TroopType, City pCity, int pTargetCid, int pHerohid, CampaignArmy pSolider, long pTent, bool pUseFlag, double pGold, double pFood, double pWood, double pStock, double pIrion)
        {
            if (LoginUser == null) return null;
            List<object> tmpParam = null;
            tmpParam = new List<object>();
            tmpParam.Add(pCity.cityid);

            int BuildParam=100;
            foreach (var tmpB in pCity.Builders.Values)
            {
                if ((tmpB as BuildInfo).BuildID == 8)
                {
                    BuildParam = (tmpB as BuildInfo).XY;
                    break;
                }
            }
            int x = (BuildParam - 100) / 10;
            int y = BuildParam - 100 - x * 10;
            BuildParam = y * 10 + x;

            tmpParam.Add(8);       //2
            tmpParam.Add(BuildParam);        //3
            tmpParam.Add(6);        //5
            tmpParam.Add("StartTroop");  //1            
            tmpParam.Add(pHerohid);     //4....        
            tmpParam.Add(pTargetCid);         //4....
            tmpParam.Add((int)TroopType);         //4....
            //宿营时间，单位秒
            tmpParam.Add(pTent);   //4....

            string tmpStr = "";
            int tmpCount = 0;
            foreach (KeyValuePair<string, object> tmpArmy in pSolider.ArmyInfo)
            {
                if (Convert.ToInt32(tmpArmy.Value) > 0)
                {
                    tmpStr += string.Format("{0},{1},", tmpArmy.Key, tmpArmy.Value);
                    tmpCount++;
                }
            }
            tmpStr = string.Format("{0},{1}", tmpCount, tmpStr);
            tmpParam.Add(tmpStr);
            //资源
            tmpStr = string.Format("{0},{1},{2},{3},{4},", pGold, pFood, pWood, pStock, pIrion);
            tmpParam.Add(tmpStr);
            tmpParam.Add(pUseFlag);  
              
            return tmpParam;
        }
        //出征信息
        public void Troop(int TroopType, City pCity, int pTargetCid, int pHerohid, CampaignArmy pSolider, long pTent, bool pUseFlag, double pGold, double pFood, double pWood, double pStock, double pIrion)
        {
            if (LoginUser == null) return;
            List<object> tmpTroopParam = GetTroopParam(TroopType, pCity, pTargetCid, pHerohid, pSolider, pTent, pUseFlag, pGold, pFood, pWood, pStock, pIrion);
            Troop(tmpTroopParam);
        }        
        public void Troop(List<object> pParam)
        {
            if (LoginUser == null) return;
            int pUserID = Convert.ToInt32(mLoginUser.UserID);
            int tmpCmdType = 1;//COMMAND_TYPE_DIALOG
            List<object> tmpParam = new List<object>();
            tmpParam.Add(pUserID);
            tmpParam.Add(mLoginUser.Cookie);
            tmpParam.Add(tmpCmdType);
            if (pParam != null)
            {
                tmpParam.AddRange(pParam);
                SocketSendReceiveMs tmpsocket=SendMessage(IECookieString, SendCommand("sendCommand", "Command", tmpParam.ToArray(), true), (ReceivedHandler)OnTroop);
                tmpsocket.ThreadEvent.WaitOne(mMessageTimeout);
            }           
        }
        void OnTroop(SocketSendReceiveMs pTagSocket, AcknowledgeMessage pArg)
        {
            if (LoginUser == null) return;
            string Message="";
            AcknowledgeMessage tmpAckMsg = pArg; //TestReslutCmdMsg(pTagSocket, pArg);
            if (tmpAckMsg != null)
            {
                if (tmpAckMsg.body is Array)
                {
                    object[] tmpObj = tmpAckMsg.body as object[];
                    if (tmpObj.Length == 2)
                    {
                        Message = Convert.ToString(tmpObj[1]);
                    }
                    else
                        if (tmpObj[6] is Array)
                        {
                            tmpObj = tmpObj[6] as object[];
                            if (tmpObj.Length != 0)
                            {
                                Message = Convert.ToString(tmpObj[0]);
                            }
                        }
                }
                str = Message;
            }
            pTagSocket.ThreadEvent.Set();
        }
        
        //行军速度计算
        public long EvalMarchTime(int pTroopType, Point pSourceSite, Point pTargetSite, int pMarchLevel, int pReinLevel, double pHeroSpeedAddOn, int pDakLevel, Sanguo.ArmyInfo pArmy)
        {
            double tmpDist = EvalDistance(pSourceSite, pTargetSite);
            double tmpTechSpeed = 1;
            double tmpHeroSpeed = 1;
            double tmpArmySpeed = 0;
            double tmpSpeed = 0;
            double tmpDakSpeed = 1;

            if (pArmy.typeId != 3 && pArmy.typeId < 7)
                tmpTechSpeed = 1 + pMarchLevel * 0.1;
            else
                tmpTechSpeed = 1 + pReinLevel * 0.05;
            tmpHeroSpeed = 1 + pHeroSpeedAddOn / 100;
            tmpArmySpeed = pArmy.speed;            
            if (pTroopType == 0 || pTroopType == 1)
                tmpDakSpeed = 1 + pDakLevel * 0.5;

            //行军速度
            tmpSpeed = tmpArmySpeed * tmpTechSpeed * tmpHeroSpeed * tmpDakSpeed;
            long tmpPathTime = Convert.ToInt64(Math.Ceiling(tmpDist * 60000 / tmpSpeed));

            return tmpPathTime;
        }
        
        //行军中的资源消耗计算
        public long TroopFoodUse(int zzcsl, long pPathTime)
        {
            double tmpUsedFood = 0;
            tmpUsedFood = Soldier9.food_use * zzcsl;
            tmpUsedFood = tmpUsedFood * 2 * pPathTime;
            return Convert.ToInt64(Math.Ceiling(tmpUsedFood / 3600));
        }
        public long TroopFoodUse(CampaignArmy pArmies, long pPathTime)
        {
            double tmpUsedFood = 0;
            for (int i = 1; i <= 12; i++)
            {
                switch (i)
                {
                    case 1:
                        tmpUsedFood += Soldier1.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 2:
                        tmpUsedFood += Soldier2.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 3:
                        tmpUsedFood += Soldier3.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 4:
                        tmpUsedFood += Soldier4.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 5:
                        tmpUsedFood += Soldier5.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 6:
                        tmpUsedFood += Soldier6.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 7:
                        tmpUsedFood += Soldier7.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 8:
                        tmpUsedFood += Soldier8.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 9:
                        tmpUsedFood += Soldier9.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 10:
                        tmpUsedFood += Soldier10.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 11:
                        tmpUsedFood += Soldier11.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 12:
                        tmpUsedFood += Soldier12.food_use * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                }
            }
            tmpUsedFood = tmpUsedFood * 2 * pPathTime;
            return Convert.ToInt64(Math.Ceiling(tmpUsedFood / 3600));
        }
        public long TroopCarry(int zzcsl, int pCarryLevel)
        {
            double tmptotalCarry = 0;
            double tmpCarrylevel = 1 + pCarryLevel * 0.1;
            tmptotalCarry = Soldier9.carry * tmpCarrylevel * zzcsl;                        
            return Convert.ToInt64(tmptotalCarry);
        }
        public long TroopCarry(CampaignArmy pArmies,int pCarryLevel)
        {
            double tmptotalCarry = 0;
            double tmpCarrylevel = 1 + pCarryLevel * 0.1;
            for (int i = 1; i <= 12; i++)
            {
                switch (i)
                {
                    case 1:
                        tmptotalCarry += Soldier1.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 2:
                        tmptotalCarry += Soldier2.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 3:
                        tmptotalCarry += Soldier3.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 4:
                        tmptotalCarry += Soldier4.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 5:
                        tmptotalCarry += Soldier5.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 6:
                        tmptotalCarry += Soldier6.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 7:
                        tmptotalCarry += Soldier7.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 8:
                        tmptotalCarry += Soldier8.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 9:
                        tmptotalCarry += Soldier9.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 10:
                        tmptotalCarry += Soldier10.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 11:
                        tmptotalCarry += Soldier11.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                    case 12:
                        tmptotalCarry += Soldier12.carry * tmpCarrylevel * Convert.ToInt32(pArmies.ArmyInfo[i.ToString()]);
                        break;
                }
            }
            return Convert.ToInt64(tmptotalCarry);
        }
        
        //行军中的距离计算
        public static double EvalDistance(Point p1, Point p2)
        {
            double tmpRt = -1;
            tmpRt = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
            return tmpRt;
        }
        public static Point Cid2Point(int pCid)
        {
            return new Point(pCid % 1000, pCid / 1000);
        }
        public static int Point2Cid(Point pPoint)
        {
            return pPoint.Y * 1000 + pPoint.X;
        }
        
        //时间格式转换
        public static DateTime ConvertIntDateTime(double d)
        {
            DateTime time = DateTime.MinValue;
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            time = startTime.AddSeconds(d);
            return time;
        }
        public static double ConvertDateTimeInt(DateTime time)
        {
            double intResult = 0;
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            intResult = (time - startTime).TotalSeconds;
            return intResult;
        }

        //获得服务器的当前时间
        public double UnixTimeStamp = 0;
        public SocketSendReceiveMs GetServerTime(int pCityId)
        {
            int pUserID = Convert.ToInt32(mLoginUser.UserID);
            SocketSendReceiveMs tmpSocketSRMsg = new SocketSendReceiveMs();
            tmpSocketSRMsg.SendMsg = SendCommand("sendCommand", "CityCommand", new object[] { pUserID, pCityId, mLoginUser.Cookie, 0 }, false);

            MemoryStream tmpReqStr = new MemoryStream();
            MemoryStream tmpAMFStr = new MemoryStream();
            AMFSerializer tmpAmfSer = new AMFSerializer(tmpAMFStr);

            tmpAmfSer.WriteMessage(tmpSocketSRMsg.SendMsg);
            string pReqStr = IECookieString;
            pReqStr = pReqStr.Replace("%LEN%", Convert.ToString(tmpAMFStr.Length));
            byte[] tmpBuf = Encoding.UTF8.GetBytes(pReqStr);
            tmpReqStr.Write(tmpBuf, 0, tmpBuf.Length);
            tmpBuf = tmpAMFStr.ToArray();
            tmpReqStr.Write(tmpBuf, 0, tmpBuf.Length);
            int port = 80;
            IPEndPoint ipEnd = new IPEndPoint(ip, port);

            try
            {
                tmpSocketSRMsg.c.Connect(ipEnd);
            }
            catch (Exception se)
            {
                MessageBox.Show("连接错误" + se.Message, "提示信息", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                return null;
            }
            try
            {
                tmpSocketSRMsg.c.Send(tmpReqStr.ToArray(), tmpReqStr.ToArray().Length, 0);
            }
            catch (Exception ce)
            {
                MessageBox.Show("发送错误:" + ce.Message, "提示信息", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }

            tmpSocketSRMsg.c.BeginReceive(tmpSocketSRMsg.recvBytes, 0, 1024, SocketFlags.None, new AsyncCallback(onGetServerTime), tmpSocketSRMsg);
            tmpReqStr.Close();
            tmpAMFStr.Close();
            tmpSocketSRMsg.ThreadEvent.WaitOne(mMessageTimeout);

            return tmpSocketSRMsg;
        }
        void onGetServerTime(IAsyncResult ar)
        {
            SocketSendReceiveMs tmpSRMsg = (SocketSendReceiveMs)ar.AsyncState;
            int re = 0;

            try
            {
                re = tmpSRMsg.c.EndReceive(ar);
            }
            catch (Exception se)
            {
                MessageBox.Show("goupi错误" + se.Message, "提示信息", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }

            if (re > 0)
            {
                tmpSRMsg.Stream1.Write(tmpSRMsg.recvBytes, 0, re);

            }

            if (tmpSRMsg.Stream1.CanRead && tmpSRMsg.Stream1.Length > 0 && tmpSRMsg.HttpLength < 0)
            {

                string tmpHttpRsp = Encoding.UTF8.GetString(tmpSRMsg.Stream1.ToArray());
                //str = tmpHttpRsp;
                if (tmpHttpRsp.IndexOf("HTTP/1.1 200 OK") > -1 )
                {
                    string time = tmpHttpRsp.Substring(tmpHttpRsp.IndexOf("Expires:")+9);
                    time = time.Substring(0, time.IndexOf(" GMT") + 4);
                    DateTime ServerTime = DateTime.Parse(time);
                    long tmptime = Convert.ToInt64(ConvertDateTimeInt(ServerTime.AddHours(-8)) - ConvertDateTimeInt(DateTime.Now));

                    tmpSRMsg.ReslutValue = tmptime;
                }               
            }

            tmpSRMsg.ThreadEvent.Set();
        }
        
        //出征军队的信息类定义
        public class TroopInfo
        {
            public long troopid;
            public int cid;
            public string cityname;
            public int hid;
            public int targetid;
            public string targetname;
            public long startTime;
            public long pathtime;
            public long endTime;
            public int task;
            public int state;
            public int wtype;
            public TroopInfo(long pid, int pcid, string pcname, int phid, int ptid, string tname, long pstime,long ppathtime, long pendtime, int ptask, int pstate, int ptype)
            {
                troopid = pid;
                cid = pcid;
                cityname = pcname;
                hid = phid;
                targetid = ptid;
                targetname = tname;
                startTime = pstime;
                pathtime = ppathtime;
                endTime = pendtime;
                task = ptask;
                state = pstate;
                wtype = ptype;
            }
        }
        public TroopInfo[] GetArmyTroops()
        {
            int pUserID = Convert.ToInt32(mLoginUser.UserID);
            SocketSendReceiveMs tmpSktData = SendMessage(IECookieString, SendCommand("sendCommand", "Command", new object[] { pUserID, mLoginUser.Cookie, 2, "troop", "getArmyTroops" },true), (ReceivedHandler)OnGetArmyTroops);          
            tmpSktData.ThreadEvent.WaitOne(mMessageTimeout);
            return tmpSktData.ReslutValue as TroopInfo[];
        }
        void OnGetArmyTroops(SocketSendReceiveMs pTagSocket, AcknowledgeMessage pArg)
        {
            if (LoginUser == null) goto Ex;           
            AcknowledgeMessage tmpAckMsg = pArg;//TestReslutCmdMsg(pTagSocket, pArg);
            if (tmpAckMsg != null)
            {
                if (tmpAckMsg.body is Array)
                {
                    object[] tmpObj = tmpAckMsg.body as object[];                    
                    List<TroopInfo> tmpTroops = new List<TroopInfo>();
                    if (tmpObj[4] is Array)
                    {
                        tmpObj = tmpObj[4] as object[];
                        if (tmpObj.Length != 0)
                        {
                            foreach (ASObject tmpASObj in tmpObj)
                            {
                                TroopInfo tmpTrop;
                                tmpTrop = new TroopInfo(Convert.ToInt64(tmpASObj["id"]),Convert.ToInt32(tmpASObj["cid"]),Convert.ToString(tmpASObj["fromcity"]), Convert.ToInt32(tmpASObj["hid"]), Convert.ToInt32(tmpASObj["targetcid"]), Convert.ToString(tmpASObj["targetcity"]),
                                         Convert.ToInt64(tmpASObj["starttime"]), Convert.ToInt64(tmpASObj["pathtime"]), Convert.ToInt64(tmpASObj["endtime"]),Convert.ToInt32(tmpASObj["task"]), Convert.ToInt32(tmpASObj["state"]), Convert.ToInt32(tmpASObj["wtype"]));
                                tmpTroops.Add(tmpTrop);                                   
                            }
                        }
                        pTagSocket.ReslutValue = tmpTroops.ToArray();
                    }
                }
            }
        Ex:
            pTagSocket.ThreadEvent.Set();
        }

        public TroopInfo[] GetStayTroops()
        {
            int pUserID = Convert.ToInt32(mLoginUser.UserID);
            SocketSendReceiveMs tmpSktData = SendMessage(IECookieString, SendCommand("sendCommand", "Command", new object[] { pUserID, mLoginUser.Cookie, 2, "troop", "getStayTroops" }, true), (ReceivedHandler)OnGetStayTroops);

            tmpSktData.ThreadEvent.WaitOne(mMessageTimeout);
            return tmpSktData.ReslutValue as TroopInfo[];
        }
        void OnGetStayTroops(SocketSendReceiveMs pTagSocket, AcknowledgeMessage pArg)
        {
            AcknowledgeMessage tmpAckMsg = pArg;
            if (tmpAckMsg != null)
            {
                object[] tmpObj = tmpAckMsg.body as object[];
                List<TroopInfo> tmpTroops = new List<TroopInfo>();
                if (tmpObj[4] is Array)
                {
                    tmpObj = tmpObj[4] as object[];
                    if (tmpObj[1] is Array)
                    {
                        tmpObj = tmpObj[1] as object[];
                        if (tmpObj.Length != 0)
                        {
                            foreach (ASObject tmpASObj in tmpObj)
                            {
                                TroopInfo tmpTrop;
                                tmpTrop = new TroopInfo(Convert.ToInt64(tmpASObj["id"]), Convert.ToInt32(tmpASObj["cid"]), Convert.ToString(tmpASObj["origincity"]), Convert.ToInt32(tmpASObj["hid"]), Convert.ToInt32(tmpASObj["targetcid"]), tmpASObj.ContainsKey("targetcity") ? Convert.ToString(tmpASObj["targetcity"]) : "",
                                    0,Convert.ToInt64(tmpASObj["pathtime"]), 0, Convert.ToInt32(tmpASObj["task"]), Convert.ToInt32(tmpASObj["state"]), Convert.ToInt32(tmpASObj["wtype"]));
                                tmpTroops.Add(tmpTrop);
                            }
                        }
                        pTagSocket.ReslutValue = tmpTroops.ToArray();
                    }
                }               
            }
            pTagSocket.ThreadEvent.Set();
        }

        public static void fastsort(long[] array, int begin, int end)         //快速排序
        {
            if (begin < 0 || end < 0 || begin > end)
                return;
            int left = begin, right = end;
            long temp;                            //经典的快排
            temp = array[left];
            while (right != left)
            {
                while (temp < array[right] && right > left)
                    right--;
                if (right > left)
                {
                    array[left] = array[right];
                    left++;
                }
                while (temp > array[left] && right > left)
                    left++;
                if (right > left)
                {
                    array[right] = array[left];
                    right--;
                }
            }
            array[right] = temp;
            fastsort(array, right + 1, end);
            fastsort(array, begin, right - 1);
        }

        //刷新城市建筑信息
        public string StartUpgradeBuilding(BuildInfo building, int pCityID, int IsInnerOrOut)
        {
            if (LoginUser == null) return "你已经下线，请重新登录。";
            int pUserID = Convert.ToInt32(mLoginUser.UserID);
            int X = (building.XY - 100) / 10;
            int Y = building.XY - 100 - X * 10;
            if (IsInnerOrOut == 0)
            {
                X = building.XY / 10;
                Y = building.XY - X * 10;
            }
            SocketSendReceiveMs tmpSktData = SendMessage(IECookieString, SendCommand("sendCommand", "Command", new object[] { pUserID, mLoginUser.Cookie, 2, "city", "startUpgradeBuilding", pCityID, IsInnerOrOut, X, Y, building.BuildID }, true), (ReceivedHandler)OnStartUpgradeBuilding);
            tmpSktData.ThreadEvent.WaitOne(mMessageTimeout);
            return tmpSktData.ReslutValue as string;
        }
        void OnStartUpgradeBuilding(SocketSendReceiveMs pTagSocket, AcknowledgeMessage pArg)
        {
            AcknowledgeMessage tmpAckMsg = pArg;
            if (tmpAckMsg != null)
            {
                if (tmpAckMsg.body is Array)
                {
                    object[] tmpObj = tmpAckMsg.body as object[];
                    if (tmpObj.Length == 2)                   
                        pTagSocket.ReslutValue = "建造列表已满，不能再建造新的建筑了。";                    
                    else                       
                        pTagSocket.ReslutValue = "升级成功！";
                }
            }
            pTagSocket.ThreadEvent.Set();
        }

        //获得游戏内的城市建筑信息
        public object[] GetCityBuilding(int pCityID)
        {
            int pUserID = Convert.ToInt32(mLoginUser.UserID);
            SocketSendReceiveMs tmpSktData = SendMessage(IECookieString, SendCommand("sendCommand", "Command", new object[] { pUserID, mLoginUser.Cookie, 2, "city", "getCityBuilding", pCityID }, true), (ReceivedHandler)OnGetCityBuilding);            
            tmpSktData.ThreadEvent.WaitOne(mMessageTimeout);
            return tmpSktData.ReslutValue as object[];
        }
        void OnGetCityBuilding(SocketSendReceiveMs pTagSocket, AcknowledgeMessage pArg)
        {
            AcknowledgeMessage tmpAckMsg = pArg;
            if (tmpAckMsg != null && tmpAckMsg.body is Array)
            {
                object[] tmpObj = tmpAckMsg.body as object[];
                if (tmpObj[4] is Array)
                {
                    tmpObj = tmpObj[4] as object[];
                    pTagSocket.ReslutValue = tmpObj;
                }
            }
            pTagSocket.ThreadEvent.Set();
        }
        public object[] GetBuildingInfo(int pCityID, BuildInfo building, int IsInnerOrOut)
        {
            if (LoginUser == null) return null;
            int pUserID = Convert.ToInt32(mLoginUser.UserID);
            int tmpCmdType = 1;
            List<object> tmpParam = new List<object>();
            tmpParam.Add(pUserID);
            tmpParam.Add(mLoginUser.Cookie);
            tmpParam.Add(tmpCmdType);
            tmpParam.Add(pCityID);

            tmpParam.Add(building.BuildID);       //2
            int X = (building.XY - 100) / 10;
            int Y = building.XY - 100 - X * 10;
            if (IsInnerOrOut == 0)
            {
                X = building.XY / 10;
                Y = building.XY - X * 10;
            }
            int BuildParam = Y * 10 + X;
            tmpParam.Add(BuildParam);        //3
            tmpParam.Add(0);        //5
            tmpParam.Add("getBuildingInfo");  //1
            tmpParam.Add(IsInnerOrOut);     //4....
            tmpParam.Add(X);         //4....
            tmpParam.Add(Y);         //4....
            tmpParam.Add(building.BuildID);   //4....

            SocketSendReceiveMs tmpSktData = SendMessage(IECookieString, SendCommand("sendCommand", "Command", tmpParam.ToArray(), true), (ReceivedHandler)OnGetBuildingInfo);
            tmpSktData.ThreadEvent.WaitOne(mMessageTimeout);
            return (tmpSktData.ReslutValue as object[]);            
        }
        void OnGetBuildingInfo(SocketSendReceiveMs pTagSocket, AcknowledgeMessage pArg)
        {
            if (LoginUser == null) goto Ex;
            AcknowledgeMessage tmpAckMsg = pArg;
            if (tmpAckMsg != null)
            {
                if (tmpAckMsg.body is Array)
                {
                    object[] tmpObj = tmpAckMsg.body as object[];

                    if (tmpObj.Length == 7 && tmpObj[6] is Array)
                    {
                        int tmpInner = (int)tmpObj[3] < 5 ? 0 : 1;
                        int tmpCid = Convert.ToInt32(tmpObj[2]);
                        int tmpBid = (int)tmpObj[4];
                        tmpBid = tmpBid % 10 * 10 + Convert.ToInt32(Math.Floor((decimal)tmpBid / 10)) + tmpInner * 100;
                        tmpObj = tmpObj[6] as object[];    
                        ASObject tmpAsObj = (tmpObj[1] as ASObject);
                        
                        long FoodNeed = Convert.ToInt64(tmpAsObj["foodNeed"]);
                        long IronNeed = Convert.ToInt64(tmpAsObj["ironNeed"]);
                        long RockNeed = Convert.ToInt64(tmpAsObj["rockNeed"]);
                        long WoodNeed = Convert.ToInt64(tmpAsObj["woodNeed"]);
                        long UpgradeTime = Convert.ToInt64(tmpAsObj["upgradeTime"]);
                        object[] tmpObject = new object[] { FoodNeed, WoodNeed, RockNeed, IronNeed, UpgradeTime };
                        
                        pTagSocket.ReslutValue = tmpObject;                       
                    }                    
                }
            }
        Ex:
            pTagSocket.ThreadEvent.Set();
        }
    }
}
