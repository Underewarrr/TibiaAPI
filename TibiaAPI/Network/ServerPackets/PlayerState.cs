﻿using OXGaming.TibiaAPI.Constants;

namespace OXGaming.TibiaAPI.Network.ServerPackets
{
    public class PlayerState : ServerPacket
    {
        public uint State { get; set; }

        public PlayerState(Client client)
        {
            Client = client;
            PacketType = ServerPacketType.PlayerState;
        }

        public override bool ParseFromNetworkMessage(NetworkMessage message)
        {
            if (message.ReadByte() != (byte)ServerPacketType.PlayerState)
            {
                return false;
            }

            State = message.ReadUInt32();
            return true;
        }

        public override void AppendToNetworkMessage(NetworkMessage message)
        {
            message.Write((byte)ServerPacketType.PlayerState);
            message.Write(State);
        }
    }
}
