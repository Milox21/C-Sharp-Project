using SpaceTravelEmulator.CraftingClasses.SegmentTypes;
using SpaceTravelEmulator.TravelClasses.DestinationTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.TravelClasses
{
    internal class SolarSystem
    {
        public List<Anomaly> anomalies = new List<Anomaly>();
        public List<Moon> moons = new List<Moon>();
        public List<Planet> planets = new List<Planet>();
        public List<Destination> spaceStations = new List<Destination>();

        public SolarSystem() 
        {
            planets.Add(new Planet("Mercury", 0.39, 25, true));
            planets.Add(new Planet("Venus", 0.72, 25, true));
            planets.Add(new Planet("Earth", 0, 25, true));
            planets.Add(new Planet("Mars", 1.52, 25, true));
            planets.Add(new Planet("Jupiter", 5.20, 25, false));
            planets.Add(new Planet("Saturn", 9.58, 25, false));
            planets.Add(new Planet("Uranus", 19.18, 25, true));
            planets.Add(new Planet("Neptune", 30.07, 25, true));

            moons.Add(new Moon("Korovay", planets[0], 0.39, false, Moon.Habitat.Settled)); //artificial moon
            moons.Add(new Moon("Luna", planets[2], 0, false, Moon.Habitat.Settled));

            moons.Add(new Moon("Fobos", planets[3], 0.5, false, Moon.Habitat.Unpopulated));
            moons.Add(new Moon("Deimos", planets[3], 0.5, false, Moon.Habitat.Unpopulated));

            moons.Add(new Moon("Kallisto", planets[4], 4.19, false, Moon.Habitat.Settled));
            moons.Add(new Moon("Io", planets[4], 4.22, true, Moon.Habitat.Settled));
            moons.Add(new Moon("Ganimedes", planets[4], 4.67, false, Moon.Habitat.Inhabited));
            moons.Add(new Moon("Europa", planets[4], 5.20, true, Moon.Habitat.Settled));

            moons.Add(new Moon("Tytan", planets[5], 8.02, true, Moon.Habitat.Settled));
            moons.Add(new Moon("Japet", planets[5], 8.50, false, Moon.Habitat.Unpopulated));
            moons.Add(new Moon("Rhea", planets[5], 8.50, true, Moon.Habitat.Inhabited));
            moons.Add(new Moon("Tetyda", planets[5], 8.50, false, Moon.Habitat.Unpopulated));

            moons.Add(new Moon("Miranda", planets[6], 18.2, false, Moon.Habitat.Unpopulated));
            moons.Add(new Moon("Ariel", planets[6], 18.8, true, Moon.Habitat.Unpopulated));
            moons.Add(new Moon("Tytania", planets[6], 18.5, true, Moon.Habitat.Unpopulated));

            moons.Add(new Moon("Triton", planets[7], 29, true, Moon.Habitat.Unpopulated));
            moons.Add(new Moon("Proteus", planets[7], 28.8, false, Moon.Habitat.Unpopulated));

            spaceStations.Add(new SpaceStation<Planet>("Lem Station", planets[5].DiscanceFromEarth, planets[5], 10000));
            spaceStations.Add(new SpaceStation<Moon>("Reh Station", moons[0].DiscanceFromEarth, moons[0], 25000));
            spaceStations.Add(new SpaceStation<Planet>("Eknaya Station", planets[7].DiscanceFromEarth, planets[5], 80000));

            anomalies.Add(new Anomaly("Dyson Sphere", "Giaiant structure producing energy around Sol", 1));
            anomalies.Add(new Anomaly("Jupiter Orbital Ring", "Mining Ring to acquaire gases from Jupiter", 5.20));
            anomalies.Add(new Anomaly("Quantum Catapult building site", "Building site of space megastructure capable of shooting a ship out of Solar Sistem", 35));
        }
    }
}
