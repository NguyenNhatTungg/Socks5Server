using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks5Server.socks
{
    public enum AuthTypes
    {
        Login = 0x02,
        SocksCompress = 0x88,
        SocksEncrypt = 0x90,
        SocksBoth = 0xFE,
        Unsupported = 0xFF,
        None = 0x00
    }
}
