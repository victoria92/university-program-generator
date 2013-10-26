using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Teacher
    {
        // TODO: add list of requirements (as Requirement)
        public readonly List<Subject> subjects;
        public readonly string name;

        public Teacher(List<Subject> subjects, string name)
        {
            this.subjects = subjects;
            this.name = name;
        }
    }
}
