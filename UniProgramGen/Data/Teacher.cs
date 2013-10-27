using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Teacher
    {
        public Requirements requirements { get; set; }
        public string name { get; set; }

        public Teacher(Requirements requirements, string name)
        {
            this.requirements = requirements;
            this.name = name;
        }
    }
}
