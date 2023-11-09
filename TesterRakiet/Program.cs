using SpaceTravelEmulator.CraftingClasses;
using SpaceTravelEmulator.CraftingClasses.SegmentTypes;
using SpaceTravelEmulator.TravelClasses;
using SpaceTravelEmulator.TravelClasses.DestinationTypes;
using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        List<SpaceShip> Ships = new List<SpaceShip>();
        List<Journey> Journeys = new List<Journey>();

        string? reader;
        Console.WriteLine("Welcome in Space Travel Emulator");
        Console.WriteLine("Ready Ships: ");
        while (true) 
        {
            Console.WriteLine("Ready Ships: ");
            ReadyShips(Ships);
            Console.WriteLine("===========================");
            Console.WriteLine("= What do you want to do? =");
            Console.WriteLine("= 1. Create new ship      =");
            Console.WriteLine("= 2. Prepare Journey      =");
            Console.WriteLine("= 3. Start a ship         =");
            Console.WriteLine("= 4. Exit                 =");
            Console.WriteLine("===========================");
            reader = null; 
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Ships.Add(new SpaceShip());
                    Ships[Ships.Count-1].Create();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Choose Ship:");
                    ReadyShips(Ships);

                    while (reader == null)
                    {
                        reader = Console.ReadLine();
                    }

                    Journeys.Add(new Journey(Ships[int.Parse(reader)-1]));
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Choose Journey:");
                    if (Journeys.Any())
                    {
                        int i = 0;
                        foreach (Journey journey in Journeys)
                        {
                            Console.WriteLine($"{++i} - Journey of {journey.Ship.Name}");
                        }
                    }

                    while (reader == null)
                    {
                        reader = Console.ReadLine();
                    }
                    Run(Journeys[int.Parse(reader) - 1]);
                    Journeys.Remove(Journeys[int.Parse(reader) - 1]);
                    break;
                    case "4":
                        Environment.Exit(0);
                        break;
                default: 
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
    public static void Run(Journey journey)
    {
        Console.WriteLine($"The Journey from Earth to {journey.Destination.Name}");
        Console.WriteLine("Estimated time: " + TimeSpan.FromSeconds(journey.Time).ToString(@"hh\:mm\:ss"));
        Console.WriteLine("Ship Started \n");
        journey.Travel().Wait();
        Console.WriteLine("Ship traveled 0.25 of the journey \n");
        journey.Travel().Wait();
        Console.WriteLine("Ship traveled 0.5 of the journey  \n");
        journey.Travel().Wait();
        Console.WriteLine("Ship traveled 0.75 of the journey  \n");
        journey.Travel().Wait();
        Console.WriteLine("Ship came to destination  \n");
    }
    public static void ReadyShips(List<SpaceShip> Ships)
    {
        Console.WriteLine(Ships.Any() ?
            string.Join(Environment.NewLine, Ships.Select((ship, i) => $" {++i} - {ship.Name}")) 
            : "There are no ships ready");
    }
}