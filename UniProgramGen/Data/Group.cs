using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Group
    {
        public List<Subject> horarium { get; set; }
        public uint size { get; set; }
        public string name { get; set; }

        public Group(List<Subject> horarium, uint size, string name)
        {
            this.horarium = horarium;
            this.size = size;
            this.name = name;
        }
    }
}
