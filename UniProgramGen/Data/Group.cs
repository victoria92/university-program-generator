using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Group
    {
        private readonly List<Room> _horarium;
        public List<Room> horarium { get { return _horarium; } }

        private readonly uint _size;
        public uint size { get { return _size; } }

        private readonly string _name;
        public string name { get { return _name; } }

        public Group(List<Room> horarium, uint size, string name)
        {
            _horarium = horarium;
            _size = size;
            _name = name;
        }
    }
}
