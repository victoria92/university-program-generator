using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniProgramGen.Data
{
    public class Teacher
    {
        // TODO: add list of requirements

        public readonly List<Room> subjects;
        public readonly string name;

        public Teacher(List<Room> subjects, string name)
        {
            this.subjects = subjects;
            this.name = name;
        }
    }
}
