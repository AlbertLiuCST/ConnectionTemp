namespace ConnectionTemplate
{
    public enum CONNECTION_TYPE{
        TCP,
        UDP
    }
    abstract class Connection
    {
        protected CONNECTION_TYPE TYPE;
        protected int port;
        protected string ipAddress;
        protected bool isConnected;
        //private PacketBuilder *packetBuilder;

        public Connection() { }
        public Connection(CONNECTION_TYPE type){
            this.TYPE = type;
            isConnected = true;
            //packetBuilder = new PacketBuilder();
        }

        public abstract int buildPacket();
        public abstract void close();
        public static bool operator != (Connection obj1, CONNECTION_TYPE type1)
        {
            return obj1.TYPE != type1;
        }
        public static bool operator == (Connection obj1, CONNECTION_TYPE type)
        {
            return obj1 != type;
        }
    }
}