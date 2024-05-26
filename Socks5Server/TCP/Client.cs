using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socks5Server.TCP
{
    public class Client
    {
        private int packetSize = 4096;
        private byte[] buffer;
        

        public Socket socket { get; set; }

        public Client (Socket sock, int packetSize) 
        {
            socket = sock;
            buffer = new byte[packetSize];
            sock.ReceiveBufferSize = packetSize;
        }

        public event EventHandler<DataEventArgs> OnDataReceived = delegate { };
        public event EventHandler<DataEventArgs> OnDataSent = delegate { };

        public void disconnect()
        {
            try
            {
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public bool send(byte[] buffer)
        {
            return (send(buffer, 0, buffer.Length));
        }

        public bool send(byte[] buffer, int offset, int count)
        {
            try
            {
                if (socket != null)
                {
                    if (socket.Send(buffer, offset, count, SocketFlags.None) <= 0)
                    {
                        disconnect();
                        return false;
                    }

                    var data = new DataEventArgs(this, buffer, count);
                    OnDataSent(this, data);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                disconnect();
                return false;
            }       
        }

        public int receive(byte[] data, int offset, int count)
        {
            try
            {
                var received = socket.Receive(data, offset, count, SocketFlags.None);
                if (received <= 0)
                {
                    disconnect();
                    return -1;
                }

                return received;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                disconnect();
                return -1;
            }
        }
    }
}
