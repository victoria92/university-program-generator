using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Group
    {
        public List<Subject> horarium { get; internal set; }
        public uint size { get; internal set; }
        public string name { get; internal set; }

        public Group(List<Subject> horarium, uint size, string name)
        {
            this.horarium = horarium;
            this.size = size;
            this.name = name;
        }
    }
}
