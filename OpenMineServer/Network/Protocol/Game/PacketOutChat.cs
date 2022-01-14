using System.Text;
using DotNetty.Buffers;

namespace OpenMineServer.Network.Protocol.Game
{
    public class PacketOutChat : IPacket
    {
        public PacketType GetPacketType()
        {
            return PacketType.Game;
        }

        public byte GetID()
        {
            return 1;
        }
        
        public string msg;

        public PacketOutChat(string msg)
        {
            this.msg = msg;
        }
        
        public void ToBuffer(IByteBuffer outputBuffer)
        {
            outputBuffer.WriteByte(GetID());
            outputBuffer.WriteInt(msg.Length);
            outputBuffer.WriteString(msg, Encoding.UTF8);
        }

        public void Parse(IByteBuffer buffer)
        {
            int size = buffer.ReadInt();
            msg = buffer.ReadString(size, Encoding.UTF8);
        }
    }
}