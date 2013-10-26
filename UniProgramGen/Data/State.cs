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

        public Group[] Groups { get; set; }
        public Room[] Rooms { get; set; }
        public Subject[] Subjects { get; set; }
        public Teacher[] Teachers { get; set; }

        public static State fromFile(String filepath)
        {
            String stateJson = System.IO.File.ReadAllText(filepath);
            return JsonConvert.DeserializeObject<State>(stateJson);
        }

        public void toFile(String filepath)
        {
            string stateJson = JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(filepath, stateJson);
        }

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
                new Room(new HashSet<RoomType>(), 20, new List<Helpers.TimeSlot>(), "200"),
                new Room(new HashSet<RoomType>(), 20, new List<Helpers.TimeSlot>(), "325"),
            };
            result.Subjects = new Subject[]
            {
                new Subject(new HashSet<RoomType>(), new List<Teacher>(), "Programming 101", 2),
                new Subject(new HashSet<RoomType>(), new List<Teacher>(), "Calculus 101", 2),
            };
            result.Teachers = new Teacher[]
            {
                new Teacher(null, "Birov"),
            };

            return result;
        }
    }
}
