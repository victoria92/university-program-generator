using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniProgramGen.Data;
using UniProgramGen.Generator;

namespace UniProgramGen.Helpers
{
    public class PersonalSchedule
    {
        public PersonalSchedule(ScheduledTimeSlot[] schedule)
        {
            Schedule = schedule;
        }

        private ScheduledTimeSlot[] Schedule { get; set; }

        public IEnumerable<ScheduledTimeSlot> GetTeacherProgram(Teacher teacher)
        {
            return Schedule.Where(s => s.subject.teachers.Contains(teacher));
        }

        public IEnumerable<ScheduledTimeSlot> GetGroupProgram(Group group)
        {
            return Schedule.Where(s => s.groups.Contains(group));
        }

        public IEnumerable<ScheduledTimeSlot> GetRoomProgram(Room room)
        {
            return Schedule.Where(s => s.room == room);
        }
    }
}
