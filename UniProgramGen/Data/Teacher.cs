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

        private readonly List<Subject> subjects;

        public Teacher(Requirements requirements, string name)
        {
            this.requirements = requirements;
            this.name = name;

            this.subjects = new List<Subject>(2);
        }

        internal void AddSubject(Subject subject)
        {
            this.subjects.Add(subject);
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return subjects;
        }
    }
}
