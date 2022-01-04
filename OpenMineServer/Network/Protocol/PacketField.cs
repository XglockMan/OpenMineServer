using System;

namespace OpenMineServer.Network.Protocol
{
    public class PacketField : Attribute
    {

        public int Order;

        public PacketField(int order)
        {
            Order = order;
        }

    }
}