using DotNetty.Buffers;

namespace OpenMineServer.Network.Protocol.Game
{
    public class PacketChat : IPacket
    {
        public PacketType GetPacketType()
        {
            return PacketType.Game;
        }

        public byte GetID()
        {
            return 1;
        }

        private string _msg;

        public PacketChat(string msg)
        {
            _msg = msg;
        }

        public PacketChat()
        {
        }

        public void SetMessage(string value)
        {
            _msg = value;
        }

        public string GetMessage()
        {
            return _msg;
        }

        public void ToBuffer(Serialization serialization)
        {
            serialization.Write(GetID());
            serialization.Write(_msg);
        }

        public void Parse(Serialization serialization)
        {
            _msg = (string)serialization.Read(DataType.String);
        }

        public bool Sendable()
        {
            return true;
        }
    }
}