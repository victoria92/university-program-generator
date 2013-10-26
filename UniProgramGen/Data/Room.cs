using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniProgramGen.Data
{
    public class Room
    {
        private readonly List<RoomType> _types;
        public List<RoomType> types { get { return _types; } }

        private readonly uint _capacity;
        public uint capacity { get { return _capacity; } }

        // TODO: add availability (as TimeSlots)

        private readonly string _nameOrNumber;
        public string nameOrNumber { get { return _nameOrNumber; } }

        public Room(List<RoomType> types, uint capacity, string nameOrNumber)
        {
            _types = types;
            _capacity = capacity;
            _nameOrNumber = nameOrNumber;
        }
    }
}
