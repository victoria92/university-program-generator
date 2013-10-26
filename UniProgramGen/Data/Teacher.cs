using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Teacher
    {
        public Requirements requirements { get; set; }
        public string name { get; set; }

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
