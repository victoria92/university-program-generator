using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Teacher
    {
        public Requirements requirements;
        public readonly string name;

        public Teacher(Requirements requirements, string name)
        {
            this.requirements = requirements;
            this.name = name;
        }
    }
}
