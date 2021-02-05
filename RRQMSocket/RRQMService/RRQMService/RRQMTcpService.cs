using RRQMSocket;
using SocketClientLiberal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRQMServiceTest
{
    public class RRQMTcpService : TcpService<RRQMTcpSocketClient>
    {
        #region Methods

        /// <summary>
        ///重写TcpSocketClient的获取方式，类似于RRQMTcpSocketClient类，该类继承于抽象类TcpSocketClient
        ///该方法的主要作用是生成用于和客户端通信的辅助类
        /// </summary>
        /// <returns></returns>
        protected override RRQMTcpSocketClient CreatSocketCliect()
        {
            RRQMTcpSocketClient socketClient = new RRQMTcpSocketClient();
            return socketClient;
        }

        #endregion Methods
    }
}
