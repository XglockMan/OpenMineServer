using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;

namespace OpenMineServer.Network
{
    public class CompressionDecoder : ByteToMessageDecoder
    {
        public static int MAXIMUM_COMPRESSED_LENGTH = 2097152;
        public static int MAXIMUM_UNCOMPRESSED_LENGTH = 8388608;
        private int _threshold;
        private bool validateDecompressed;

        public CompressionDecoder(int threshold, bool validateDecompressed)
        {
            _threshold = threshold;
            this.validateDecompressed = validateDecompressed;
        }
        
        protected override void Decode(IChannelHandlerContext context, IByteBuffer input, List<object> output)
        {
            if (input.ReadableBytes != 0)
            {
                int dataLenght = input.ReadInt();
                if (dataLenght == 0)
                {
                    output.Add(input.ReadBytes(input.ReadableBytes));
                }
                else
                {
                    if (validateDecompressed)
                    {
                        if (dataLenght < _threshold)
                        {
                            throw new DecoderException("Badly compressed packet - size of " + dataLenght + " is below server threshold of " + _threshold);
                        }

                        if (dataLenght > MAXIMUM_UNCOMPRESSED_LENGTH)
                        {
                            throw new DecoderException("Badly compressed packet - size of " + dataLenght +
                                                       " is larger than protocol maximum of " +
                                                       MAXIMUM_UNCOMPRESSED_LENGTH);
                        }
                    }
                }

                byte[] readableBufferArray = new byte[input.ReadableBytes];
                input.ReadBytes(readableBufferArray);

                MemoryStream MsInput = new MemoryStream(readableBufferArray);
                MemoryStream MsOutput = new MemoryStream();

                using (DeflateStream deflateStream = new DeflateStream(MsInput, CompressionMode.Decompress))
                {
                    deflateStream.CopyTo(MsOutput);
                }

                byte[] decompressedBufferArray = MsOutput.ToArray();
                output.Add(Unpooled.WrappedBuffer(decompressedBufferArray));
            }
        }

        public void SetThreshold(int threshold, bool validateDecompressed)
        {
            _threshold = threshold;
            this.validateDecompressed = validateDecompressed;
        }
    }
}