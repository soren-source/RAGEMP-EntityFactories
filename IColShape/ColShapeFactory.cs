using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace IColShape
{
    public class ColShapeFactory : Script
    {
        public ColShapeFactory()
        {
            RAGE.Entities.Colshapes.CreateEntity = netHandle => Create(netHandle);
        }

        internal ColShape Create(NetHandle netHandle)
        {
            IColShape shape = (IColShape)Activator.CreateInstance(typeof(IColShape), netHandle);
            if (shape is null)
            {
                throw new Exception("Error at EntityFactory : player is null");
            }
            return shape!;
        }

    }
}
