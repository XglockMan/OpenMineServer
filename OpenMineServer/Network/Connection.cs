using System;
using DotNetty.Transport.Channels;
using OpenMineServer.Network.Protocol;
using System.Collections.Generic;

namespace OpenMineServer.Network
{
    public class Connection : SimpleChannelInboundHandler<List<object>>
    {
        
        
        protected override void ChannelRead0(IChannelHandlerContext ctx, List<object> msg)
        {
            IPacket packet = (IPacket)msg[0];
            Console.WriteLine(packet);
        }
    }
}