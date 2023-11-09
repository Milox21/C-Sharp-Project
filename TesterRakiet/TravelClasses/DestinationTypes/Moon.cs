using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.TravelClasses.DestinationTypes
{
    internal class Moon : Destination
    {
        public enum Habitat
        {
            Settled,
            Inhabited,
            Unpopulated
        }
        public Planet OrbitingPlanet { get; set; }
        public bool HasAtmosphere { get; set; }
        public Habitat IsInhabited { get; set; }

        public Moon(string Name,Planet orbitingPlanet, double distance, bool hasAtmosphere, Habitat isInhabited) : base(Name,distance)
        {
            OrbitingPlanet = orbitingPlanet;
            HasAtmosphere = hasAtmosphere;
            IsInhabited = isInhabited;
        }
    }
}
