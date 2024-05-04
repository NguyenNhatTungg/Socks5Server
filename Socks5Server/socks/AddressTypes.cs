using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks5Server.socks
{
    public enum AddressTypes
    {
        ipV4 = 0x01,
        domain = 0x03,
        ipV6 = 0x04
    }
}
