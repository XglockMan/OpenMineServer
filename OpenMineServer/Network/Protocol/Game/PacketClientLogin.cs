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


        public void ToBuffer(Serialization serialization)
        {
        }

        public void Parse(Serialization serialization)
        {
            _protocolVersion = (int)serialization.Read(DataType.Int);
            _username = (string)serialization.Read(DataType.String);
        }

        public bool Sendable()
        {
            return false;
        }
    }
}