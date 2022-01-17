using DotNetty.Buffers;

namespace OpenMineServer.Network.Protocol
{
    public interface IPacket
    {
        PacketType GetPacketType();

        byte GetID();

        void ToBuffer(Serialization serialization);

        void Parse(Serialization serialization);

        bool Sendable();
    }
}