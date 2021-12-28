using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DotNetty.Buffers;
using DotNetty.Common;
using DotNetty.Common.Utilities;

namespace OpenMineServer.Network
{
    public class FriendlyByteBuffer : IByteBuffer
    {
        private IByteBuffer _source;
        
        public FriendlyByteBuffer(IByteBuffer buffer)
        {
            _source = buffer;
        }

        public IReferenceCounted Retain()
        {
            return _source.Retain();
        }

        public IReferenceCounted Retain(int increment)
        {
            return _source.Retain(increment);
        }

        public IReferenceCounted Touch()
        {
            return _source.Touch();
        }

        public IReferenceCounted Touch(object hint)
        {
            return _source.Touch(hint);
        }

        public bool Release()
        {
            return _source.Release();
        }

        public bool Release(int decrement)
        {
            return _source.Release(decrement);
        }

        public int ReferenceCount { get; }
        public int CompareTo(IByteBuffer? other)
        {
            return _source.CompareTo(other);
        }

        public bool Equals(IByteBuffer? other)
        {
            return _source.Equals(other);
        }

        public IByteBuffer AdjustCapacity(int newCapacity)
        {
            return _source.AdjustCapacity(newCapacity);
        }

        public IByteBuffer SetWriterIndex(int writerIndex)
        {
            return _source.SetWriterIndex(writerIndex);
        }

        public IByteBuffer SetReaderIndex(int readerIndex)
        {
            return _source.SetReaderIndex(readerIndex);
        }

        public IByteBuffer SetIndex(int readerIndex, int writerIndex)
        {
            return _source.SetIndex(readerIndex, writerIndex);
        }

        public bool IsReadable()
        {
            return _source.IsReadable();
        }

        public bool IsReadable(int size)
        {
            return _source.IsReadable(size);
        }

        public bool IsWritable()
        {
            return _source.IsWritable();
        }

        public bool IsWritable(int size)
        {
            return _source.IsWritable(size);
        }

        public IByteBuffer Clear()
        {
            return _source.Clear();
        }

        public IByteBuffer MarkReaderIndex()
        {
            return _source.MarkReaderIndex();
        }

        public IByteBuffer ResetReaderIndex()
        {
            return _source.ResetReaderIndex();
        }

        public IByteBuffer MarkWriterIndex()
        {
            return _source.MarkWriterIndex();
        }

        public IByteBuffer ResetWriterIndex()
        {
            return _source.ResetWriterIndex();
        }

        public IByteBuffer DiscardReadBytes()
        {
            return _source.DiscardReadBytes();
        }

        public IByteBuffer DiscardSomeReadBytes()
        {
            return _source.DiscardSomeReadBytes();
        }

        public IByteBuffer EnsureWritable(int minWritableBytes)
        {
            return _source.EnsureWritable(minWritableBytes);
        }

        public int EnsureWritable(int minWritableBytes, bool force)
        {
            return _source.EnsureWritable(minWritableBytes, force);
        }

        public bool GetBoolean(int index)
        {
            return _source.GetBoolean(index);
        }

        public byte GetByte(int index)
        {
            return _source.GetByte(index);
        }

        public short GetShort(int index)
        {
            return _source.GetShort(index);
        }

        public short GetShortLE(int index)
        {
            return _source.GetShortLE(index);
        }

        public ushort GetUnsignedShort(int index)
        {
            return _source.GetUnsignedShort(index);
        }

        public ushort GetUnsignedShortLE(int index)
        {
            return _source.GetUnsignedShortLE(index);
        }

        public int GetInt(int index)
        {
            return _source.GetInt(index);
        }

        public int GetIntLE(int index)
        {
            return _source.GetIntLE(index);
        }

        public uint GetUnsignedInt(int index)
        {
            return _source.GetUnsignedInt(index);
        }

        public uint GetUnsignedIntLE(int index)
        {
            return _source.GetUnsignedIntLE(index);
        }

        public long GetLong(int index)
        {
            return _source.GetLong(index);
        }

        public long GetLongLE(int index)
        {
            return _source.GetLongLE(index);
        }

        public int GetMedium(int index)
        {
            return _source.GetMedium(index);
        }

        public int GetMediumLE(int index)
        {
            return _source.GetMediumLE(index);
        }

        public int GetUnsignedMedium(int index)
        {
            return _source.GetUnsignedMedium(index);
        }

        public int GetUnsignedMediumLE(int index)
        {
            return _source.GetUnsignedMediumLE(index);
        }

        public char GetChar(int index)
        {
            return _source.GetChar(index);
        }

        public float GetFloat(int index)
        {
            return _source.GetFloat(index);
        }

        public float GetFloatLE(int index)
        {
            return _source.GetFloatLE(index);
        }

        public double GetDouble(int index)
        {
            return _source.GetDouble(index);
        }

        public double GetDoubleLE(int index)
        {
            return _source.GetDoubleLE(index);
        }

        public IByteBuffer GetBytes(int index, IByteBuffer destination)
        {
            return _source.GetBytes(index, destination);
        }

        public IByteBuffer GetBytes(int index, IByteBuffer destination, int length)
        {
            return _source.GetBytes(index, destination, length);
        }

        public IByteBuffer GetBytes(int index, IByteBuffer destination, int dstIndex, int length)
        {
            return _source.GetBytes(index, destination, dstIndex, length);
        }

        public IByteBuffer GetBytes(int index, byte[] destination)
        {
            return _source.GetBytes(index, destination);
        }

        public IByteBuffer GetBytes(int index, byte[] destination, int dstIndex, int length)
        {
            return _source.GetBytes(index, destination, dstIndex, length);
        }

        public IByteBuffer GetBytes(int index, Stream destination, int length)
        {
            return _source.GetBytes(index, destination, length);
        }

        public ICharSequence GetCharSequence(int index, int length, Encoding encoding)
        {
            return _source.GetCharSequence(index, length, encoding);
        }

        public string GetString(int index, int length, Encoding encoding)
        {
            return _source.GetString(index, length, encoding);
        }

        public IByteBuffer SetBoolean(int index, bool value)
        {
            return _source.SetBoolean(index, value);
        }

        public IByteBuffer SetByte(int index, int value)
        {
            return _source.SetByte(index, value);
        }

        public IByteBuffer SetShort(int index, int value)
        {
            return _source.SetShort(index, value);
        }

        public IByteBuffer SetShortLE(int index, int value)
        {
            return _source.SetShortLE(index, value);
        }

        public IByteBuffer SetUnsignedShort(int index, ushort value)
        {
            return _source.SetUnsignedShort(index, value);
        }

        public IByteBuffer SetUnsignedShortLE(int index, ushort value)
        {
            return _source.SetUnsignedShortLE(index, value);
        }

        public IByteBuffer SetInt(int index, int value)
        {
            return _source.SetInt(index, value);
        }

        public IByteBuffer SetIntLE(int index, int value)
        {
            return _source.SetIntLE(index, value);
        }

        public IByteBuffer SetUnsignedInt(int index, uint value)
        {
            return _source.SetUnsignedInt(index, value);
        }

        public IByteBuffer SetUnsignedIntLE(int index, uint value)
        {
            return _source.SetUnsignedIntLE(index, value);
        }

        public IByteBuffer SetMedium(int index, int value)
        {
            return _source.SetMedium(index, value);
        }

        public IByteBuffer SetMediumLE(int index, int value)
        {
            return _source.SetMediumLE(index, value);
        }

        public IByteBuffer SetLong(int index, long value)
        {
            return _source.SetLong(index, value);
        }

        public IByteBuffer SetLongLE(int index, long value)
        {
            return _source.SetLongLE(index, value);
        }

        public IByteBuffer SetChar(int index, char value)
        {
            return _source.SetChar(index, value);
        }

        public IByteBuffer SetDouble(int index, double value)
        {
            return _source.SetDouble(index, value);
        }

        public IByteBuffer SetFloat(int index, float value)
        {
            return _source.SetFloat(index, value);
        }

        public IByteBuffer SetDoubleLE(int index, double value)
        {
            return _source.SetDoubleLE(index, value);
        }

        public IByteBuffer SetFloatLE(int index, float value)
        {
            return _source.SetFloatLE(index, value);
        }

        public IByteBuffer SetBytes(int index, IByteBuffer src)
        {
            return _source.SetBytes(index, src);
        }

        public IByteBuffer SetBytes(int index, IByteBuffer src, int length)
        {
            return _source.SetBytes(index, src, length);
        }

        public IByteBuffer SetBytes(int index, IByteBuffer src, int srcIndex, int length)
        {
            return _source.SetBytes(index, src, srcIndex, length);
        }

        public IByteBuffer SetBytes(int index, byte[] src)
        {
            return _source.SetBytes(index, src);
        }

        public IByteBuffer SetBytes(int index, byte[] src, int srcIndex, int length)
        {
            return _source.SetBytes(index, src, srcIndex, length);
        }

        public Task<int> SetBytesAsync(int index, Stream src, int length, CancellationToken cancellationToken)
        {
            return _source.SetBytesAsync(index, src, length, cancellationToken);
        }

        public IByteBuffer SetZero(int index, int length)
        {
            return _source.SetZero(index, length);
        }

        public int SetCharSequence(int index, ICharSequence sequence, Encoding encoding)
        {
            return _source.SetCharSequence(index, sequence, encoding);
        }

        public int SetString(int index, string value, Encoding encoding)
        {
            return _source.SetString(index, value, encoding);
        }

        public bool ReadBoolean()
        {
            return _source.ReadBoolean();
        }

        public byte ReadByte()
        {
            return _source.ReadByte();
        }

        public short ReadShort()
        {
            return _source.ReadShort();
        }

        public short ReadShortLE()
        {
            return _source.ReadShortLE();
        }

        public int ReadMedium()
        {
            return _source.ReadMedium();
        }

        public int ReadMediumLE()
        {
            return _source.ReadMediumLE();
        }

        public int ReadUnsignedMedium()
        {
            return _source.ReadUnsignedMedium();
        }

        public int ReadUnsignedMediumLE()
        {
            return _source.ReadUnsignedMediumLE();
        }

        public ushort ReadUnsignedShort()
        {
            return _source.ReadUnsignedShort();
        }

        public ushort ReadUnsignedShortLE()
        {
            return _source.ReadUnsignedShortLE();
        }

        public int ReadInt()
        {
            return _source.ReadInt();
        }

        public int ReadIntLE()
        {
            return _source.ReadIntLE();
        }

        public uint ReadUnsignedInt()
        {
            return _source.ReadUnsignedInt();
        }

        public uint ReadUnsignedIntLE()
        {
            return _source.ReadUnsignedIntLE();
        }

        public long ReadLong()
        {
            return _source.ReadLong();
        }

        public long ReadLongLE()
        {
            return _source.ReadLongLE();
        }

        public char ReadChar()
        {
            return _source.ReadChar();
        }

        public double ReadDouble()
        {
            return _source.ReadDouble();
        }

        public double ReadDoubleLE()
        {
            return _source.ReadDoubleLE();
        }

        public float ReadFloat()
        {
            return _source.ReadFloat();
        }

        public float ReadFloatLE()
        {
            return _source.ReadFloatLE();
        }

        public IByteBuffer ReadBytes(int length)
        {
            return _source.ReadBytes(length);
        }

        public IByteBuffer ReadBytes(IByteBuffer destination)
        {
            return _source.ReadBytes(destination);
        }

        public IByteBuffer ReadBytes(IByteBuffer destination, int length)
        {
            return _source.ReadBytes(destination, length);
        }

        public IByteBuffer ReadBytes(IByteBuffer destination, int dstIndex, int length)
        {
            return _source.ReadBytes(destination, dstIndex, length);
        }

        public IByteBuffer ReadBytes(byte[] destination)
        {
            return _source.ReadBytes(destination);
        }

        public IByteBuffer ReadBytes(byte[] destination, int dstIndex, int length)
        {
            return _source.ReadBytes(destination, dstIndex, length);
        }

        public IByteBuffer ReadBytes(Stream destination, int length)
        {
            return _source.ReadBytes(destination, length);
        }

        public ICharSequence ReadCharSequence(int length, Encoding encoding)
        {
            return _source.ReadCharSequence(length, encoding);
        }

        public string ReadString(int length, Encoding encoding)
        {
            return _source.ReadString(length, encoding);
        }

        public IByteBuffer SkipBytes(int length)
        {
            return _source.SkipBytes(length);
        }

        public IByteBuffer WriteBoolean(bool value)
        {
            return _source.WriteBoolean(value);
        }

        public IByteBuffer WriteByte(int value)
        {
            return _source.WriteByte(value);
        }

        public IByteBuffer WriteShort(int value)
        {
            return _source.WriteShort(value);
        }

        public IByteBuffer WriteShortLE(int value)
        {
            return _source.WriteShortLE(value);
        }

        public IByteBuffer WriteUnsignedShort(ushort value)
        {
            return _source.WriteUnsignedShort(value);
        }

        public IByteBuffer WriteUnsignedShortLE(ushort value)
        {
            return _source.WriteUnsignedShortLE(value);
        }

        public IByteBuffer WriteMedium(int value)
        {
            return _source.WriteMedium(value);
        }

        public IByteBuffer WriteMediumLE(int value)
        {
            return _source.WriteMediumLE(value);
        }

        public IByteBuffer WriteInt(int value)
        {
            return _source.WriteInt(value);
        }

        public IByteBuffer WriteIntLE(int value)
        {
            return _source.WriteIntLE(value);
        }

        public IByteBuffer WriteLong(long value)
        {
            return _source.WriteLong(value);
        }

        public IByteBuffer WriteLongLE(long value)
        {
            return _source.WriteLongLE(value);
        }

        public IByteBuffer WriteChar(char value)
        {
            return _source.WriteChar(value);
        }

        public IByteBuffer WriteDouble(double value)
        {
            return _source.WriteDouble(value);
        }

        public IByteBuffer WriteDoubleLE(double value)
        {
            return _source.WriteDoubleLE(value);
        }

        public IByteBuffer WriteFloat(float value)
        {
            return _source.WriteFloat(value);
        }

        public IByteBuffer WriteFloatLE(float value)
        {
            return _source.WriteFloatLE(value);
        }

        public IByteBuffer WriteBytes(IByteBuffer src)
        {
            return _source.WriteBytes(src);
        }

        public IByteBuffer WriteBytes(IByteBuffer src, int length)
        {
            return _source.WriteBytes(src, length);
        }

        public IByteBuffer WriteBytes(IByteBuffer src, int srcIndex, int length)
        {
            return _source.WriteBytes(src, srcIndex, length);
        }

        public IByteBuffer WriteBytes(byte[] src)
        {
            return _source.WriteBytes(src);
        }

        public IByteBuffer WriteBytes(byte[] src, int srcIndex, int length)
        {
            return _source.WriteBytes(src, srcIndex, length);
        }

        public ArraySegment<byte> GetIoBuffer()
        {
            return _source.GetIoBuffer();
        }

        public ArraySegment<byte> GetIoBuffer(int index, int length)
        {
            return _source.GetIoBuffer(index, length);
        }

        public ArraySegment<byte>[] GetIoBuffers()
        {
            return _source.GetIoBuffers();
        }

        public ArraySegment<byte>[] GetIoBuffers(int index, int length)
        {
            return _source.GetIoBuffers(index, length);
        }

        public ref byte GetPinnableMemoryAddress()
        {
            return ref _source.GetPinnableMemoryAddress();
        }

        public IntPtr AddressOfPinnedMemory()
        {
            return _source.AddressOfPinnedMemory();
        }

        public IByteBuffer Duplicate()
        {
            return _source.Duplicate();
        }

        public IByteBuffer RetainedDuplicate()
        {
            return _source.RetainedDuplicate();
        }

        public IByteBuffer Unwrap()
        {
            return _source.Unwrap();
        }

        public IByteBuffer Copy()
        {
            return _source.Copy();
        }

        public IByteBuffer Copy(int index, int length)
        {
            return _source.Copy(index, length);
        }

        public IByteBuffer Slice()
        {
            return _source.Slice();
        }

        public IByteBuffer RetainedSlice()
        {
            return _source.RetainedSlice();
        }

        public IByteBuffer Slice(int index, int length)
        {
            return _source.Slice(index, length);
        }

        public IByteBuffer RetainedSlice(int index, int length)
        {
            return _source.RetainedSlice(index, length);
        }

        public IByteBuffer ReadSlice(int length)
        {
            return _source.ReadSlice(length);
        }

        public IByteBuffer ReadRetainedSlice(int length)
        {
            return _source.ReadRetainedSlice(length);
        }

        public Task WriteBytesAsync(Stream stream, int length)
        {
            return _source.WriteBytesAsync(stream, length);
        }

        public Task WriteBytesAsync(Stream stream, int length, CancellationToken cancellationToken)
        {
            return _source.WriteBytesAsync(stream, length, cancellationToken);
        }

        public IByteBuffer WriteZero(int length)
        {
            return _source.WriteZero(length);
        }

        public int WriteCharSequence(ICharSequence sequence, Encoding encoding)
        {
            return _source.WriteCharSequence(sequence, encoding);
        }

        public int WriteString(string value, Encoding encoding)
        {
            return _source.WriteString(value, encoding);
        }

        public int IndexOf(int fromIndex, int toIndex, byte value)
        {
            return _source.IndexOf(fromIndex, toIndex, value);
        }

        public int BytesBefore(byte value)
        {
            return _source.BytesBefore(value);
        }

        public int BytesBefore(int length, byte value)
        {
            return _source.BytesBefore(length, value);
        }

        public int BytesBefore(int index, int length, byte value)
        {
            return _source.BytesBefore(index, length, value);
        }

        public string ToString(Encoding encoding)
        {
            return _source.ToString(encoding);
        }

        public string ToString(int index, int length, Encoding encoding)
        {
            return _source.ToString(index, length, encoding);
        }

        public int ForEachByte(IByteProcessor processor)
        {
            return _source.ForEachByte(processor);
        }

        public int ForEachByte(int index, int length, IByteProcessor processor)
        {
            return _source.ForEachByte(index, length, processor);
        }

        public int ForEachByteDesc(IByteProcessor processor)
        {
            return _source.ForEachByteDesc(processor);
        }

        public int ForEachByteDesc(int index, int length, IByteProcessor processor)
        {
            return _source.ForEachByteDesc(index, length, processor);
        }

        public int Capacity { get; }
        public int MaxCapacity { get; }
        public IByteBufferAllocator Allocator { get; }
        public bool IsDirect { get; }
        public int ReaderIndex { get; }
        public int WriterIndex { get; }
        public int ReadableBytes { get; }
        public int WritableBytes { get; }
        public int MaxWritableBytes { get; }
        public int IoBufferCount { get; }
        public bool HasArray { get; }
        public byte[] Array { get; }
        public bool HasMemoryAddress { get; }
        public int ArrayOffset { get; }
    }
}