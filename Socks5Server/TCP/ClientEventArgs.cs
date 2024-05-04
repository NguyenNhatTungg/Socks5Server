using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks5Server.TCP
{
    public class ClientEventArgs : EventArgs
    {
        public Client Client { get; private set; }
        public ClientEventArgs(Client client) 
        {
            Client = client;
        }
    }
}
