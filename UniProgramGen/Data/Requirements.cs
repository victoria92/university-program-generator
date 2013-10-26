using System.Collections.Generic;
using UniProgramGen;
using System.Linq;

namespace UniProgramGen.Data
{
    public class Requirements
    {
        public const uint TOTAL_HOURS = 15;
        public const uint TOTAL_WEEK_HOURS = 5 * TOTAL_HOURS;

        public readonly double weight;
        public readonly List<Helpers.TimeSlot> availableTimeSlots;
        public readonly List<Room> requiredRooms;

        private double internalWeight;

        public Requirements(double weight, List<Helpers.TimeSlot> availableTimeSlots, List<Room> requiredRooms)
        {
            this.weight = weight;
            this.availableTimeSlots = availableTimeSlots;
            this.requiredRooms = requiredRooms;
        }

        internal void CalculateInternalWeight(int roomsLength)
        {
            var availableTime = availableTimeSlots.Aggregate((uint) 0, (total, timeSlot) => total + timeSlot.EndHour - timeSlot.StartHour);
            internalWeight = ((availableTime / TOTAL_WEEK_HOURS) + (requiredRooms.Count / roomsLength)) / 2;
        }
    }
}
