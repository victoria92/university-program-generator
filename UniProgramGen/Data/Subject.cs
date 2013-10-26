using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Subject
    {
        public List<RoomType> roomTypes { get; internal set; }
        public List<Teacher> teachers { get; internal set; }
        public string name { get; internal set; }
        public uint duration { get; internal set; }

        public string Name
        {
            get { return name; }
        }

        public Subject(List<RoomType> roomTypes, List<Teacher> teachers, string name, uint duration)
        {
            this.roomTypes = roomTypes;
            this.teachers = teachers;
            this.name = name;
            this.duration = duration;
        }
    }
}
