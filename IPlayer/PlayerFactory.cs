using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPlayer
{
    public class PlayerFactory : Script
    {
        public PlayerFactory()
        {
            RAGE.Entities.Players.CreateEntity = netHandle => Create(netHandle);
        }

        internal Player Create(NetHandle netHandle)
        {
            IPlayer player = (IPlayer)Activator.CreateInstance(typeof(IPlayer), netHandle);
            if (player is null)
            {
                throw new Exception("Error at EntityFactory : player is null");
            }
            return player!;
        }

    }
}
