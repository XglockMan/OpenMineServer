using System;

namespace OpenMineServer.Network.Protocol
{
    public class ProtocolPacket : Attribute
    {
        private byte _packetid;

        public ProtocolPacket(byte id)
        {
            _packetid = id;
        }

        public byte Packetid => _packetid;
    }
}