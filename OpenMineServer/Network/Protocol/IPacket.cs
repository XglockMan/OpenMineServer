using DotNetty.Buffers;

namespace OpenMineServer.Network.Protocol
{
    public interface IPacket
    {
        PacketType GetPacketType();

        byte GetID();

        void ToBuffer(IByteBuffer outputBuffer);

        void Parse(IByteBuffer buffer);

    }
}