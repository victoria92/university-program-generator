using System;

namespace UniProgramGen.Helpers
{
    public class TimeSlot
    {
        public const uint START_HOUR = 8;
        public const uint END_HOUR = 22;
        public const uint TOTAL_DAY_HOURS = END_HOUR - START_HOUR;

        public TimeSlot(DayOfWeek day, uint startHour, uint endHour)
        {
            validateHour(startHour);
            validateHour(endHour);
            if (startHour >= endHour)
            {
                throw new ArgumentException("Start hour has to be before end hour");
            }

            Day = day;
            StartHour = startHour;
            EndHour = endHour;
        }

        public uint Duration()
        {
            return EndHour - StartHour;
        }

        public bool Overlaps(TimeSlot other)
        {
            return other.Day == Day && (inSlot(other.StartHour) || inSlot(other.EndHour));
        }

        public bool Includes(TimeSlot other)
        {
            return other.Day == Day && other.StartHour >= StartHour && other.EndHour <= EndHour;
        }

        public DayOfWeek Day { get; private set; }
        public uint StartHour { get; private set; }
        public uint EndHour { get; private set; }

        private static void validateHour(uint hour)
        {
            if (hour < START_HOUR || hour > END_HOUR)
            {
                throw new ArgumentOutOfRangeException("Hour outside of working hours");
            }
        }

        private bool inSlot(uint hour)
        {
            return hour > StartHour && hour < EndHour;
        }


        internal TimeSlot MoveOneHour()
        {
            return new TimeSlot(Day, StartHour + 1, EndHour + 1);
        }
    }
}
