using OpenMineServer.Network.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMineServer.Network
{
    internal interface IPacketHandler
    {
        void handle(IPacket packet);

    }
}
