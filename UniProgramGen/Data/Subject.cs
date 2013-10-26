using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Subject
    {
        public readonly List<RoomType> roomTypes;
        public readonly List<Teacher> teachers;
        public readonly string name;
        public readonly uint duration;

        public Subject(List<RoomType> roomTypes, List<Teacher> teachers, string name, uint duration)
        {
            this.roomTypes = roomTypes;
            this.teachers = teachers;
            this.name = name;
            this.duration = duration;
        }
    }
}
