using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniProgramGen.Data
{
    public class Teacher
    {
        // TODO: add list of requirements

        private readonly List<Room> _subjects;
        public List<Room> subjects { get { return _subjects; } }

        private readonly string _name;
        public string name { get { return _name; } }

        public Teacher(List<Room> subjects, string name)
        {
            _subjects = subjects;
            _name = name;
        }
    }
}
