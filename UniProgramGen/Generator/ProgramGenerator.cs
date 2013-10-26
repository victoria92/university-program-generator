using System;
using System.Collections.Generic;
using System.Linq;
using UniProgramGen.Data;
using UniProgramGen.Helpers;

namespace UniProgramGen.Generator
{
    struct ScheduledTimeSlot
    {
        public Subject subject;
        public Room room;
        public TimeSlot timeSlot;

        public ScheduledTimeSlot(Subject subject, Room room, TimeSlot timeSlot)
        {
            this.subject = subject;
            this.room = room;
            this.timeSlot = timeSlot;
        }
    }

    public class ProgramGenerator
    {
        private readonly List<ScheduledTimeSlot> currentSolution = new List<ScheduledTimeSlot>();
        private readonly List<List<ScheduledTimeSlot>> allSolutions = new List<List<ScheduledTimeSlot>>();

        private List<Room> rooms;

        public void GenerateProgram(List<Room> rooms, List<Subject> subjects, List<Teacher> teachers, List<Group> groups)
        {
            this.rooms = rooms;

            CalculateRequirementInternalWeights(rooms.Count, teachers.Select(t => t.requirements));

            // SortTeachersByWeight(teachers);
            // SortSubjectTeachersByWeight(subjects);

            // SetTeacherSubjects(teachers, subjects);
            SetSubjectGroups(subjects, groups);

            TryPutSubjects(subjects);
        }

        private void TryPutSubjects(IEnumerable<Subject> subjects)
        {
            if (subjects.Count() == 0)
            {
                // TODO: we have solution
                return;
            }

            var subject = subjects.First();
            foreach (var room in rooms.
                Where(r => r.types.IsSupersetOf(subject.roomTypes)).
                Where(r => r.capacity >= subject.attendingPeopleCount))
            {
                foreach (var timeSlot in room.availability.Where(t => t.Duration() >= subject.duration))
	            {
                    foreach (var windowTimeSlot in timeSlot.GetAllWindows(subject.duration))
                    {
                        if (currentSolution.All(s => s.room != room || !s.timeSlot.Overlaps(windowTimeSlot)))
                        {
                            currentSolution.Add(new ScheduledTimeSlot(subject, room, windowTimeSlot));
                            TryPutSubjects(subjects.Skip(1));
                            currentSolution.RemoveAt(currentSolution.Count - 1);
                        }
                    }
	            }
            }
        }

        private void SortSubjectTeachersByWeight(List<Subject> subjects)
        {
            foreach (var subject in subjects)
            {
                SortTeachersByWeight(subject.teachers);
            }
        }

        private void SetTeacherSubjects(List<Teacher> teachers, List<Subject> subjects)
        {
            var hash = new Dictionary<string, Teacher>(teachers.Count);

            foreach (var teacher in teachers)
            {
                hash[teacher.name] = teacher;
            }

            foreach (var subject in subjects)
            {
                foreach (var teacher in subject.teachers)
                {
                    hash[teacher.name].AddSubject(subject);
                }
            }
        }

        private void SetSubjectGroups(List<Subject> subjects, List<Group> groups)
        {
            var hash = new Dictionary<string, Subject>(subjects.Count);

            foreach (var subject in subjects)
            {
                hash[subject.name] = subject;
            }

            foreach (var group in groups)
            {
                foreach (var subject in group.horarium)
                {
                    hash[subject.name].AddGroup(group);
                }
            }
        }

        private void SortTeachersByWeight(List<Teacher> teachers)
        {
            teachers.Sort((teacher1, teacher2) =>
                {
                    var res = teacher1.requirements.weight - teacher2.requirements.weight;
                    return Math.Sign(res != 0 ? res :
                        teacher1.requirements.internalWeight - teacher2.requirements.internalWeight);
                });
        }

        private void CalculateRequirementInternalWeights(int roomsLength, IEnumerable<Requirements> requirements)
        {
            foreach (var requirement in requirements)
            {
                requirement.CalculateInternalWeight(roomsLength);
            }
        }
    }

}
