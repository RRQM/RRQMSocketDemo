﻿using RRQMSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRQMClientTest
{
    /// <summary>
    /// 该类是基于TcpClient的TCP客户端类
    /// 通过该类发送的字节流完全和接收方保持一致
    /// </summary>
    public class RRQMTcpClient : RRQMClient
    {
        int a;
        protected override void RRQMTcpHandleBuffer(byte[] buffer)
        {
            string mes = Encoding.UTF8.GetString(buffer,0,buffer.Length);

            if (++a%10000==0)
            {
                Console.WriteLine($"{a}已接收到信息：{mes}");
            }
          
        }
    }
}
