using System.Net;
using DotNetty.Buffers;
using DotNetty.Codecs.Mqtt.Packets;
using DotNetty.Transport.Channels;

namespace OpenMineServer.network
{
    public class Connection : SimpleChannelInboundHandler<IByteBuffer>
    {

        private IChannel _channel;
        private EndPoint _address;

        public override void ChannelActive(IChannelHandlerContext channelHandler)
        {
            _channel = channelHandler.Channel;
            _address = _channel.RemoteAddress;
        }

        public void SendPacket(Packet packet)
        {
            _channel.WriteAndFlushAsync(packet);
        }

        protected override void ChannelRead0(IChannelHandlerContext ctx, IByteBuffer msg)
        {
            throw new System.NotImplementedException();
        }
    }
}