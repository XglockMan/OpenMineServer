using DotNetty.Buffers;

namespace OpenMineServer.Network.Protocol.Game
{
    public class PacketOutChat : IPacket<IClientGamePacketListener>
    {
        
        public PacketOutChat()
        {
        }

        public void write(IByteBuffer buffer)
        {
        }

        public bool skippable()
        {
            return false;
        }

        public Connection getConnection()
        {
            return null;
        }
    }
}