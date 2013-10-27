﻿using Newtonsoft.Json;
using System;
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
        public IEnumerable<Group> groups;

        public ScheduledTimeSlot(Subject subject, Room room, TimeSlot timeSlot, IEnumerable<Group> groups)
        {
            this.subject = subject;
            this.room = room;
            this.timeSlot = timeSlot;
            this.groups = groups;
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

            SetSubjectsGroups(subjects, groups);

            FindSolutions(subjects);

            var solutionsWeightsList = allSolutions.Select(s =>
                new Tuple<ScheduledTimeSlot[], double>(s, GetSolutionWeight(s, groups))).ToList();

            solutionsWeightsList.Sort((solution1, solution2) =>
                Math.Sign(solution2.Item2 - solution1.Item2));

            return allSolutions.Take(10);
        }

        private double GetSolutionWeight(ScheduledTimeSlot[] solution, IEnumerable<Group> groups)
        {
            var solutionWeight = solution.Sum(s =>
                s.subject.teachers.Sum(t =>
                    (t.requirements.availableTimeSlots.Any(a => a.Includes(s.timeSlot)) ? t.requirements.weight : 0) +
                    (t.requirements.requiredRooms.Any(r => r == s.room)                 ? t.requirements.weight : 0)));

            var personalSchedule = new PersonalSchedule(solution);

            foreach (var group in groups)
            {
                var groupSchedule = personalSchedule.GetGroupProgram(group).ToList();
                groupSchedule.Sort((s1, s2) => s1.timeSlot.StartHour.CompareTo(s2.timeSlot.StartHour));
                var groupByDays = groupSchedule.GroupBy(s => s.timeSlot.Day);
                var totalGroupHoleHours = groupByDays.Sum(g => g.Zip(g.Skip(1), (s1, s2) => (int) s2.timeSlot.StartHour - s1.timeSlot.EndHour).Sum());
                if (totalGroupHoleHours > 5)
                {
                    solutionWeight -= totalGroupHoleHours / 10;
                }
            }

            return solutionWeight;
        }

        private void FindSolutions(IEnumerable<Subject> subjects)
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
                        if (currentSolution.All(s =>
                            (s.room != room && s.groups.Intersect(subject.GetGroups()).FirstOrDefault() == null) ||
                                !s.timeSlot.Overlaps(windowTimeSlot)))
                        {
                            currentSolution.AddLast(new ScheduledTimeSlot(subject, room, windowTimeSlot, subject.GetGroups()));
                            FindSolutions(subjects.Skip(1));
                            currentSolution.RemoveLast();
                        }
                    }
                }
            }
        }

        private void SetSubjectsGroups(List<Subject> subjects, List<Group> groups)
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
