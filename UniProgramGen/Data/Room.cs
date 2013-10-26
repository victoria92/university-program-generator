using System;
using System.Collections.Generic;
using UniProgramGen.Helpers;

namespace UniProgramGen.Data
{
    public class Room
    {
        public readonly List<RoomType> types;
        public readonly uint capacity;
        public readonly List<Pair<DateTime, DateTime>> availability;
        public readonly string nameOrNumber;

        public Room(List<RoomType> types, uint capacity,
            List<Pair<DateTime, DateTime>> availability, string nameOrNumber)
        {
            this.types = types;
            this.capacity = capacity;
            this.availability = availability;
            this.nameOrNumber = nameOrNumber;
        }
    }
}
