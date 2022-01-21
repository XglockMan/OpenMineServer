using System;
using System.Collections.Generic;
using System.Reflection;
using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;
using OpenMineServer.Network.Protocol;

namespace OpenMineServer.Network
{
    public class PacketDecoder : ByteToMessageDecoder
    {
        private static IDictionary<byte, Type> _packets;

        static PacketDecoder()
        {
            foreach (Type classType in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (classType.Namespace != null && classType.Namespace.Equals("OpenMineServer.Network.Protocol.Game"))
                {
                    foreach (object attribute in classType.GetCustomAttributes())
                    {
                        if (attribute is ProtocolPacket)
                        {
                            ProtocolPacket packet = (ProtocolPacket)attribute;
                            _packets.Add(packet.Packetid, classType);
                        }
                    }
                }
            }
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