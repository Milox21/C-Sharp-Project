using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.TravelClasses.DestinationTypes
{
    internal class SpaceStation <T> : Destination
    {
        public T OrbitingObject { get; set; }
        public int CostForLanding { get; set; }

        public SpaceStation(string Name, double distance, T orbitingObject, int costForLanding) : base(Name, distance)
        {
            OrbitingObject = orbitingObject;
            CostForLanding = costForLanding;
        }
    }
}
