using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Requirements
    {
        public readonly double weight;
        public readonly List<TimeSlot> availableTimeSlots;
        public readonly List<Room> requiredRooms;

        public Requirements(double weight, List<TimeSlot> availableTimeSlots, List<Room> requiredRooms)
        {
            this.weight = weight;
            this.availableTimeSlots = availableTimeSlots;
            this.requiredRooms = requiredRooms;
        }
    }
}
