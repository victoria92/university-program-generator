using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Room
    {
        public HashSet<RoomType> types { get; set; }
        public uint capacity { get; set; }
        public List<Helpers.TimeSlot> availability { get; set; }
        public string nameOrNumber { get; set; }

        public Room(HashSet<RoomType> types, uint capacity,
            List<Helpers.TimeSlot> availability, string nameOrNumber)
        {
            this.types = types;
            this.capacity = capacity;
            this.availability = availability;
            this.nameOrNumber = nameOrNumber;
        }
    }
}
