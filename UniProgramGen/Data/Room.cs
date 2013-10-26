using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniProgramGen.Data
{
    public class Room
    {
        public readonly List<RoomType> types;
        public readonly uint capacity;
        // TODO: add availability (as TimeSlots)
        public readonly string nameOrNumber;

        public Room(List<RoomType> types, uint capacity, string nameOrNumber)
        {
            this.types = types;
            this.capacity = capacity;
            this.nameOrNumber = nameOrNumber;
        }
    }
}
