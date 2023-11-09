using SpaceTravelEmulator.CraftingClasses;
using SpaceTravelEmulator.TravelClasses.DestinationTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.TravelClasses
{
    internal class Journey
    {
        #region Properties
        public SpaceShip Ship { get; set; }
        public Destination Destination { get; set; }
        public double Time { get; set; }
        public int NextOneForth { get; set; }

        public SolarSystem SolarSystem = new SolarSystem();

        public delegate void Delegate();
        public event Delegate? JourneyEvent;
        #endregion

        #region Events
        private void TimeTicker()
        {
            //Console.WriteLine(((Time * 0.25 * ++NextOneForth) / 60).ToString("F2") + " min / " + (Time / 60).ToString("F2") + " min");
            Console.WriteLine(TimeSpan.FromSeconds(Time * 0.25 * ++NextOneForth).ToString(@"hh\:mm\:ss") + " / " + TimeSpan.FromSeconds(Time).ToString(@"hh\:mm\:ss"));
        }
        private void OnOccurance()
        {
            Random random = new Random();
            switch (random.Next(0, 20))
            {
                case 0:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    // nothing happens
                    break;
                case 1: // reference to: Paradox games 
                    Console.WriteLine($"Event: The {Ship.Name} has encountered new Comet, stability of your crew is decreasing");
                    break;
                case 2: // reference to: "The Futurological Congress" by Stanislaw Lem
                    Console.WriteLine($"Event: The Crew of {Ship.Name} has encountered poisonus gas, making them drift in their dreams");
                    break;
                case 3: // reference to: "Fables for Robots" by Stanislaw Lem
                    Console.WriteLine($"Event: The {Ship.Name} has encountered an asteroid, with Electronic Dragon on it");
                    break;
                case 4: // reference to: "Sollaris" by Stanislaw Lem
                    Console.WriteLine($"Event: The {Ship.Name} has encountered an unexplored moon, that happens to be one living creature");
                    break;
                case 5: // reference to: Warhamer 40k universe 
                    Console.WriteLine($"Event: The Crew of {Ship.Name} has become sinfull and slothfull, the portal to Immaterium has been opened, but the crew has come to senses in last moment");
                    break;
                case 6: // reference to: "Dune" series by Frank Herbert
                    Console.WriteLine($"Event: The {Ship.Name} has encountered ship of narcotic smugglers, they had blue eyes and talked something about some worm");
                    break;
                case 7: // reference to: Warframe game 
                    Console.WriteLine(
                        $"Event: The Crew of {Ship.Name} has started to sing the shaties,\r\n " +
                        $"Sisters! Below, below\r\n" +
                        $"We're going where the winds don't blow\r\n" +
                        $"Yes, we're all bound down\r\n " +
                        $"To the deep and we'll all be\r\n" +
                        $"Sleeping in the cold below, below\r\n" +
                        $"Sleeping in the cold below\r\n");
                    break;
                case 8: // reference to: "The Expanse" series by James S.A. Corey
                    Console.WriteLine($"Event: The {Ship.Name} has encountered a friendly ship, The Rocinante, they asked about some molecule and to stay away from Eros");
                    break;
                case 9: // reference to: "Ghost in the Shell" by Shirō Masamune
                    Console.WriteLine($"Event: The {Ship.Name} has encountered a lost satelite, it was still working and present oneself as Major Motoko Kusanagi");
                    break;
                case 10: // reference to: ???
                    Console.WriteLine($"Event: #123#@!#21451 213@!#@!%$!@%! 232!#@!");
                    break;
            }
        }
        #endregion

        #region Constructor
        public Journey(SpaceShip ship)
        {
            Ship = ship;
            NextOneForth = 0;
            SetDestiny();
            Console.Clear();
            Calculate();
            Console.Clear();
            JourneyEvent += OnOccurance;
            JourneyEvent += TimeTicker;
        } 
        #endregion

        #region DestinyPickers
        public void SetDestiny()
        {
            Console.WriteLine("Pick your destination");
            Console.WriteLine("1 - Planet");
            Console.WriteLine("2 - Moon");
            Console.WriteLine("3 - Space Station");
            Console.WriteLine("4 - Other");

            switch (Console.ReadLine())
            {
                case "1":
                    Destination = PlanetPick();
                    return;
                case "2":
                    Destination = MoonPick();
                    return;
                case "3":
                    Destination = SpaceStationPick();
                    return;
                case "4":
                    Destination = AnomalyPick();
                    return;
                default:
                    Console.WriteLine("Wrong Input");
                    return;
            }
        }

        private Planet PlanetPick()
        {
            string? answer = null;
            int Counter = 1;
            foreach (Planet planet in SolarSystem.planets)
            {
                if (planet != SolarSystem.planets[2])
                {
                    Console.WriteLine($"{Counter++} - {planet.Name} {planet.DiscanceFromEarth} AU");
                }
                
            }

            while (answer == null)
            {
                answer = Console.ReadLine();
            }

            Counter = int.Parse(answer);
            if (Counter > 2)
            {
                Counter++;
            }
                
            return SolarSystem.planets[Counter - 1];
        }

        private Moon MoonPick()
        {
            string? anwser = null;
            int Counter = 1;
            foreach (Moon moon in SolarSystem.moons)
            {
                Console.WriteLine($"{Counter++} - {moon.Name} {moon.DiscanceFromEarth} AU");
            }

            while (anwser == null)
            {
                anwser = Console.ReadLine();
            }

            if (SolarSystem.moons[int.Parse(anwser) - 1].IsInhabited == Moon.Habitat.Settled)
            {
                Console.WriteLine("The moon is settled, You will be able to easly land");
            }
            else if (SolarSystem.moons[int.Parse(anwser) - 1].IsInhabited == Moon.Habitat.Inhabited)
            {
                Console.WriteLine("The moon is inhabited, there can be some problems, becouse of limited population");
            }
            else if (SolarSystem.moons[int.Parse(anwser) - 1].IsInhabited == Moon.Habitat.Unpopulated)
            {
                Console.WriteLine("The moon is unpopulated, there is no coming back");
            }
            return SolarSystem.moons[int.Parse(anwser) - 1];
        }

        private Destination SpaceStationPick()
        {
            string? anwser = null;
            int Counter = 1;

            foreach (Destination station in SolarSystem.spaceStations)
            {
                Console.WriteLine($"{Counter++} - {station.Name} {station.DiscanceFromEarth} AU");
            }

            while (anwser == null)
            {
                anwser = Console.ReadLine();
            }

            return SolarSystem.spaceStations[int.Parse(anwser) - 1];
        }

        private Anomaly AnomalyPick()
        {
            string? anwser = null;
            int Counter = 1;

            foreach (Anomaly anomaly in SolarSystem.anomalies)
            {
                Console.WriteLine($"{Counter++} - {anomaly.Name} {anomaly.DiscanceFromEarth} AU");
            }

            while (anwser == null)
            {
                anwser = Console.ReadLine();
            }

            return SolarSystem.anomalies[int.Parse(anwser) - 1];
        }
        #endregion

        #region Methods
        public void Calculate()
        {
            // 0.01 AU = 75; on better engine 
            // 0.01 AU = 100s; on normal engine 
            // 0.01 AU = 160s; on worse engine 

            double SegmentsSlowdown = 0;

            foreach (SegmentContainer segment in Ship.Segments)
            {
                SegmentsSlowdown = +segment.AddedFuelUsing;
            }
            SegmentsSlowdown = SegmentsSlowdown * Destination.DiscanceFromEarth;
            Time = (Destination.DiscanceFromEarth * Ship.Engine.ShipSlowdown) + SegmentsSlowdown;
        }
        public async Task Travel()
        {
            await Task.Delay(TimeSpan.FromSeconds(Time * 0.25));
            JourneyEvent?.Invoke();
        } 
        #endregion

    }
}
