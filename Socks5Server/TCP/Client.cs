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
    }
}
