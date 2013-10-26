using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Requirements
    {
        public readonly double weight;
        public readonly List<TimeSlot> requiredTimeSlots;
        public readonly List<Room> requiredRooms;

        public Requirements(double weight, List<TimeSlot> requiredTimeSlots, List<Room> requiredRooms)
        {
            this.weight = weight;
            this.requiredTimeSlots = requiredTimeSlots;
            this.requiredRooms = requiredRooms;
        }
    }
}
