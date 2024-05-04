using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks5Server.socks
{
    public enum StreamTypes
    {
        Stream = 0x01,
        Bind = 0x02,
        Udp = 0x03
    }
}
