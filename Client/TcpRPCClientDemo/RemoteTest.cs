using System;
using RRQMCore.Diagnostics;
using RRQMRPC.RRQMTest;
using RRQMSocket.RPC;

namespace TcpRPCClientDemo
{
    public class RemoteTest
    {
        public RemoteTest(RPCClient client)
        {
            server = new Server(client);
        }

        private Server server;

        /// <summary>
        /// 测试无返回值无参数
        /// </summary>
        public void Test01()
        {
            int count = 100000;
            Console.WriteLine($"即将测试性能，调用无参数，无返回值方法{count}次");
            TimeSpan timeSpan = TimeMeasurer.Run(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    server.TestNullReturnNullParameter(100);
                    if ((i + 1) % 1000 == 0)
                    {
                        Console.WriteLine(i + 1);
                    }
                }
            });

            Console.WriteLine("Test01=>性能测试完成，耗时->" + timeSpan);
            Console.WriteLine();
        }

        /// <summary>
        /// 测试无返回值多个Out类型参数
        /// </summary>
        public void Test02()
        {
            string name;
            int age;
            string occupation;
            server.TestNullReturnOutParameters(out name, out age, out occupation);
            Console.WriteLine($"Test02=>TestNullReturnOutParameters完成,name={name},age={age},occupation={occupation}");
        }

        /// <summary>
        /// 测试无返回值单个out类型参数
        /// </summary>
        public void Test03()
        {
            string name;
            server.TestNullReturnOutStringParameter(out name);
            Console.WriteLine($"Test03=>TestNullReturnOutStringParameter完成,name={name}");
        }

        /// <summary>
        /// 测试无返回值，ref类型参数
        /// </summary>
        public void Test04()
        {
            string name = "张三";
            server.TestNullReturnRefStringParameter(ref name);
            Console.WriteLine($"Test04=>TestNullReturnRefStringParameter完成,name={name}");
        }

        /// <summary>
        /// 测试无返回值，String类型参数
        /// </summary>
        public void Test05()
        {
            string name = "张三";
            server.TestNullReturnStringParameter(name);
            Console.WriteLine($"Test05=>TestNullReturnStringParameter完成");
        }

        /// <summary>
        /// 测试String返回值，无参数
        /// </summary>
        public void Test06()
        {
            string s = server.TestStringReturnNullParameter();
            Console.WriteLine($"Test06=>TestStringReturnNullParameter完成,Return={s}");
        }

        /// <summary>
        /// 测试String返回值，out 类型参数
        /// </summary>
        public void Test07()
        {
            string name;
            string s = server.TestStringReturnOutStringParameter(out name);
            Console.WriteLine($"Test07=>TestStringReturnOutStringParameter完成,Return={s},name={name}");
        }

        /// <summary>
        /// 测试其他类参数引用
        /// </summary>
        public void Test08()
        {
            Test01 test01 = new Test01() { Age = 10, Name = "若汝棋茗" };
            server.TestClass1(test01);
            Console.WriteLine($"Test08=>TestClass1完成");
        }

        public void Test09()
        {
            Test01 test01 = new Test01() { Age = 10, Name = "若汝棋茗" };
            Test02 test02 = server.TestClass1AndClass2(test01, 100);
            Console.WriteLine($"Test09=>TestClass1AndClass2完成");
        }

        public void Test10()
        {
            Test03 test03 = new Test03();
            server.TestClass3(test03);
            Console.WriteLine($"Test10=>TestClass3完成");
        }
    }
}