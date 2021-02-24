using System;
using RRQMSocket;
using RRQMSocket.RPC;

namespace RPCServiceDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OpenBinarySerializeService();
            OpenJsonSerializeService();
            OpenXmlSerializeService();
            Console.ReadKey();
        }

        private static void OpenBinarySerializeService()
        {
            TcpRPCService rpcService = new TcpRPCService();
            BindSetting bindSetting = new BindSetting();
            bindSetting.IP = "127.0.0.1";
            bindSetting.Port = 7789;
            bindSetting.MultithreadThreadCount = 10;
            rpcService.Bind(bindSetting);
            RPCServerSetting setting = new RPCServerSetting();
            setting.NameSpace = "RRQMTest";
            setting.Version = new Version(2, 0, 0, 0);
            setting.ProxyToken = "123TT";
            rpcService.OpenRPCServer(setting);
            Console.WriteLine("二进制序列化服务器绑定成功");
        }

        private static void OpenJsonSerializeService()
        {
            TcpRPCService rpcService = new TcpRPCService();
            BindSetting bindSetting = new BindSetting();
            bindSetting.IP = "127.0.0.1";
            bindSetting.Port = 7790;
            bindSetting.MultithreadThreadCount = 10;
            rpcService.Bind(bindSetting);
            RPCServerSetting setting = new RPCServerSetting();
            setting.NameSpace = "RRQMTest";
            rpcService.OpenRPCServer(setting);
            rpcService.SerializeConverter = new RRQMSocket_SerializeConverter.JsonSerializeConverter();
            Console.WriteLine("Json序列化服务器绑定成功");
        }

        private static void OpenXmlSerializeService()
        {
            TcpRPCService rpcService = new TcpRPCService();
            BindSetting bindSetting = new BindSetting();
            bindSetting.IP = "127.0.0.1";
            bindSetting.Port = 7791;
            bindSetting.MultithreadThreadCount = 10;
            rpcService.Bind(bindSetting);
            RPCServerSetting setting = new RPCServerSetting();
            setting.NameSpace = "RRQMTest";
            rpcService.OpenRPCServer(setting);
            rpcService.SerializeConverter = new XmlSerializeConverter();
            Console.WriteLine("Xml序列化服务器绑定成功");
        }
    }
}