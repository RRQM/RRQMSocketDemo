using System;
using RRQMSocket.RPC;

namespace Service
{
    /*
    若汝棋茗
    */

    public class Server : ServerProvider
    {
        private int a = 0;

        [RRQMRPCMethod]
        public string TestOne()
        {
            a++;
            if (a % 1000 == 0)
            {
                Console.WriteLine(a);
            }
            return "若汝棋茗";
        }

        [RRQMRPCMethod]
        public string TestOne(string mes)
        {
            return mes;
        }
    }
}