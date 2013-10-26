using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Room
    {
        public List<RoomType> types { get; internal set; }
        public uint capacity { get; internal set; }
        public List<Helpers.TimeSlot> availability { get; internal set; }
        public string nameOrNumber { get; internal set; }

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
