using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionTemplate
{
    class UDPConnection : Connection
    {
        public UDPConnection() : base(CONNECTION_TYPE.UDP)
        {

        }

        public override int buildPacket()
        {
            throw new NotImplementedException();
        }
    }
}
