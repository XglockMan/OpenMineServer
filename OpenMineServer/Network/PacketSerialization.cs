using System;
using DotNetty.Buffers;
using OpenMineServer.Network.Protocol;

namespace OpenMineServer.Network
{
    public class PacketSerialization
    {
        private char _stx = '$';
        private char _etx = '%';

        private char _headSplit = '#';
        private char _headValue = '&';
        
        private IByteBuffer _head;
        private IByteBuffer _payload;

        public PacketSerialization()
        {
            _head = new EmptyByteBuffer(new UnpooledByteBufferAllocator(true));
            _payload = new EmptyByteBuffer(new UnpooledByteBufferAllocator(true));
        }

        public void Serializate(IPacket packet)
        {
        }

        private void WriteHeader(int packetid, object[] data)
        {
            _head.WriteChar(_stx);
            _head.WriteByte((byte)ProtocolDataType.PacketId);
            _head.WriteChar(_headValue);
            _head.WriteInt(packetid);
            _head.WriteChar(_headSplit);
            foreach (object field in data)
            {
                if (field is int)
                {
                    _head.WriteByte((byte)ProtocolDataType.Int);
                }
                else if (field is long)
                {
                    _head.WriteByte((byte)ProtocolDataType.Long);
                }
                else if (field is bool)
                {
                    _head.WriteByte((byte)ProtocolDataType.Boolean);
                }
                else if (field is string)
                {
                    _head.WriteByte((byte)ProtocolDataType.String);
                }

                _head.WriteChar(_headValue);
                _head.WriteInt(0);
                _head.WriteChar(_headSplit);
            }

            _head.WriteChar(_etx);
        }
    }
}