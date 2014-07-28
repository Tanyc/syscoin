using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using FluorineFx.IO;
using FluorineFx.Messaging.Messages;
using System.IO;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using FluorineFx.Json;
using System.Net;
//using MSScriptControl;
using Games;

using System.Xml;
using System.Windows.Forms;

namespace Games
{
    partial class Sanguo
    {
        public class GameMessages
        {
            public static bool Mo = false;
            #region 加密服务区
            #region XXTea
            public class JSXTea
            {
                #region JS代码
                private static string mJSCode = @"
function encodeDataNow(c,b)
{
  var a=xtea_encrypt(b,c);
  return base64_encode(a)
}
function base64_encode(e)
{
  var d='ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=';
  var c='';
  var b=e.length;
  var a,g;
  var f=0;
  while(b-->0)
  {
    a=e.charCodeAt(f++);
    c+=d.charAt((a>>2)&63);
    if(b--<=0)
    {
      c+=d.charAt((a<<4)&63);
      c+='==';
      break
    }
    g=e.charCodeAt(f++);
    c+=d.charAt(((a<<4)|((g>>4)&15))&63);
    if(b--<=0)
    {
      c+=d.charAt((g<<2)&63);
      c+='=';
      break
    }
    a=e.charCodeAt(f++);
    c+=d.charAt(((g<<2)|((a>>6)&3))&63);
    c+=d.charAt(a&63)
  }
  return c
}
function long2str(c,b)
{
  var e=c.length;
  var f=(e-1)<<2;
  if(b)
  {
    var a=c[e-1];
    if((a<f-3)||(a>f))
    {
      return null
    }
    f=a
  }
  for(var d=0;d<e;d++)
  {
    c[d]=String.fromCharCode(c[d]&255,c[d]>>>8&255,c[d]>>>16&255,c[d]>>>24&255)
  }
  if(b)
  {
    return c.join('').substring(0,f)
  }
  else
  {
    return c.join('')
  }
}
function str2long(e,b)
{
  var a=e.length;
  var c=[];
  for(var d=0;d<a;d+=4)
  {
    c[d>>2]=e.charCodeAt(d)|e.charCodeAt(d+1)<<8|e.charCodeAt(d+2)<<16|e.charCodeAt(d+3)<<24
  }
  if(b)
  {
    c[c.length]=a
  }
  return c
}
function xtea_encrypt(h,o)
{
  if(h=='')
  {
    return''
  }
  var r=str2long(h,true);
  var d=str2long(o,false);
  if(d.length<4)
  {
    d.length=4
  }
  var c=r.length-1;
  var i=r[c],j=r[0],m=2654435769;
  var l,g,b,a=Math.floor(6+52/(c+1)),f=0;
  while(0<a--)
  {
    f=f+m&4294967295;
    g=f>>>2&3;
    for(b=0;b<c;b++)
    {
      j=r[b+1];
      l=(i>>>5^j<<2)+(j>>>3^i<<4)^(f^j)+(d[b&3^g]^i);
      i=r[b]=r[b]+l&4294967295
    }
    j=r[0];
    l=(i>>>5^j<<2)+(j>>>3^i<<4)^(f^j)+(d[b&3^g]^i);
    i=r[c]=r[c]+l&4294967295
  }
  return long2str(r,false)
}
";
                #endregion
                //private static ScriptEngine mSE = new ScriptEngine();
                //static JSXTea()
                //{
                //    mSE.Language = ScriptLanguage.JavaScript;

                //}
                //public static string Encrypt(string pStr, string pKey)
                //{
                //    object tmpRt = mSE.Run("encodeDataNow", new object[] { pKey, pStr }, mJSCode);
                //    if (tmpRt.GetType() == typeof(string))
                //        return Convert.ToString(tmpRt);
                //    else
                //        return "";
                //}
            }
            /// <summary>
            /// XXTEA 加密算法的摘要说明
            /// </summary>
            public class XXTEA
            {
                public static Byte[] Encrypt(Byte[] Data, Byte[] Key)
                {
                    if (Data.Length == 0)
                    {
                        return Data;
                    }
                    return ToByteArray(Encrypt(ToUInt32Array(Data, true), ToUInt32Array(Key, false)), false);
                }
                public static Byte[] Decrypt(Byte[] Data, Byte[] Key)
                {
                    if (Data.Length == 0)
                    {
                        return Data;
                    }
                    return ToByteArray(Decrypt(ToUInt32Array(Data, false), ToUInt32Array(Key, false)), true);
                }
                public static UInt32[] Encrypt(UInt32[] v, UInt32[] k)
                {
                    Int32 n = v.Length - 1;
                    if (n < 1)
                    {
                        return v;
                    }
                    if (k.Length < 4)
                    {
                        UInt32[] Key = new UInt32[4];
                        k.CopyTo(Key, 0);
                        k = Key;
                    }
                    UInt32 z = v[n], y = v[0], delta = 0x9E3779B9, sum = 0, e;
                    Int32 p, q = 6 + 52 / (n + 1);
                    while (q-- > 0)
                    {
                        sum = unchecked(sum + delta);
                        e = sum >> 2 & 3;
                        for (p = 0; p < n; p++)
                        {
                            y = v[p + 1];
                            z = unchecked(v[p] += (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z));
                        }
                        y = v[0];
                        z = unchecked(v[n] += (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z));
                    }
                    return v;
                }
                public static UInt32[] Decrypt(UInt32[] v, UInt32[] k)
                {
                    Int32 n = v.Length - 1;
                    if (n < 1)
                    {
                        return v;
                    }
                    if (k.Length < 4)
                    {
                        UInt32[] Key = new UInt32[4];
                        k.CopyTo(Key, 0);
                        k = Key;
                    }
                    UInt32 z = v[n], y = v[0], delta = 0x9E3779B9, sum, e;
                    Int32 p, q = 6 + 52 / (n + 1);
                    sum = unchecked((UInt32)(q * delta));
                    while (sum != 0)
                    {
                        e = sum >> 2 & 3;
                        for (p = n; p > 0; p--)
                        {
                            z = v[p - 1];
                            y = unchecked(v[p] -= (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z));
                        }
                        z = v[n];
                        y = unchecked(v[0] -= (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z));
                        sum = unchecked(sum - delta);
                    }
                    return v;
                }
                private static UInt32[] ToUInt32Array(Byte[] Data, Boolean IncludeLength)
                {
                    Int32 n = (((Data.Length & 3) == 0) ? (Data.Length >> 2) : ((Data.Length >> 2) + 1));
                    UInt32[] Result;
                    if (IncludeLength)
                    {
                        Result = new UInt32[n + 1];
                        Result[n] = (UInt32)Data.Length;
                    }
                    else
                    {
                        Result = new UInt32[n];
                    }
                    n = Data.Length;
                    for (Int32 i = 0; i < n; i++)
                    {
                        Result[i >> 2] |= (UInt32)Data[i] << ((i & 3) << 3);
                    }
                    return Result;
                }
                private static Byte[] ToByteArray(UInt32[] Data, Boolean IncludeLength)
                {
                    Int32 n;
                    if (IncludeLength)
                    {
                        n = (Int32)Data[Data.Length - 1];
                    }
                    else
                    {
                        n = Data.Length << 2;
                    }
                    Byte[] Result = new Byte[n];
                    for (Int32 i = 0; i < n; i++)
                    {
                        Result[i] = (Byte)(Data[i >> 2] >> ((i & 3) << 3));
                    }
                    return Result;
                }
            }
            #endregion
            public static string GameUIAddress = "";
            public static string GameClientGUID = "";
            public static string GlobalCookie = "";
          
            //public static string DynPwdUrl = "";

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

            public static string RequestMessageCookie { get; set; }

            static string GetNewHead(string pStr)
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
                                Console.WriteLine("Cookie 未捕捉到。");
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
                                tmpPasswordUrl = GetPublicPassword(tmpPasswordUrl);
                                MsgPassword = tmpPasswordUrl;
                                GameClientGUID = ParsePublicKey(tmpStr);
                            }
                        }
                        break;
                    default:
                        tmpStr = GameClientGUID;
                        break;
                }
                if (MsgPassword.Equals("WAIGUASB"))
                    MsgPassword = GetPublicPassword("");
                byte[] tmpBuf = XXTEA.Encrypt(Encoding.UTF8.GetBytes(pStr), Encoding.UTF8.GetBytes(GameClientGUID));
                tmpStr = Convert.ToBase64String(tmpBuf);
                //tmpStr = JSXTea.Encrypt(pStr, GameClientGUID);
                return tmpStr;
            }
            static string GetNewHead(string pStr, string pServer)
            {
                if (pServer.ToLower().StartsWith("http://"))
                    GameUIAddress = pServer;
                else
                    GameUIAddress = "http://" + pServer;
                return GetNewHead(pStr);
            }
#if DEBUG
            public static string ParaseNewHead(string pStr, string pServer)
            {
                string tmpStr = "";
                if (GameClientGUID.Length == 0)
                {
                    WebClient tmpWc = new WebClient();
                    
                    tmpStr = tmpWc.DownloadString(string.Format("http://" + pServer));
                    string tmpPasswordUrl = tmpStr.Substring(tmpStr.IndexOf("getSwfPassFile"));
                    tmpPasswordUrl = tmpPasswordUrl.Substring(0, tmpPasswordUrl.IndexOf(";"));
                    tmpPasswordUrl = tmpPasswordUrl.Substring(tmpPasswordUrl.IndexOf("'")).Replace("'", "");
                    tmpPasswordUrl = GetPublicPassword(tmpPasswordUrl);
                    MsgPassword = tmpPasswordUrl;
                    string tmpTagChar = tmpStr.Substring(tmpStr.IndexOf("var a="));
                    tmpTagChar = tmpTagChar.Substring(0, tmpTagChar.IndexOf(";"));
                    tmpTagChar = tmpTagChar.Substring(tmpTagChar.IndexOf(",") + 1, tmpTagChar.IndexOf(")") - tmpTagChar.IndexOf(",") - 1);
                    tmpStr = ParsePublicKey(tmpStr);
                    GameClientGUID = tmpStr;
                }
                else
                {
                    tmpStr = GameClientGUID;

                }

                byte[] tmpBuf = Convert.FromBase64String(pStr);
                tmpBuf = XXTEA.Decrypt(tmpBuf, Encoding.UTF8.GetBytes(GameClientGUID));
                tmpStr = Encoding.UTF8.GetString(tmpBuf);
                return tmpStr;
            }
            /// <summary>
            /// 解密函数
            /// </summary>
            /// <param name="pDesString"></param>
            /// <param name="pKey"></param>
            /// <returns></returns>
            public static string Des(string pDesString, string pKey, string pServer)
            {
                try
                {
                    string tmpTagStr = ParaseNewHead(pDesString, pServer);
                    //simple-des-ecb
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        DES tmpDes = DES.Create();
                        tmpDes.Mode = CipherMode.ECB;
                        tmpDes.Padding = PaddingMode.PKCS7;
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, tmpDes.CreateDecryptor(Encoding.ASCII.GetBytes(pKey), Encoding.ASCII.GetBytes(pKey)), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(Convert.FromBase64String(tmpTagStr), 0, Convert.FromBase64String(tmpTagStr).Length);
                            cryptoStream.FlushFinalBlock();
                            byte[] bytes = memoryStream.ToArray();
                            return Encoding.UTF8.GetString(bytes);
                        }
                    }
                }
                catch { return ""; }
            }
#endif
            /// <summary>
            /// 交互时是否为安全加密模式
            /// </summary>
            public static bool SafeMode = false;
            /// <summary>
            /// 交互密码
            /// </summary>
            public static string MsgPassword = "WAIGUASB";
            /// <summary>
            /// 加密函数
            /// </summary>
            /// <param name="pString"></param>
            /// <param name="pKey"></param>
            /// <returns></returns>
            static string Enc(string pString, string pKey)
            {
                try
                {
                    //simple-des-ecb
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        
                        DES tmpDes = DES.Create();
                        tmpDes.Mode = CipherMode.ECB;
                        tmpDes.Padding = PaddingMode.PKCS7;
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, tmpDes.CreateEncryptor(Encoding.ASCII.GetBytes(pKey), Encoding.ASCII.GetBytes(pKey)), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(Encoding.UTF8.GetBytes(pString), 0, Encoding.UTF8.GetBytes(pString).Length);
                            cryptoStream.FlushFinalBlock();
                            byte[] bytes = memoryStream.ToArray();
                            string tmpStr = Convert.ToBase64String(bytes);
                            if (Sanguo.gameVersion != 1120)
                                tmpStr = GetNewHead(tmpStr);
                            return tmpStr;
                        }
                    }
                }
                catch { return ""; }
            }
            /// <summary>
            /// JSON序列化函数
            /// </summary>
            /// <param name="pWriter"></param>
            /// <param name="pObj"></param>
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
            /// <summary>
            /// JSON转换函数
            /// </summary>
            /// <param name="pWriter"></param>
            /// <param name="pObj"></param>
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
            #endregion
            static int mResponseID = 0;
            public static string ResponseID
            {
                get
                {
                    mResponseID++;
                    return string.Format("/{0}", mResponseID);
                }
            }
            /// <summary>
            /// 获取安全SESSION编号
            /// </summary>
            public static AMFMessage GetPHPSessId_Old
            {
                get
                {
                    AMFMessage tmpMsg = new AMFMessage(3);
                    CommandMessage tmpCmd = new CommandMessage(5);
                    tmpCmd.messageId = Guid.NewGuid().ToString().ToUpper();
                    tmpCmd.headers.Add("DSId", "nil");
                    tmpCmd.headers.Add("DSMessagingVersion", 1);

                    AMFBody tmpMsgBody = new AMFBody("null", ResponseID, new object[] { tmpCmd });
                    mResponseID++;
                    tmpMsg.AddBody(tmpMsgBody);


                    return tmpMsg;
                }
            }
            /// <summary>
            /// 获取安全SESSION编号
            /// </summary>
            public static AMFMessage GetPHPSessId
            {
                get
                {
                    AMFMessage tmpMsg = new AMFMessage(3);
                    CommandMessage tmpCmd = new CommandMessage(5);
                    tmpCmd.messageId = Guid.NewGuid().ToString().ToUpper();
                    tmpCmd.headers.Add("DSMessagingVersion", 1);
                    tmpCmd.headers.Add("DSId", "nil");

                    AMFBody tmpMsgBody = new AMFBody("null", ResponseID, new object[] { tmpCmd });
                    mResponseID++;
                    tmpMsg.AddBody(tmpMsgBody);


                    return tmpMsg;
                }
            }
       
            public class Command
            {
                private static string mCommandKey = "bure90A8p1l25wDo52567QPbfTl15d7i34n350R92Y6V6nj82dGL2J1mib8i";
                static string getMd5(string md5)
                {
                    System.Security.Cryptography.MD5CryptoServiceProvider md = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    byte[] value, hash;
                    value = System.Text.Encoding.UTF8.GetBytes(md5);
                    hash = md.ComputeHash(value);
                    md.Clear();
                    string temp = "";
                    for (int i = 0, len = hash.Length; i < len; i++)
                    {
                        temp += hash[i].ToString("x").PadLeft(2, '0');
                    }
                    return temp;
                }

                
                /// <summary>
                /// 16进制字符串转换字节数组
                /// </summary>
                /// <param name="str16"></param>
                /// <returns></returns>
                public static byte[] str16ToBytes(string str16)
                {
                    str16 = str16.Replace(" ", "");
                    if ((str16.Length % 2) != 0)
                        str16 += " ";
                    byte[] returnBytes = new byte[str16.Length / 2];
                    for (int i = 0; i < returnBytes.Length; i++)
                        returnBytes[i] = Convert.ToByte(str16.Substring(i * 2, 2), 16);
                    return returnBytes;
                }

                public static AMFMessage bAMFDeserializer(byte[] bts)
                {
                    using (MemoryStream ms = new MemoryStream(bts))
                    {
                        using (AMFDeserializer deafm = new AMFDeserializer(ms))
                        {
                            return deafm.ReadAMFMessage();
                        }
                    }
                }
                
            }
            private static DateTime _dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
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
        }
    }
}