using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace IVehicle
{
    public class VehicleFactory : Script
    {
        public VehicleFactory()
        {
            RAGE.Entities.Vehicles.CreateEntity = netHandle => Create(netHandle);
        }

        internal Vehicle Create(NetHandle netHandle)
        {
            IVehicle vehicle = (IVehicle)Activator.CreateInstance(typeof(IVehicle), netHandle);
            if (vehicle is null)
            {
                throw new Exception("Error at EntityFactory : player is null");
            }
            return vehicle!;
        }

    }
}
