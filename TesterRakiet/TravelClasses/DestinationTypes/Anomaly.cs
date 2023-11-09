using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.TravelClasses.DestinationTypes
{
    internal class Anomaly : Destination
    {
        public string Descryption { get; set; }

        public Anomaly(string name,string descryption, double distance) : base(name,distance)
        {
            Descryption = descryption;
        }
    }
}
