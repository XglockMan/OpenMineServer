using System;
using System.Collections.Generic;
using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;
using OpenMineServer.Network.Protocol;
using OpenMineServer.Network.Protocol.Game;

namespace OpenMineServer.Network
{
    public class PacketDecoder : MessageToByteEncoder<IPacket>
    {
        private static Dictionary<byte, Type> _packets;

        static PacketDecoder()
        {
            _packets = new Dictionary<byte, Type>
            {
                { (int)1, typeof(PacketOutChat) }
            };
        }
        
        protected override void Encode(IChannelHandlerContext context, IPacket message, IByteBuffer output)
        {
            throw new System.NotImplementedException();
        }
    }
}