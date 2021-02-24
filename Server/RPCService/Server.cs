using System;
using RRQMSocket.RPC;

namespace RPCServiceDemo
{
    /*
    若汝棋茗
    */

    public class Server : ServerProvider
    {
        private int a;

        [RRQMRPCMethod]
        public void TestNullReturnNullParameter()
        {
            if (++a % 1000 == 0)
            {
                Console.WriteLine($"TestNullReturnNullParameter,a={a}");
            }
        }

        [RRQMRPCMethod]
        public string TestStringReturnNullParameter()
        {
            Console.WriteLine("TestStringReturnNullParameter");
            return "若汝棋茗";
        }

        [RRQMRPCMethod]
        public void TestNullReturnStringParameter(string name)
        {
            Console.WriteLine($"TestNullReturnStringParameter,String:{name}");
        }

        [RRQMRPCMethod]
        public void TestNullReturnOutStringParameter(out string name)
        {
            Console.WriteLine($"TestNullReturnOutStringParameter");
            name = "若汝棋茗";
        }

        [RRQMRPCMethod]
        public string TestStringReturnOutStringParameter(out string name)
        {
            Console.WriteLine($"TestStringReturnOutStringParameter");
            name = "若汝棋茗";
            return name;
        }

        [RRQMRPCMethod]
        public void TestNullReturnRefStringParameter(ref string name)
        {
            Console.WriteLine($"TestStringReturnOutStringParameter,String:{name}");
            name = "若汝棋茗";
        }

        [RRQMRPCMethod]
        public void TestNullReturnOutParameters(out string name, out int age, out string occupation)
        {
            Console.WriteLine($"TestNullReturnOutParameters");
            name = "若汝棋茗";
            age = 23;
            occupation = "搬砖工程师";
        }

        [RRQMRPCMethod]
        public void TestClass1(Test01 test01)
        {
        }

        [RRQMRPCMethod]
        public Test02 TestClass1AndClass2(Test01 test01)
        {
            Test02 test02 = new Test02();
            return test02;
        }

        [RRQMRPCMethod]
        public void TestClass3(Test03 test03)
        {
        }
    }
}