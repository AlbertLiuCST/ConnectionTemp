using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionTemplate
{
    class TCPConnection : Connection
    {
        
        public TCPConnection(string ip,int port,int socket) : base (CONNECTION_TYPE.TCP) {
            
        }
        public override int buildPacket()
        {
            return 1;
        }

        public override void close()
        {
            isConnected = false;
            
        }
    }
}
