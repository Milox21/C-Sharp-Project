using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTravelEmulator.CraftingClasses
{
    internal class ShipComponent<T> : SegmentContainer where T : ShipSegment
    {
        public int PlaceInRocket { get; set; }
        public T Segment { get; set; }

        public ShipComponent(int index, T segment) 
        {
            PlaceInRocket = index;
            Segment = segment;
            AddedFuelUsing = segment.AddedFuelUsing;
        }

        public int GetSpeed()
        {
            return Segment.ShipSlowdown;
        }
    }
}
