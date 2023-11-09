using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.TravelClasses.DestinationTypes
{
    internal class Destination
    {
        public string Name { get; set; }
        public double DiscanceFromEarth { get; set; }

        public Destination(string name, double discanceFromEarth)
        {
            Name = name;
            DiscanceFromEarth = discanceFromEarth;
        }
    }
}
