using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Group
    {
        public readonly List<Room> horarium;
        public readonly uint size;
        public readonly string name;

        public Group(List<Room> horarium, uint size, string name)
        {
            this.horarium = horarium;
            this.size = size;
            this.name = name;
        }
    }
}
