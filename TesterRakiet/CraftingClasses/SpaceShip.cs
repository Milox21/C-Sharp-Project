using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using SpaceTravelEmulator.CraftingClasses.SegmentTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.CraftingClasses
{
    internal class SpaceShip 
    {
        #region Properties and Lists
        public string? Name { get; set; }
        public ShipHead? Head { get; set; }
        public Engine? Engine { get; set; }

        public List<SegmentContainer> Segments = new List<SegmentContainer>();
        public SegmentStorage storage = new SegmentStorage();
        #endregion

        #region DefactoConstructor
        public void Create()
        {
            Console.WriteLine("How will you name your ship?");
            Name = InstructionInputer();

            Console.Clear();
            Head = HeadChooser();
            Console.Clear();
            Segments.Add(SegmentChooser());
            Console.Clear();
            Segments.Add(SegmentChooser());
            Console.Clear();
            Segments.Add(SegmentChooser());
            Console.Clear();
            Engine = EngineChooser();
            Console.Clear();
        }
        #endregion

        #region SegmentChoosers
        public ShipHead HeadChooser()
        {
            int Counter = 0;
            Console.WriteLine("Choose  Head");
            foreach (ShipHead segment in storage.heads)
            {
                Console.WriteLine($"{1 + Counter++} - '{segment.Name}' {segment.Description}");
            }
            return storage.heads[int.Parse(InstructionInputer()) - 1];
        }

        public SegmentContainer SegmentChooser()
        {

            Console.WriteLine("What type should be next segment");
            Console.WriteLine("1 - Passenger Segment");
            Console.WriteLine("2 - Fuel Segment");
            Console.WriteLine("3 - Storage Segment");
            int Counter;

            while (true)
            {
                Counter = 0;
                switch (InstructionInputer())
                {
                    case "1":
                        Console.WriteLine("Choose Passenger Segment");

                        foreach (PassengerSegment segment in storage.passengers)
                        {
                            Console.WriteLine($"{1 + Counter++} - '{segment.Name}' - {segment.Description}");
                        }

                        return new ShipComponent<PassengerSegment>(Segments.Count() + 1, storage.passengers[int.Parse(InstructionInputer()) - 1]);

                    case "2":
                        Console.WriteLine("Choose Fuel Segment");
                        foreach (FuelSegment segment in storage.fuel)
                        {
                            Console.WriteLine($"{1 + Counter++}  - '{segment.Name}' - {segment.Description}");
                        }

                        return new ShipComponent<FuelSegment>(Segments.Count() + 1, storage.fuel[int.Parse(InstructionInputer()) - 1]);

                    case "3":
                        Console.WriteLine("Choose Storage Segment");
                        foreach (StorageSegment segment in storage.storages)
                        {
                            Console.WriteLine($"{1 + Counter++} - '{segment.Name}' - {segment.Description}");
                        }
                        return new ShipComponent<StorageSegment>(Segments.Count() + 1, storage.storages[int.Parse(InstructionInputer()) - 1]);

                    default:
                        break;
                }
            }
        }

        public Engine EngineChooser()
        {
            int Counter = 0;
            Console.WriteLine("Choose Engine");
            foreach (Engine segment in storage.engines)
            {
                Console.WriteLine($"{1 + Counter++}  - '{segment.Name}' - {segment.Description}");
            }
            return storage.engines[int.Parse(InstructionInputer()) - 1];
        }
        #endregion

        #region Methods
        public string InstructionInputer()
        {

            string? textFromUser = null;
            while (textFromUser == null)
            {
                textFromUser = Console.ReadLine();
            }
            return textFromUser;
        } 
        #endregion
    }
}
  