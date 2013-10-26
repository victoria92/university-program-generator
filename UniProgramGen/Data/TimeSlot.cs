using System;

namespace UniProgramGen.Data
{
    public class TimeSlot
    {
        public readonly DateTime startTime;
        public readonly DateTime endTime;

        public TimeSlot(DateTime startTime, DateTime endTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}
