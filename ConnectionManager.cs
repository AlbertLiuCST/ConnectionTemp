using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionTemplate
{
    class ConnectionManager
    {
        public static Connection initConnection(string adr,int port,int socket,CONNECTION_TYPE type)
        {
            switch (type)
            {
                case CONNECTION_TYPE.TCP:
                    return new TCPConnection(adr,port,socket);
                case CONNECTION_TYPE.UDP:
                    return new UDPConnection();
                default:
                    return null;
            }
        }
        public static void closeConnection(Connection *conn)
        {
            conn->close();
        }
    }
}
