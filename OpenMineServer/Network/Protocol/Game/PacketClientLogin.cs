namespace OpenMineServer.Network.Protocol.Game
{
    public class PacketLogin : IPacket
    {
        public PacketType GetPacketType()
        {
            return PacketType.Game;
        }

        public byte GetID()
        {
            return 2;
        }

        private int _protocolVersion;
        private string _username;
        private bool _auth;
        private string _authToken;

        public PacketLogin()
        {
        }

        public int GetProtocolVersion()
        {
            return _protocolVersion;
        }

        public string GetUserName()
        {
            return _username;
        }

        public string getAuthToken()
        {
            return _authToken;
        }

        public bool usingAuth()
        {
            return _auth;
        }


        public void ToBuffer(Serialization serialization)
        {
        }

        public void Parse(Serialization serialization)
        {
            _protocolVersion = (int)serialization.Read(DataType.Int);
            _username = (string)serialization.Read(DataType.String);
            _auth = (bool)serialization.Read(DataType.Bool);
            if (_auth)
            {
                _authToken = (string)serialization.Read(DataType.String);
            }
            else
            {
                _authToken = "";
            }
        }

        public bool Sendable()
        {
            return false;
        }
    }
}