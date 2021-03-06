using System;
using System.Collections.Generic;
using System.Linq;

namespace UniProgramGen.Helpers
{
    public class TimeSlot
    {
        public const uint START_HOUR = 7;
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
            return other.Day == Day && ((other.StartHour >= StartHour && other.StartHour < EndHour) ||
                                        (other.EndHour   > StartHour  && other.EndHour  <= EndHour));
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

        internal IEnumerable<TimeSlot> GetAllWindows(uint duration)
        {
            for (uint i = StartHour; i <= EndHour - duration; i++)
            {
                yield return new TimeSlot(Day, i, i + duration);
            }
        }

        internal IEnumerable<TimeSlot> Remove(TimeSlot timeSlot)
        {
            if (StartHour < timeSlot.StartHour)
            {
                yield return new TimeSlot(Day, StartHour, timeSlot.StartHour);
            }

            if (EndHour > timeSlot.EndHour)
            {
                yield return new TimeSlot(Day, timeSlot.EndHour, EndHour);
            }
        }

        internal void AddAfter(TimeSlot timeSlot)
        {
            EndHour = timeSlot.EndHour;
        }

        internal void AddBefore(TimeSlot timeSlot)
        {
            StartHour = timeSlot.StartHour;
        }

        // TODO: make this list<timeslots> to a linked list
        public static void RemoveTimeSlotFromAvailability(List<TimeSlot> availability, TimeSlot timeSlot)
        {
            for (int i = 0; i < availability.Count; i++)
            {
                var availableTimeSlot = availability[i];
                if (availableTimeSlot.Includes(timeSlot))
                {
                    availability.RemoveAt(i);
                    availability.AddRange(availableTimeSlot.Remove(timeSlot));
                    break;
                }
            }
        }

        public static void AddTimeSlotToAvailability(List<TimeSlot> availability, TimeSlot timeSlot)
        {
            foreach (var availableTimeSlot in availability.Where(a => a.Day == timeSlot.Day))
            {
                if (availableTimeSlot.EndHour == timeSlot.StartHour)
                {
                    availableTimeSlot.AddAfter(timeSlot);

                    var index = availability.FindIndex(a => a.Day == timeSlot.Day && a.StartHour == availableTimeSlot.EndHour);
                    if (index != -1)
                    {
                        availableTimeSlot.AddAfter(availability[index]);
                        availability.RemoveAt(index);
                    }
                    break;
                }
                if (availableTimeSlot.StartHour == timeSlot.EndHour)
                {
                    availableTimeSlot.AddBefore(timeSlot);

                    var index = availability.FindIndex(a => a.Day == timeSlot.Day && a.EndHour == availableTimeSlot.StartHour);
                    if (index != -1)
                    {
                        availableTimeSlot.AddBefore(availability[index]);
                        availability.RemoveAt(index);
                    }
                    break;
                }
            }
        }
    }
}
