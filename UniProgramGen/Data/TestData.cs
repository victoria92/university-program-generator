using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniProgramGen.Generator;

namespace UniProgramGen.Data
{
    public class DBManager
    {
        // rooms, subjects, teachers, groups
        public List<Room> rooms;
        public List<Subject> subjects;
        public List<Teacher> teachers;
        public List<Group> groups;

        public IEnumerable<ScheduledTimeSlot[]> solutions;

        public void getTestData()
        {
            rooms = new List<Room>();

            var roomType1 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Computer);
            var availabilityRoom1 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom1.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom1.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom1.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom1.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom1.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 24, availabilityRoom1, "321"));

            var roomType2 = new HashSet<RoomType>();
            roomType2.Add(RoomType.Computer);
            var availabilityRoom2 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType2, 20, availabilityRoom2, "306"));

            var roomType3 = new HashSet<RoomType>();
            roomType3.Add(RoomType.Computer);
            var availabilityRoom3 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType3, 22, availabilityRoom3, "120"));

            var roomType4 = new HashSet<RoomType>();
            roomType4.Add(RoomType.Computer);
            var availabilityRoom4 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom4.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom4.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom4.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom4.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom4.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType4, 20, availabilityRoom4, "314"));

            var roomType5 = new HashSet<RoomType>();
            roomType5.Add(RoomType.Computer);
            var availabilityRoom5 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom5.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom5.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom5.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom5.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom5.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType5, 20, availabilityRoom5, "019"));

            var roomType6 = new HashSet<RoomType>();
            roomType6.Add(RoomType.Lecture);
            var availabilityRoom6 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom6.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom6.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom6.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom6.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom6.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType6, 100, availabilityRoom6, "229"));

            var roomType7 = new HashSet<RoomType>();
            roomType7.Add(RoomType.Lecture);
            var availabilityRoom7 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom7.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom7.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom7.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom7.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom7.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType7, 24, availabilityRoom7, "03"));

            var roomType8 = new HashSet<RoomType>();
            roomType8.Add(RoomType.Lecture);
            var availabilityRoom8 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom8.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom8.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom8.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom8.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom8.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType8, 20, availabilityRoom8, "308"));

            var roomType9 = new HashSet<RoomType>();
            roomType9.Add(RoomType.Lecture);
            var availabilityRoom9 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom9.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom9.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom9.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom9.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom9.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType9, 18, availabilityRoom9, "307"));

            var roomType10 = new HashSet<RoomType>();
            roomType10.Add(RoomType.Lecture);
            var availabilityRoom10 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom10.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom10.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom10.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom10.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom10.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType10, 24, availabilityRoom10, "209B"));

            var roomType11 = new HashSet<RoomType>();
            roomType11.Add(RoomType.Lecture);
            var availabilityRoom11 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom11.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom11.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom11.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom11.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom11.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType11, 24, availabilityRoom11, "401"));

            var roomType12 = new HashSet<RoomType>();
            roomType12.Add(RoomType.Lecture);
            var availabilityRoom12 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom12.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom12.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom12.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom12.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom12.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType12, 20, availabilityRoom12, "404"));

            var roomType13 = new HashSet<RoomType>();
            roomType13.Add(RoomType.Lecture);
            var availabilityRoom13 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom13.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom13.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom13.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom13.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom13.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType13, 20, availabilityRoom13, "311"));

            var roomType14 = new HashSet<RoomType>();
            roomType14.Add(RoomType.Lecture);
            var availabilityRoom14 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom14.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom14.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom14.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom14.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom14.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType14, 20, availabilityRoom14, "101"));

            // ---------------------------------------------------------------------------------------------------

            teachers = new List<Teacher>();

            var teacher1freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher1freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher1freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher1freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher1freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher1freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher1freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher1rooms = new List<Room>();
            var teacher1requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "G. Aleksandrov"));

            var teacher2freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher2freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher2freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher2freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher2freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher2freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher2freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher2rooms = new List<Room>();
            var teacher2requirements = new Requirements(0.3, teacher2freeTime, teacher2rooms);
            teachers.Add(new Teacher(teacher2requirements, "E. Velikova"));

            var teacher3freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher3rooms = new List<Room>();
            teacher3rooms.Add(rooms[13]);
            var teacher3requirements = new Requirements(0.3, teacher3freeTime, teacher3rooms);
            teachers.Add(new Teacher(teacher3requirements, "M. Todorova"));

            var teacher4freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher4rooms = new List<Room>();
            var teacher4requirements = new Requirements(0.3, teacher4freeTime, teacher4rooms);
            teachers.Add(new Teacher(teacher4requirements, "G. Georgiev"));

            var teacher5freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher5rooms = new List<Room>();
            var teacher5requirements = new Requirements(0.3, teacher5freeTime, teacher5rooms);
            teachers.Add(new Teacher(teacher5requirements, "AsistentDis1"));

            var teacher6freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher6rooms = new List<Room>();
            var teacher6requirements = new Requirements(0.3, teacher6freeTime, teacher6rooms);
            teachers.Add(new Teacher(teacher6requirements, "AsistentAlgebra1"));

            var teacher7freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher7rooms = new List<Room>();
            var teacher7requirements = new Requirements(0.3, teacher7freeTime, teacher7rooms);
            teachers.Add(new Teacher(teacher7requirements, "AsistentUP1"));

            var teacher8freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher8rooms = new List<Room>();
            var teacher8requirements = new Requirements(0.3, teacher8freeTime, teacher8rooms);
            teachers.Add(new Teacher(teacher8requirements, "AsistentUPp1"));

            var teacher9freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher9rooms = new List<Room>();
            var teacher9requirements = new Requirements(0.3, teacher9freeTime, teacher9rooms);
            teachers.Add(new Teacher(teacher9requirements, "AsistentDStr1"));

            var teacher10freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher10rooms = new List<Room>();
            var teacher10requirements = new Requirements(0.3, teacher10freeTime, teacher10rooms);
            teachers.Add(new Teacher(teacher10requirements, "AsistentDis2"));

            var teacher11freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher11rooms = new List<Room>();
            var teacher11requirements = new Requirements(0.3, teacher11freeTime, teacher11rooms);
            teachers.Add(new Teacher(teacher11requirements, "AsistentAlgebra2"));

            var teacher12freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher12rooms = new List<Room>();
            var teacher12requirements = new Requirements(0.3, teacher12freeTime, teacher12rooms);
            teachers.Add(new Teacher(teacher12requirements, "AsistentUP2"));

            var teacher13freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher13rooms = new List<Room>();
            var teacher13requirements = new Requirements(0.3, teacher13freeTime, teacher13rooms);
            teachers.Add(new Teacher(teacher13requirements, "AsistentUPp2"));

            var teacher14freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher14rooms = new List<Room>();
            var teacher14requirements = new Requirements(0.3, teacher14freeTime, teacher14rooms);
            teachers.Add(new Teacher(teacher14requirements, "AsistentDStr2"));

            var teacher15freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher15rooms = new List<Room>();
            var teacher15requirements = new Requirements(0.3, teacher15freeTime, teacher15rooms);
            teachers.Add(new Teacher(teacher15requirements, "AsistentDis3"));

            var teacher16freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher16rooms = new List<Room>();
            var teacher16requirements = new Requirements(0.3, teacher16freeTime, teacher16rooms);
            teachers.Add(new Teacher(teacher16requirements, "AsistentAlgebra3"));

            var teacher17freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher17rooms = new List<Room>();
            var teacher17requirements = new Requirements(0.3, teacher17freeTime, teacher17rooms);
            teachers.Add(new Teacher(teacher17requirements, "AsistentUP3"));

            var teacher18freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher18rooms = new List<Room>();
            var teacher18requirements = new Requirements(0.3, teacher18freeTime, teacher18rooms);
            teachers.Add(new Teacher(teacher18requirements, "AsistentUPp3"));

            var teacher19freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher19rooms = new List<Room>();
            var teacher19requirements = new Requirements(0.3, teacher19freeTime, teacher19rooms);
            teachers.Add(new Teacher(teacher19requirements, "AsistentDStr3"));

            var teacher20freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher20rooms = new List<Room>();
            var teacher20requirements = new Requirements(0.3, teacher20freeTime, teacher20rooms);
            teachers.Add(new Teacher(teacher20requirements, "AsistentDis4"));

            var teacher21freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher21rooms = new List<Room>();
            var teacher21requirements = new Requirements(0.3, teacher21freeTime, teacher21rooms);
            teachers.Add(new Teacher(teacher21requirements, "AsistentAlgebra4"));

            var teacher22freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher22rooms = new List<Room>();
            var teacher22requirements = new Requirements(0.3, teacher22freeTime, teacher22rooms);
            teachers.Add(new Teacher(teacher22requirements, "AsistentUP4"));

            var teacher23freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher23rooms = new List<Room>();
            var teacher23requirements = new Requirements(0.3, teacher23freeTime, teacher23rooms);
            teachers.Add(new Teacher(teacher23requirements, "AsistentUPp4"));

            var teacher24freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher24rooms = new List<Room>();
            var teacher24requirements = new Requirements(0.3, teacher24freeTime, teacher24rooms);
            teachers.Add(new Teacher(teacher24requirements, "AsistentDStr4"));

            // ---------------------------------------------------------------------------------------------------

            subjects = new List<Subject>();

            var subject1roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Lecture);
            var subject1teachers = new List<Teacher>();
            subject1teachers.Add(teachers[0]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DIS", 4));

            var subject2roomtypes = new HashSet<RoomType>();
            subject2roomtypes.Add(RoomType.Lecture);
            var subject2teachers = new List<Teacher>();
            subject2teachers.Add(teachers[1]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "Algebra", 3));

            var subject3roomtypes = new HashSet<RoomType>();
            subject3roomtypes.Add(RoomType.Lecture);
            var subject3teachers = new List<Teacher>();
            subject3teachers.Add(teachers[2]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "UP", 3));

            var subject4roomtypes = new HashSet<RoomType>();
            subject4roomtypes.Add(RoomType.Lecture);
            var subject4teachers = new List<Teacher>();
            subject4teachers.Add(teachers[3]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "DStr", 3));

            var subject5roomtypes = new HashSet<RoomType>();
            subject5roomtypes.Add(RoomType.Lecture);
            var subject5teachers = new List<Teacher>();
            subject5teachers.Add(teachers[4]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DIS-upr-1", 2));

            var subject6roomtypes = new HashSet<RoomType>();
            subject6roomtypes.Add(RoomType.Lecture);
            var subject6teachers = new List<Teacher>();
            subject6teachers.Add(teachers[5]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "Algebra-upr-1", 2));

            var subject7roomtypes = new HashSet<RoomType>();
            subject7roomtypes.Add(RoomType.Computer);
            var subject7teachers = new List<Teacher>();
            subject7teachers.Add(teachers[6]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "UP-upr-1", 2));

            var subject8roomtypes = new HashSet<RoomType>();
            subject8roomtypes.Add(RoomType.Computer);
            var subject8teachers = new List<Teacher>();
            subject8teachers.Add(teachers[7]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "UP-pr-1", 2));

            var subject9roomtypes = new HashSet<RoomType>();
            subject9roomtypes.Add(RoomType.Lecture);
            var subject9teachers = new List<Teacher>();
            subject9teachers.Add(teachers[8]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DStr-upr-1", 2));

            var subject10roomtypes = new HashSet<RoomType>();
            subject10roomtypes.Add(RoomType.Lecture);
            var subject10teachers = new List<Teacher>();
            subject10teachers.Add(teachers[9]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DIS-upr-2", 2));

            var subject11roomtypes = new HashSet<RoomType>();
            subject11roomtypes.Add(RoomType.Lecture);
            var subject11teachers = new List<Teacher>();
            subject11teachers.Add(teachers[10]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "Algebra-upr-2", 2));

            var subject12roomtypes = new HashSet<RoomType>();
            subject12roomtypes.Add(RoomType.Computer);
            var subject12teachers = new List<Teacher>();
            subject12teachers.Add(teachers[11]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "UP-upr-2", 2));

            var subject13roomtypes = new HashSet<RoomType>();
            subject13roomtypes.Add(RoomType.Computer);
            var subject13teachers = new List<Teacher>();
            subject13teachers.Add(teachers[12]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "UP-pr-2", 2));

            var subject14roomtypes = new HashSet<RoomType>();
            subject14roomtypes.Add(RoomType.Lecture);
            var subject14teachers = new List<Teacher>();
            subject14teachers.Add(teachers[13]);

            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DStr-upr-2", 2));
            var subject15roomtypes = new HashSet<RoomType>();
            subject15roomtypes.Add(RoomType.Lecture);
            var subject15teachers = new List<Teacher>();
            subject15teachers.Add(teachers[14]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DIS-upr-3", 2));

            var subject16roomtypes = new HashSet<RoomType>();
            subject16roomtypes.Add(RoomType.Lecture);
            var subject16teachers = new List<Teacher>();
            subject16teachers.Add(teachers[15]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "Algebra-upr-3", 2));

            var subject17roomtypes = new HashSet<RoomType>();
            subject17roomtypes.Add(RoomType.Computer);
            var subject17teachers = new List<Teacher>();
            subject17teachers.Add(teachers[16]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "UP-upr-3", 2));

            var subject18roomtypes = new HashSet<RoomType>();
            subject18roomtypes.Add(RoomType.Computer);
            var subject18teachers = new List<Teacher>();
            subject18teachers.Add(teachers[17]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "UP-pr-3", 2));

            var subject19roomtypes = new HashSet<RoomType>();
            subject19roomtypes.Add(RoomType.Lecture);
            var subject19teachers = new List<Teacher>();
            subject19teachers.Add(teachers[18]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DStr-upr-3", 2));

            var subject20roomtypes = new HashSet<RoomType>();
            subject20roomtypes.Add(RoomType.Lecture);
            var subject20teachers = new List<Teacher>();
            subject20teachers.Add(teachers[19]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DIS-upr-4", 2));

            var subject21roomtypes = new HashSet<RoomType>();
            subject21roomtypes.Add(RoomType.Lecture);
            var subject21teachers = new List<Teacher>();
            subject21teachers.Add(teachers[20]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "Algebra-upr-4", 2));

            var subject22roomtypes = new HashSet<RoomType>();
            subject22roomtypes.Add(RoomType.Computer);
            var subject22teachers = new List<Teacher>();
            subject22teachers.Add(teachers[21]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "UP-upr-4", 2));

            var subject23roomtypes = new HashSet<RoomType>();
            subject23roomtypes.Add(RoomType.Computer);
            var subject23teachers = new List<Teacher>();
            subject23teachers.Add(teachers[22]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "UP-pr-4", 2));

            var subject24roomtypes = new HashSet<RoomType>();
            subject24roomtypes.Add(RoomType.Lecture);
            var subject24teachers = new List<Teacher>();
            subject24teachers.Add(teachers[23]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DStr-upr-4", 2));

            // ---------------------------------------------------------------------------------------------------

            groups = new List<Group>();

            var group1subjects = new List<Subject>();
            group1subjects.Add(subjects[0]);
            group1subjects.Add(subjects[1]);
            group1subjects.Add(subjects[2]);
            group1subjects.Add(subjects[3]);
            group1subjects.Add(subjects[4]);
            group1subjects.Add(subjects[5]);
            group1subjects.Add(subjects[6]);
            group1subjects.Add(subjects[7]);
            group1subjects.Add(subjects[8]);
            groups.Add(new Group(group1subjects, 22, "Group 1"));

            var group2subjects = new List<Subject>();
            group2subjects.Add(subjects[0]);
            group2subjects.Add(subjects[1]);
            group2subjects.Add(subjects[2]);
            group2subjects.Add(subjects[3]);
            group2subjects.Add(subjects[9]);
            group2subjects.Add(subjects[10]);
            group2subjects.Add(subjects[11]);
            group2subjects.Add(subjects[12]);
            group2subjects.Add(subjects[13]);
            groups.Add(new Group(group2subjects, 20, "Group 2"));

            var group3subjects = new List<Subject>();
            group3subjects.Add(subjects[0]);
            group3subjects.Add(subjects[1]);
            group3subjects.Add(subjects[2]);
            group3subjects.Add(subjects[3]);
            group3subjects.Add(subjects[14]);
            group3subjects.Add(subjects[15]);
            group3subjects.Add(subjects[16]);
            group3subjects.Add(subjects[17]);
            group3subjects.Add(subjects[18]);
            groups.Add(new Group(group3subjects, 20, "Group 3"));

            var group4subjects = new List<Subject>();
            group4subjects.Add(subjects[0]);
            group4subjects.Add(subjects[1]);
            group4subjects.Add(subjects[2]);
            group4subjects.Add(subjects[3]);
            group4subjects.Add(subjects[19]);
            group4subjects.Add(subjects[20]);
            group4subjects.Add(subjects[21]);
            group4subjects.Add(subjects[22]);
            group4subjects.Add(subjects[23]);
            groups.Add(new Group(group4subjects, 18, "Group 4"));

            solutions = new ProgramGenerator().GenerateProgram(rooms, subjects, teachers, groups);
        }
    }
}
