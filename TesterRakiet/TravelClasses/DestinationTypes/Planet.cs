using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.TravelClasses.DestinationTypes
{
    internal class Planet : Destination
    {
        public int FuelUsageOnLanding { get; set; }
        public bool IsLandable { get; set; } // is it possible to land on it, basicly bool to check if planet is gas giant

        public Planet(string Name, double distance, int fuelUsageOnLanding, bool isLandable) : base(Name,distance)
        {
            FuelUsageOnLanding = fuelUsageOnLanding;
            IsLandable = isLandable;
        }
    }
}
