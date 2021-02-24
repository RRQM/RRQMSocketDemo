using System;
using System.Text;
using RRQMCore.ByteManager;
using RRQMSocket;

namespace TcpClientDemo
{
    /*
    若汝棋茗
    */

    /// <summary>
    /// 该类是基于Socket的简单TCP的客户端类
    /// 通过该类发送的字节流不完全和接收方保持一致
    /// 可能会发生分包、粘包等情况
    /// </summary>
    public class SimpleTcpClient : TcpClient
    {
        #region Methods

        /// <summary>
        /// 该方法主要作用是对服务器发送来的字节流进行处理
        /// 该数据与发送方不完全一致，可能会发生粘包，分包等情况。
        /// 当然也如果服务器没有返回数据的话，也不会调用该方法。
        /// </summary>
        /// <param name="byteBlock"></param>
        public override void HandleBuffer(ByteBlock byteBlock)
        {
            string mes = Encoding.UTF8.GetString(byteBlock.Buffer, 0, (int)byteBlock.Position);
            Console.WriteLine($"已接收到信息：{mes}");
        }

        #endregion Methods
    }
}