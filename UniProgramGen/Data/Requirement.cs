using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Requirement
    {
        public readonly double weight;
        public readonly List<TimeSlot> availableTimeSlots;
        public readonly List<Room> availableRooms;

        public Requirement(double weight, List<TimeSlot> availableTimeSlots, List<Room> availableRooms)
        {
            this.weight = weight;
            this.availableTimeSlots = availableTimeSlots;
            this.availableRooms = availableRooms;
        }
    }
}
