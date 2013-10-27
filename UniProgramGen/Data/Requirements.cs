using System.Collections.Generic;
using UniProgramGen.Helpers;

namespace UniProgramGen.Data
{
    public class Requirements
    {
        public const uint TOTAL_WEEK_HOURS = 7 * TimeSlot.TOTAL_DAY_HOURS;

        public readonly double weight;
        public List<Helpers.TimeSlot> availableTimeSlots;
        public readonly List<Room> requiredRooms;

        public Requirements(double weight, List<Helpers.TimeSlot> availableTimeSlots, List<Room> requiredRooms)
        {
            this.weight = weight;
            this.availableTimeSlots = availableTimeSlots;
            this.requiredRooms = requiredRooms;
        }
    }
}
