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

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var teacher = obj as Teacher;
            if (teacher != null)
            {
                return teacher.name == name;
            }

            return base.Equals(obj);
        }
    }
}
