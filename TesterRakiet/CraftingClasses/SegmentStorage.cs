using SpaceTravelEmulator.CraftingClasses.SegmentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.CraftingClasses
{
    public class SegmentStorage
    {
        public List<Engine> engines = new List<Engine>();
        public List<FuelSegment> fuel = new List<FuelSegment>(); 
        public List<PassengerSegment> passengers = new List<PassengerSegment>();
        public List<ShipHead> heads = new List<ShipHead>();
        public List<StorageSegment> storages = new List<StorageSegment>();

        public SegmentStorage()
        {
            engines.Add(new Engine("HydroEngine", "Engine fulled by Hydrogen, standard engine", 40, 150, 1000000));
            engines.Add(new Engine("AtomEngine", "Engine fulled by Atomic Energy, old engine developed by French, first engine to reach Mars ", 60, 290, 1500000));
            engines.Add(new Engine("DarkMatterEngine", "Engine fulled by Dark Matter, experimental engine created on Lem Station on Saturn", 40, 100, 2500000));

            fuel.Add(new FuelSegment("Small fuel tank", "small storage for fuel", 20, 15, 50000));
            fuel.Add(new FuelSegment("Medium fuel tank", "medium storage for fuel", 40, 45, 75000));
            fuel.Add(new FuelSegment("Big fuel tank", "big storage for fuel", 60, 70, 90000));

            passengers.Add(new PassengerSegment("Stockholm Design Group - Tystnad", "Budget segment for passengers of capacity 1000", 20, 10, 30000));
            passengers.Add(new PassengerSegment("Salle de la maison", "Medium segment for passengers of capacity 500", 20, 15, 40000));
            passengers.Add(new PassengerSegment("TaiwanCorp Shushi shi", "Premium segment for passengers of capacity 100", 20, 17, 70000));

            heads.Add(new ShipHead("Milliteh research head", "Basic ship head", 20, 10, 400000));
            heads.Add(new ShipHead("RusKocmoc resourcegather", "Strong ship head for landing in harsh enviroment", 30, 25, 550000));
            heads.Add(new ShipHead("Uchu atama", "Ship head for landing in athmosfere", 30, 0, 700000));

            storages.Add(new StorageSegment("Small storage", "Capacity 500 kg", 20, 30, 40000));
            storages.Add(new StorageSegment("Medium storage", "Capacity 7500 kg", 25, 50, 55000));
            storages.Add(new StorageSegment("Big storage", "Capacity 1000 kg", 30, 70, 70000));
        }
    }
}
