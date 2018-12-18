﻿using OXGaming.TibiaAPI.Constants;

namespace OXGaming.TibiaAPI.Network.ClientPackets
{
    public class BlessingsDialog : ClientPacket
    {
        public BlessingsDialog(Client client)
        {
            Client = client;
            PacketType = ClientPacketType.BlessingsDialog;
        }

        public override bool ParseFromNetworkMessage(NetworkMessage message)
        {
            if (message.ReadByte() != (byte)ClientPacketType.BlessingsDialog)
            {
                return false;
            }

            return true;
        }

        public override void AppendToNetworkMessage(NetworkMessage message)
        {
            message.Write((byte)ClientPacketType.BlessingsDialog);
        }
    }
}
