using System;

namespace UniProgramGen.Helpers
{
    public class TimeSlot
    {
        public TimeSlot(DayOfWeek day, uint startHour, uint endHour)
        {
            Day = day;
            StartHour = startHour;
            EndHour = endHour;
        }

        public DayOfWeek Day { get; private set; }
        public uint StartHour { get; private set; }
        public uint EndHour { get; private set; }
    }
}

