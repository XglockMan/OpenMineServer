using System;
using DotNetty.Codecs.Mqtt.Packets;
using DotNetty.Transport.Channels;

namespace OpenMineNetworkLib
{
    public class Connection : SimpleChannelInboundHandler<Packet>
    {
        protected override void ChannelRead0(IChannelHandlerContext ctx, Packet msg)
        {
            throw new NotImplementedException();
        }
    }
}