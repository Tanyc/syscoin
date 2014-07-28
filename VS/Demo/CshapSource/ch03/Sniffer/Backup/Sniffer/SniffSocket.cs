using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Sniffer
{
    /// <summary>
    /// IP标头结构定义
    /// </summary>
    /// 
    //StructLayoutAttribute可控制类或结构的数据字段的物理布局,
    //枚举值LayoutKind.Explicit表示对象的各个成员在非托管内存中的精确位置被显式控制,
    //每个成员必须使用 FieldOffsetAttribute 指示该字段在类型中的位置。
    [StructLayout(LayoutKind.Explicit)]
    public struct IPHeader
    {

        [FieldOffset(0)]
        public byte versionAndLength;//4位IP版本号+4位IP包头长度
        [FieldOffset(1)]
        public byte typeOfService;//8位服务类型
        [FieldOffset(2)]
        public ushort totalLength;//16位总长度（字节）
        [FieldOffset(4)]
        public ushort identifier;//16位标识 
        [FieldOffset(6)]
        public ushort flagsAndOffset;//3位标志位+13位报片偏移
        [FieldOffset(8)]
        public byte timeToLive;//8位生存时间
        [FieldOffset(9)]
        public byte protocol;//8位协议 (TCP, UDP 或其他)
        [FieldOffset(10)]
        public ushort checksum;//16位IP包头校验和
        [FieldOffset(12)]
        public uint sourceAddress;//32位源IP地址
        [FieldOffset(16)]
        public uint destinationAddress;//32位目的IP地址
    }

    /// <summary>
    /// SniffSocket类定义
    /// </summary>
    public class SniffSocket
    {

        private bool keepRunning;//是否继续捕获标志
        private static int receiveBufferLength;//捕获到的数据流的长度
        private byte[] receiveBufferBytes;//收到的字节流;
        private Socket socket = null;//套接字对象
        //private IAsyncResult ar;//异步操作状态

        /// <summary>
        /// 构造函数
        /// </summary>
        public SniffSocket()
        {

            receiveBufferLength = 4096;//设置捕获到数据包的最大长度
            receiveBufferBytes = new byte[receiveBufferLength];//为数据包预分配存储空间
        }

        /// <summary>
        /// KeepRunning属性定义
        /// </summary>
        public bool KeepRunning
        {
            get { return keepRunning; }
            set { keepRunning = value; }
        }

        /// <summary>
        /// 创建绑定套接字对象
        /// </summary>
        /// <param name="IP">IP地址串</param>
        public void CreateAndBindSocket(string IP)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
            socket.Blocking = false;//指示 Socket 是否处于阻止模式
            socket.Bind(new IPEndPoint(IPAddress.Parse(IP), 0));//使 Socket 与一个本地终结点相关联
            SetSocketOption();//设置Socket选项
        }

        /// <summary>
        /// 设置Socket选项
        /// </summary>
        private void SetSocketOption()
        {
            SniffSocketException ex;
            try
            {
                socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, 1);//将指定的 Socket 选项设置为指定的 Boolean 值。
                byte[] inValue = new byte[4] { 1, 0, 0, 0 };//操作需要的输入数据。
                byte[] outValue = new byte[4];//操作返回的输出数据。
                int ioControlCode = unchecked((int)0x98000001);//指定要执行的操作的控制代码。
                int returnCode = socket.IOControl(ioControlCode, inValue, outValue);//返回outValue 参数中的字节数
                returnCode = outValue[0] + outValue[1] + outValue[2] + outValue[3];
                if (returnCode != 0)
                {
                    ex = new SniffSocketException("command execute error");
                    throw ex;
                }
            }
            catch (SocketException e)
            {
                ex = new SniffSocketException("socket error", e);
                throw ex;
            }
        }

        /// <summary>
        /// 禁止Socket上的发送和接收
        /// </summary>
        public void ShutDown()
        {
            if (socket != null)
            {
                socket.Shutdown(SocketShutdown.Both);
            }
        }

        /// <summary>
        /// 开始从连接的 Socket 中异步接收数据
        /// </summary>
        public void Run()
        {

            //Socket开始异步监听数据包，并利用委托AsyncCallback
            //在相应异步操作完成时调用CallReceive方法进行处理。
            IAsyncResult ar = socket.BeginReceive(receiveBufferBytes, 0, 
                receiveBufferLength, SocketFlags.None,
                new AsyncCallback(CallReceive), this);

        }

        /// <summary>
        /// 异步操作完成时调用的方法（异步回调）
        /// </summary>
        /// <param name="ar">异步操作状态接口参数</param>
        private void CallReceive(IAsyncResult ar)
        {
            int receivedBytes;
            receivedBytes = socket.EndReceive(ar);//结束挂起的异步读取
            Receive(receiveBufferBytes, receivedBytes);//解析接收的数据包，并引发PacketArrival事件。
            if (keepRunning) Run();//继续侦听

        }

        /// <summary>
        /// 解析接收的数据包，封装成PacketArrivedEventArgs事件参数类对象，
        /// 并引发PacketArrival事件。
        /// </summary>
        /// <param name="buf">捕获到的数据</param>
        /// <param name="len">数据的长度</param>
        unsafe private void Receive(byte[] buf, int len)
        {
            byte protocol = 0;
            uint version = 0;
            uint ipSourceAddress = 0;
            uint ipDestinationAddress = 0;
            short sourcePort = 0;
            short destinationPort = 0;
            IPAddress ip;
            PacketArrivedEventArgs e = new PacketArrivedEventArgs();

            fixed (byte* fixedBuf = buf)
            {
                IPHeader* head = (IPHeader*)fixedBuf;
                e.HeaderLength = (uint)(head->versionAndLength & 0x0f) << 2;
                protocol = head->protocol;
                switch (protocol)
                {
                    case 1: e.Protocol = "ICMP:"; break;
                    case 2: e.Protocol = "IGMP:"; break;
                    case 6: e.Protocol = "TCP:"; break;
                    case 17: e.Protocol = "UDP:"; break;
                    default: e.Protocol = "UNKNOWN"; break;
                }

                version = (uint)(head->versionAndLength & 0xf0) >> 4;
                e.Version = version.ToString();

                ipSourceAddress = head->sourceAddress;
                ipDestinationAddress = head->destinationAddress;
                ip = new IPAddress(ipSourceAddress);
                e.OriginationAddress = ip.ToString();
                ip = new IPAddress(ipDestinationAddress);
                e.DestinationAddress = ip.ToString();

                sourcePort = *(short*)&fixedBuf[e.HeaderLength];
                destinationPort = *(short*)&fixedBuf[e.HeaderLength + 2];

                e.OriginationPort = IPAddress.NetworkToHostOrder(sourcePort).ToString();
                e.DestinationPort = IPAddress.NetworkToHostOrder(destinationPort).ToString();

                e.TotalLength = (uint)len;
                e.MessageLength = (uint)len - e.HeaderLength;

                e.ReceiveBuffer = buf;
                Array.Copy(buf, 0, e.HeaderBuffer, 0, (int)e.HeaderLength);
                Array.Copy(buf, (int)e.HeaderLength, e.MessageBuffer, 0, (int)e.MessageLength);
            }
            OnPacketArrival(e);//引发PacketArrival事件
        }

        /// <summary>
        /// 定义封装包数据的事件参数类PacketArrivedEventArgs
        /// </summary>
        public class PacketArrivedEventArgs : EventArgs
        {
            private string protocol;//协议
            private string destinationPort;//目标端口
            private string originationPort;//源端口
            private string destinationAddress;//目标地址
            private string originationAddress;//源地址
            private string version;//IP版本号
            private uint totalLength;//数据包总长度
            private uint messageLength;//数据包中消息长度
            private uint headerLength;//数据包中头长度
            private byte[] receiveBuffer = null;//数据包中数据字节流
            private byte[] headerBuffer = null;//数据包头部数据字节流
            private byte[] messageBuffer = null;//数据包消息数据字节流
            private DateTime date = DateTime.Now;//捕获时间

            /// <summary>
            /// 结构函数
            /// </summary>
            public PacketArrivedEventArgs()
            {
                this.protocol = "";
                this.destinationPort = "";
                this.originationPort = "";
                this.destinationAddress = "";
                this.originationAddress = "";
                this.version = "";

                this.totalLength = 0;
                this.messageLength = 0;
                this.headerLength = 0;

                this.receiveBuffer = new byte[receiveBufferLength];
                this.headerBuffer = new byte[receiveBufferLength];
                this.messageBuffer = new byte[receiveBufferLength];
                this.date = DateTime.Now;
            }

            //属性的定义
            public string Protocol
            {
                get { return protocol; }
                set { protocol = value; }
            }

            public string DestinationPort
            {
                get { return destinationPort; }
                set { destinationPort = value; }
            }

            public string OriginationPort
            {
                get { return originationPort; }
                set { originationPort = value; }
            }

            public string DestinationAddress
            {
                get { return destinationAddress; }
                set { destinationAddress = value; }
            }

            public string OriginationAddress
            {
                get { return originationAddress; }
                set { originationAddress = value; }
            }

            public string Version
            {
                get { return version; }
                set { version = value; }
            }

            public uint TotalLength
            {
                get { return totalLength; }
                set { totalLength = value; }
            }

            public uint MessageLength
            {
                get { return messageLength; }
                set { messageLength = value; }
            }

            public uint HeaderLength
            {
                get { return headerLength; }
                set { headerLength = value; }
            }

            public byte[] ReceiveBuffer
            {
                get { return receiveBuffer; }
                set { receiveBuffer = value; }
            }

            public byte[] HeaderBuffer
            {
                get { return headerBuffer; }
                set { headerBuffer = value; }
            }

            public byte[] MessageBuffer
            {
                get { return messageBuffer; }
                set { messageBuffer = value; }
            }

            public DateTime Date
            {
                get { return date; }
                set { date = value; }
            }
        }

        //定义处理包的委托及事件对象
        public delegate void PacketArrivedEventHandler(object sender, 
            PacketArrivedEventArgs args);//定义委托
        public event PacketArrivedEventHandler PacketArrival;//定义事件

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="e">事件参数</param>
        protected virtual void OnPacketArrival(PacketArrivedEventArgs e)
        {
            if (PacketArrival != null)
            {
                PacketArrival(this, e);

            }
        }

        /// <summary>
        /// 自定义异常
        /// </summary>
        public class SniffSocketException : Exception
        {
            public SniffSocketException()
                : base()
            { }
            public SniffSocketException(string message)
                : base(message)
            { }
            public SniffSocketException(string message, Exception innerException)
                : base(message, innerException)
            { }
        }

    }
}
