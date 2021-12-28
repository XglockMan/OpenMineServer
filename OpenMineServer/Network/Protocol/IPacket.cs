using DotNetty.Buffers;

namespace OpenMineServer.Network.Protocol
{
    public interface IPacket<T> where T : IPacketListener
    {
        void write(IByteBuffer buffer);
        bool skippable();
    }
}