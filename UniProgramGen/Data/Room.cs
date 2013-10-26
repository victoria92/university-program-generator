using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Room
    {
        public readonly List<RoomType> types;
        public readonly uint capacity;
        public readonly List<Helpers.TimeSlot> availability;
        public readonly string nameOrNumber;

        public Room(List<RoomType> types, uint capacity,
            List<Helpers.TimeSlot> availability, string nameOrNumber)
        {
            this.types = types;
            this.capacity = capacity;
            this.availability = availability;
            this.nameOrNumber = nameOrNumber;
        }
    }
}
