using System.Collections.Generic;
using UniProgramGen;

namespace UniProgramGen.Data
{
    public class Requirements
    {
        public readonly double weight;
        public readonly List<Helpers.TimeSlot> availableTimeSlots;
        public readonly List<Room> requiredRooms;

        public Requirements(double weight, List<Helpers.TimeSlot> availableTimeSlots, List<Room> requiredRooms)
        {
            this.weight = weight;
            this.availableTimeSlots = availableTimeSlots;
            this.requiredRooms = requiredRooms;
        }
    }
}
