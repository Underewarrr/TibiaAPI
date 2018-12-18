﻿using OXGaming.TibiaAPI.Constants;

namespace OXGaming.TibiaAPI.Network.ClientPackets
{
    public class GoNorthEast : ClientPacket
    {
        public GoNorthEast(Client client)
        {
            Client = client;
            PacketType = ClientPacketType.GoNorthEast;
        }

        public override bool ParseFromNetworkMessage(NetworkMessage message)
        {
            if (message.ReadByte() != (byte)ClientPacketType.GoNorthEast)
            {
                return false;
            }

            return true;
        }

        public override void AppendToNetworkMessage(NetworkMessage message)
        {
            message.Write((byte)ClientPacketType.GoNorthEast);
        }
    }
}
