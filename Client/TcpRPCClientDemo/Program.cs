using System;
using RRQMSocket;
using RRQMSocket.RPC;

namespace TcpRPCClientDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ReadKey();
            BinarySerialize();
            JsonSerialize();
            XmlSerialize();
            Console.ReadKey();
        }

        private static void BinarySerialize()
        {
            //序列化默认为二进制

            RPCClient client = new RPCClient();

            ConnectSetting confirmSocket = new ConnectSetting();
            confirmSocket.TargetIP = "127.0.0.1";
            confirmSocket.TargetPort = 7789;

            client.Connect(confirmSocket);
            client.InitializedRPC();
            Console.WriteLine();
            Console.WriteLine("二进制连接成功");

            RemoteTest remoteTest = new RemoteTest(client);

            remoteTest.Test01();
            remoteTest.Test02();
            remoteTest.Test03();
            remoteTest.Test04();
            remoteTest.Test05();
            remoteTest.Test06();
            remoteTest.Test07();
            remoteTest.Test08();
            remoteTest.Test09();
            remoteTest.Test10();

            Console.WriteLine("二进制测试完成");
            Console.WriteLine();
        }

        private static void JsonSerialize()
        {
            RPCClient client = new RPCClient();

            client.SerializeConverter = new RRQMSocket_SerializeConverter.JsonSerializeConverter();

            ConnectSetting confirmSocket = new ConnectSetting();
            confirmSocket.TargetIP = "127.0.0.1";
            confirmSocket.TargetPort = 7790;

            client.Connect(confirmSocket);
            client.InitializedRPC();
            Console.WriteLine();
            Console.WriteLine("Json连接成功");

            RemoteTest remoteTest = new RemoteTest(client);

            remoteTest.Test01();
            remoteTest.Test02();
            remoteTest.Test03();
            remoteTest.Test04();
            remoteTest.Test05();
            remoteTest.Test06();
            remoteTest.Test07();
            remoteTest.Test08();
            remoteTest.Test09();
            remoteTest.Test10();

            Console.WriteLine("Json测试完成");
            Console.WriteLine();
        }

        private static void XmlSerialize()
        {
            RPCClient client = new RPCClient();

            client.SerializeConverter = new XmlSerializeConverter();

            ConnectSetting confirmSocket = new ConnectSetting();
            confirmSocket.TargetIP = "127.0.0.1";
            confirmSocket.TargetPort = 7791;

            client.Connect(confirmSocket);
            client.InitializedRPC();
            Console.WriteLine();
            Console.WriteLine("Xml连接成功");

            RemoteTest remoteTest = new RemoteTest(client);

            remoteTest.Test01();
            remoteTest.Test02();
            remoteTest.Test03();
            remoteTest.Test04();
            remoteTest.Test05();
            remoteTest.Test06();
            remoteTest.Test07();
            remoteTest.Test08();
            remoteTest.Test09();
            remoteTest.Test10();

            Console.WriteLine("Xml测试完成");
            Console.WriteLine();
        }
    }
}