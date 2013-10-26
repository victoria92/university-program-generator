using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Teacher
    {
        public List<Requirement> requirements;
        public readonly string name;

        public Teacher(List<Requirement> requirements, string name)
        {
            this.requirements = requirements;
            this.name = name;
        }
    }
}
