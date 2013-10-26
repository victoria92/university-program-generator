using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Subject
    {
        public HashSet<RoomType> roomTypes { get; internal set; }
        public List<Teacher> teachers { get; internal set; }
        public string name { get; internal set; }
        public uint duration { get; internal set; }

        public string Name
        {
            get { return name; }
        }

        private readonly List<Group> groups;
        internal uint attendingPeopleCount;

        public Subject(HashSet<RoomType> roomTypes, List<Teacher> teachers, string name, uint duration)
        {
            this.roomTypes = roomTypes;
            this.teachers = teachers;
            this.name = name;
            this.duration = duration;
            this.groups = new List<Group>();
            this.attendingPeopleCount = 0;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public IEnumerable<Group> GetGroups()
        {
            return groups;
        }

        internal void AddGroup(Group group)
        {
            groups.Add(group);
            attendingPeopleCount += group.size;
        }
    }
}
