using System;
using System.Collections.Generic;
using UniProgramGen.Data;
using Newtonsoft.Json;

namespace UniProgramGen.Data
{
    public class State
    {
        public State()
        {
        }

        public Group[] Groups { get; internal set; }
        public Room[] Rooms { get; internal set; }
        public Subject[] Subjects { get; internal set; }
        public Teacher[] Teachers { get; internal set; }

        public static State ExampleData()
        {
            State result = new State();
            result.Groups = new Group[]
            {
                new Group(new List<Subject>(), 20, "Informatics, year 1, group 2"),
                new Group(new List<Subject>(), 20, "CS, year 1, group 2"),
            };
            result.Rooms = new Room[]
            {
                new Room(new List<RoomType>(), 20, new List<Helpers.TimeSlot>(), "200"),
                new Room(new List<RoomType>(), 20, new List<Helpers.TimeSlot>(), "325"),
            };
            result.Subjects = new Subject[]
            {
                new Subject(new List<RoomType>(), new List<Teacher>(), "Programming 101", 2),
                new Subject(new List<RoomType>(), new List<Teacher>(), "Calculus 101", 2),
            };
            result.Teachers = new Teacher[]
            {
                new Teacher(null, "Birov"),
            };

            return result;
        }
    }
}
