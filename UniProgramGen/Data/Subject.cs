using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniProgramGen.Data
{
    public class Subject
    {
        private readonly List<RoomType> _roomTypes;
        public List<RoomType> roomTypes { get { return _roomTypes; } }

        private readonly List<Teacher> _teachers;
        public List<Teacher> teachers { get { return _teachers; } }

        private readonly string _name;
        public string name { get { return _name; } }

        private readonly uint _duration;
        public uint duration { get { return _duration; } }

        public Subject(List<RoomType> roomTypes, List<Teacher> teachers, string name, uint duration)
        {
            _roomTypes = roomTypes;
            _teachers = teachers;
            _name = name;
            _duration = duration;
        }
    }
}
