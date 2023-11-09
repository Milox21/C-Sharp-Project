﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.CraftingClasses.SegmentTypes
{
    public class ShipHead : ShipSegment
    {
        public ShipHead(string name, string description, int addedFuelUsing, int shipSlowdown, int cost) 
            : base(name, description, addedFuelUsing, shipSlowdown, cost)
        {
        }
    }
}
