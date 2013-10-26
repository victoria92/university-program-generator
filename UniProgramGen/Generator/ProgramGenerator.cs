﻿using System;
using System.Collections.Generic;
using System.Linq;
using UniProgramGen.Data;
using UniProgramGen.Helpers;

namespace UniProgramGen.Generator
{
    public struct ScheduledTimeSlot
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
        private readonly LinkedList<ScheduledTimeSlot> currentSolution = new LinkedList<ScheduledTimeSlot>();
        private readonly List<ScheduledTimeSlot[]> allSolutions = new List<ScheduledTimeSlot[]>();

        private List<Room> rooms;

        public IEnumerable<ScheduledTimeSlot[]> GenerateProgram(List<Room> rooms, List<Subject> subjects, List<Teacher> teachers, List<Group> groups)
        {
            this.rooms = rooms;

            SetSubjectGroups(subjects, groups);

            TryPutSubjects(subjects);

            allSolutions.Sort((solution1, solution2) =>
                Math.Sign(SumTeacherWeights(solution2) - SumTeacherWeights(solution1)));

            return allSolutions.Take(10);
        }

        private double SumTeacherWeights(ScheduledTimeSlot[] solution)
        {
            return solution.Sum(s =>
                s.subject.teachers.Sum(t =>
                    (t.requirements.availableTimeSlots.Any(a => a.Includes(s.timeSlot)) ? t.requirements.weight : 0) +
                    (t.requirements.requiredRooms.Any(r => r == s.room)                 ? t.requirements.weight : 0)));
        }

        private void TryPutSubjects(IEnumerable<Subject> subjects)
        {
            var subject = subjects.FirstOrDefault();
            if (subject == null)
            {
                ScheduledTimeSlot[] copy = new ScheduledTimeSlot[currentSolution.Count];
                currentSolution.CopyTo(copy, 0);
                allSolutions.Add(copy);
                return;
            }

            foreach (var room in rooms.
                Where(r => r.types.IsSupersetOf(subject.roomTypes)).
                Where(r => r.capacity >= subject.attendingPeopleCount))
            {
                foreach (var windowTimeSlot in room.availability.SelectMany(a => a.GetAllWindows(subject.duration)))
                {
                    if (subject.teachers.All(t => t.requirements.weight != 1 || t.requirements.availableTimeSlots.Any(a => a.Includes(windowTimeSlot))))
                    {
                        if (currentSolution.All(s => s.room != room || !s.timeSlot.Overlaps(windowTimeSlot)))
                        {
                            currentSolution.AddLast(new ScheduledTimeSlot(subject, room, windowTimeSlot));
                            TryPutSubjects(subjects.Skip(1));
                            currentSolution.RemoveLast();
                        }
                    }
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
    }

}
