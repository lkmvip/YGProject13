using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class Connect
{
      private byte[] dataReceive = new byte[0x5dc];
      private Socket listenSocket;
      private IPEndPoint MyServer;

      public Connect(string ip, int p)
      {
            this.MyServer = new IPEndPoint(IPAddress.Parse(ip), p);
            this.listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
      }

      public void Dispose()
      {
            try
            {
                  this.listenSocket.Shutdown(SocketShutdown.Both);
            }
            catch
            {
            }
            if (this.listenSocket != null)
            {
                  this.listenSocket.Close();
            }
            this.listenSocket = null;
      }

      public void Sestup()
      {
            try
            {
                  this.listenSocket.Connect(this.MyServer);
            }
            catch
            {
            }
      }

      public void 发送(string msg)
      {
            try
            {
                  byte[] bytes = Encoding.Default.GetBytes(msg);
                  byte[] dst = new byte[bytes.Length + 6];
                  dst[0] = 170;
                  dst[1] = 0x66;
                  Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, dst, 2, 4);
                  Buffer.BlockCopy(bytes, 0, dst, 6, bytes.Length);
                  this.listenSocket.Send(dst, dst.Length, SocketFlags.None);
            }
            catch (Exception)
            {
            }
      }

      public string 收()
      {
            try
            {
                  int count = this.listenSocket.Receive(this.dataReceive, this.dataReceive.Length, SocketFlags.None);
                  byte[] dst = new byte[count];
                  Buffer.BlockCopy(this.dataReceive, 0, dst, 0, count);
                  int num2 = 0;
                  if ((170 == dst[0]) && (0x66 == dst[1]))
                  {
                        byte[] buffer2 = new byte[4];
                        Buffer.BlockCopy(dst, 2, buffer2, 0, 4);
                        int num3 = BitConverter.ToInt32(buffer2, 0);
                        if (count >= (num3 + 6))
                        {
                              byte[] buffer3 = new byte[num3];
                              Buffer.BlockCopy(dst, num2 + 6, buffer3, 0, num3);
                              num2 = (num2 + num3) + 6;
                              return Encoding.Default.GetString(buffer3);
                        }
                  }
                  return "0";
            }
            catch (Exception)
            {
                  return "0";
            }
      }
}

