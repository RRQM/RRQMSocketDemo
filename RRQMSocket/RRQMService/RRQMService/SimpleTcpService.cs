using RRQMSocket;
using SocketClientLiberal;

namespace RRQMServiceTest
{
    /*
    若汝棋茗
    */

    public class SimpleTcpService : TcpService<SimpleTcpSocketClient>
    {
        #region Methods

        /// <summary>
        ///重写TcpSocketClient的获取方式，类似于SimpleTcpSocketClient类，该类继承于抽象类TcpSocketClient
        ///该方法的主要作用是生成用于和客户端通信的辅助类
        /// </summary>
        /// <returns></returns>
        protected override SimpleTcpSocketClient CreatSocketCliect()
        {
            SimpleTcpSocketClient socketClient = new SimpleTcpSocketClient();
            return socketClient;
        }

        #endregion Methods
    }
}
