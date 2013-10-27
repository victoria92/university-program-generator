using System.Collections.Generic;

namespace UniProgramGen.Data
{
    public class Subject
    {
        public HashSet<RoomType> roomTypes { get; set; }
        public List<Teacher> teachers { get; set; }
        public string name { get; set; }
        public uint duration { get; set; }

        private readonly HashSet<Group> groups;
        internal uint attendingPeopleCount;

        public Subject(HashSet<RoomType> roomTypes, List<Teacher> teachers, string name, uint duration)
        {
            this.roomTypes = roomTypes;
            this.teachers = teachers;
            this.name = name;
            this.duration = duration;
            this.groups = new HashSet<Group>();
            this.attendingPeopleCount = 0;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public HashSet<Group> GetGroups()
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
