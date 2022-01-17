using DotNetty.Transport.Channels;
using OpenMineServer.Network.Protocol;
using System.Collections.Generic;

namespace OpenMineServer.Network
{
    public class Connection : SimpleChannelInboundHandler<IPacket>
    {

        protected override void ChannelRead0(IChannelHandlerContext ctx, IPacket msg)
        {
            return;
        }
    }
}