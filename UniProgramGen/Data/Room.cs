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

        public override int GetHashCode()
        {
            return nameOrNumber.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Room room = obj as Room;
            if (room != null)
            {
                return room.nameOrNumber == nameOrNumber;
            }

            return base.Equals(obj);
        }
    }
}
