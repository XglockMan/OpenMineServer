using System.IO;
using System.IO.Compression;
using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;

namespace OpenMineServer.Network
{
    public class CompressionEncoder : MessageToByteEncoder<IByteBuffer>
    {
        private byte[] _encodeBuffer = new byte[8192];
        private int _threshold;

        public CompressionEncoder(int threshold)
        {
            _threshold = threshold;
        }
        
        protected override void Encode(IChannelHandlerContext context, IByteBuffer message, IByteBuffer output)
        {
            int readableBytes = message.ReadableBytes;
            if (readableBytes < _threshold)
            {
                output.WriteInt(0);
                output.WriteBytes(message);
            }
            else
            {
                byte[] readableBytesArray = new byte[readableBytes];
                message.ReadBytes(readableBytesArray);
                output.WriteInt(readableBytesArray.Length);
                MemoryStream memoryStream = new MemoryStream();
                using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionLevel.Optimal))
                {
                    deflateStream.Write(readableBytesArray, 0, readableBytes);
                }
                
                _encodeBuffer = memoryStream.ToArray();

                output.WriteBytes(_encodeBuffer, 0, _encodeBuffer.Length);
            }
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public void SetThreshold(int threshold)
        {
            _threshold = threshold;
        }
    }
}