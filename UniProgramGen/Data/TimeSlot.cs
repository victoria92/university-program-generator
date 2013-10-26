using System;

namespace UniProgramGen.Data
{
    public class TimeSlot
    {
        public readonly DateTime startTime;
        public readonly DateTime endTime;
        public readonly byte dayOfWeek;

        public TimeSlot(DateTime startTime, DateTime endTime, byte dayOfWeek)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.dayOfWeek = dayOfWeek;
        }
    }
}
