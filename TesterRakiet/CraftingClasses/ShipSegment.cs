using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.CraftingClasses
{
    public class ShipSegment
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AddedFuelUsing { get; set; } //How much the ship will be using more fuel becouse of this segment
        public int ShipSlowdown { get; set; } // How much the ship will be slown down by this segment
        public int Cost { get; set; }

        public ShipSegment(string name, string description, int addedFuelUsing, int shipSlowdown, int cost)
        {
            Name = name;
            Description = description;
            AddedFuelUsing = addedFuelUsing;
            ShipSlowdown = shipSlowdown;
            Cost = cost;
        }
    }
}
