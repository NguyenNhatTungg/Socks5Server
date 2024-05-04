using Socks5Server.socks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks5Server.TCP
{
    public class DataEventArgs
    {
        public Client client { get; set; }
        public byte[] buffer { get; set; }
        public int count { get; set; }
        public int offset { get; set; }
        public SocksRequest? request { get; set; }

        public DataEventArgs(Client Client, byte[] Buffer, int Count, SocksRequest? req = null)
        {
            Client = client;
            Buffer = buffer;
            Count = count;
            offset = 0;
            request = req;
        }
    }
}
