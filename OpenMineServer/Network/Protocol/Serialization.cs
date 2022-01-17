using System;
using System.Text;
using DotNetty.Buffers;

namespace OpenMineServer.Network.Protocol
{
    public class Serialization
    {
        private IByteBuffer _buffer;

        public Serialization()
        {
            _buffer = new EmptyByteBuffer(new UnpooledByteBufferAllocator(true));
        }

        public Serialization(IByteBuffer buffer)
        {
            _buffer = buffer;
        }

        public void Write(object obj)
        {
            if (obj is string)
            {
                string data = (string)obj;
                int dataLenght = data.Length;
                _buffer.WriteInt(dataLenght);
                _buffer.WriteString(data, Encoding.UTF8);
            }
            else if (obj is int)
            {
                int data = (int)obj;
                _buffer.WriteInt(data);
            }
            else if (obj is long)
            {
                long data = (long)obj;
                _buffer.WriteLong(data);
            }
            else if (obj is bool)
            {
                bool data = (bool)obj;
                _buffer.WriteBoolean(data);
            }
            else if (obj is byte[])
            {
                byte[] data = (byte[])obj;
                _buffer.WriteInt(data.Length);
                _buffer.WriteBytes(data);
            }
            else if (obj is byte)
            {
                byte data = (byte)obj;
                _buffer.WriteByte(data);
            }
            else
            {
                throw new Exception();
            }
        }

        public object Read(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.String:
                    int stringLenght = _buffer.ReadInt();
                    return _buffer.ReadString(stringLenght, Encoding.UTF8);
                case DataType.Int:
                    return _buffer.ReadInt();
                case DataType.Long:
                    return _buffer.ReadLong();
                case DataType.Bool:
                    return _buffer.ReadBoolean();
                case DataType.ByteArray:
                    int byteLenght = _buffer.ReadInt();
                    byte[] bytes = new byte[byteLenght];
                    _buffer.ReadBytes(bytes);
                    return bytes;
                case DataType.Byte:
                    return _buffer.ReadByte();
                default:
                    throw new Exception();
            }
        }

        public IByteBuffer GetByteBuffer()
        {
            return _buffer;
        }

    }
}