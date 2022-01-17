using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;
using OpenMineServer.Network.Protocol;

namespace OpenMineServer.Network
{
    public class PacketEncoder : MessageToByteEncoder<IPacket>
    {
        protected override void Encode(IChannelHandlerContext context, IPacket rawPacket, IByteBuffer encodedPacket)
        {
            Serialization serialization = new Serialization(encodedPacket);
            rawPacket.ToBuffer(serialization);
        }
    }
}