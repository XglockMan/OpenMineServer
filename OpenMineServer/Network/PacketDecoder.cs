using System;
using System.Collections.Generic;
using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;
using OpenMineServer.Network.Protocol;
using OpenMineServer.Network.Protocol.Game;

namespace OpenMineServer.Network
{
    public class PacketDecoder : ByteToMessageDecoder
    {
        private static Dictionary<byte, Type> _packets;

        static PacketDecoder()
        {
            _packets = new Dictionary<byte, Type>
            {
                { 1, typeof(PacketChat) },
                { 2, typeof(PacketLogin) }
            };
        }

        protected override void Decode(IChannelHandlerContext context, IByteBuffer encodedPacket, List<object> decodedPacket)
        {
            Serialization serialization = new Serialization(encodedPacket);
            byte packetId = (byte) serialization.Read(DataType.Byte);
            IPacket packet = (IPacket)Activator.CreateInstance(_packets[packetId]);
            if (packet != null)
            {
                packet.Parse(serialization);
                decodedPacket.Add(packet);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}