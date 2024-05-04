using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socks5Server.TCP
{
    public class TcpServer
    {
        private TcpListener _listener;

        private bool _accept;

        public TcpServer(IPAddress iPAddress, int port)
        {
            _listener = new TcpListener(iPAddress, port);
        }


    }
}
