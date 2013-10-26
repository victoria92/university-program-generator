using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Teacher
    {
        public Requirements requirements { get; internal set; }
        public string name { get; internal set; }

        public string Name
        {
            get { return name; }
        }

        public Teacher(Requirements requirements, string name)
        {
            this.requirements = requirements;
            this.name = name;
        }
    }
}
