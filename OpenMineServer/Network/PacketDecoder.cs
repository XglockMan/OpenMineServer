using System.Collections.Generic;
using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;
using OpenMineServer.Network.Protocol;

namespace OpenMineServer.Network
{
    public class PacketDecoder : ByteToMessageDecoder
    {
        private PacketSide _side;
        
        public PacketDecoder(PacketSide side)
        {
            _side = side;
        }
        
        protected override void Decode(IChannelHandlerContext context, IByteBuffer input, List<object> output)
        {
            if (input.ReadableBytes != 0)
            {
                int dataLenght = input.ReadInt();
                
            }
        }
    }
}