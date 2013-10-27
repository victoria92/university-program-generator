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
        public IEnumerable<Room> rooms;
        public IEnumerable<Subject> subjects;
        public IEnumerable<Teacher> teachers;
        public IEnumerable<Group> groups;

        public IEnumerable<ScheduledTimeSlot[]> solutions;

        public void tTestData()
        {
            List<Room> rooms = new List<Room>();

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
            roomType1.Add(RoomType.Computer);
            var availabilityRoom2 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 20, availabilityRoom1, "306"));

            var roomType3 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Computer);
            var availabilityRoom3 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 22, availabilityRoom1, "120"));

            var roomType4 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Computer);
            var availabilityRoom4 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom4.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom4.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom4.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom4.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom4.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 20, availabilityRoom1, "314"));

            var roomType5 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Computer);
            var availabilityRoom5 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom5.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom5.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom5.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom5.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom5.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 20, availabilityRoom1, "019"));

            var roomType6 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Lecture);
            var availabilityRoom6 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom6.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom6.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom6.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom6.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom6.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 100, availabilityRoom1, "229"));

            var roomType7 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Lecture);
            var availabilityRoom7 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom7.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom7.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom7.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom7.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom7.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 24, availabilityRoom1, "03"));

            var roomType8 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Lecture);
            var availabilityRoom8 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom8.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom8.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom8.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom8.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom8.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 20, availabilityRoom1, "308"));

            var roomType9 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Lecture);
            var availabilityRoom9 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom9.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom9.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom9.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom9.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom9.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 18, availabilityRoom1, "307"));

            var roomType10 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Lecture);
            var availabilityRoom10 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom10.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom10.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom10.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom10.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom10.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 24, availabilityRoom1, "209B"));

            var roomType11 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Lecture);
            var availabilityRoom11 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom11.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom11.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom11.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom11.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom11.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 24, availabilityRoom1, "401"));

            var roomType12 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Lecture);
            var availabilityRoom12 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom12.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom12.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom12.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom12.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom12.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 20, availabilityRoom1, "404"));

            var roomType13 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Lecture);
            var availabilityRoom13 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom13.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom13.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom13.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom13.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom13.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 20, availabilityRoom1, "311"));

            var roomType14 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Lecture);
            var availabilityRoom14 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom14.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            availabilityRoom14.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            availabilityRoom14.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            availabilityRoom14.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            availabilityRoom14.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            rooms.Add(new Room(roomType1, 20, availabilityRoom1, "101"));

            // ---------------------------------------------------------------------------------------------------

            List<Teacher> teachers = new List<Teacher>();

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
            var teacher2requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "E. Velikova"));

            var teacher3freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher3freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher3rooms = new List<Room>();
            teacher3rooms.Add(rooms[13]);
            var teacher3requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "M. Todorova"));

            var teacher4freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher4freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher4rooms = new List<Room>();
            var teacher4requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "G. Georgiev"));

            var teacher5freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher5freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher5rooms = new List<Room>();
            var teacher5requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentDis1"));

            var teacher6freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher6freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher6rooms = new List<Room>();
            var teacher6requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentAlgebra1"));

            var teacher7freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher7freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher7rooms = new List<Room>();
            var teacher7requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentUP1"));

            var teacher8freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher8freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher8rooms = new List<Room>();
            var teacher8requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentUPp1"));

            var teacher9freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher9freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher9rooms = new List<Room>();
            var teacher9requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentDStr1"));

            var teacher10freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher10freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher10rooms = new List<Room>();
            var teacher10requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentDis2"));

            var teacher11freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher11freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher11rooms = new List<Room>();
            var teacher11requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentAlgebra2"));

            var teacher12freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher12freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher12rooms = new List<Room>();
            var teacher12requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentUP2"));

            var teacher13freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher13freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher13rooms = new List<Room>();
            var teacher13requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentUPp2"));

            var teacher14freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher14freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher14rooms = new List<Room>();
            var teacher14requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentDStr2"));

            var teacher15freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher15freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher15rooms = new List<Room>();
            var teacher15requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentDis3"));

            var teacher16freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher16freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher16rooms = new List<Room>();
            var teacher16requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentAlgebra3"));

            var teacher17freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher17freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher17rooms = new List<Room>();
            var teacher17requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentUP3"));

            var teacher18freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher18freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher18rooms = new List<Room>();
            var teacher18requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentUPp3"));

            var teacher19freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher19freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher19rooms = new List<Room>();
            var teacher19requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentDStr3"));

            var teacher20freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher20freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher20rooms = new List<Room>();
            var teacher20requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentDis4"));

            var teacher21freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher21freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher21rooms = new List<Room>();
            var teacher21requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentAlgebra4"));

            var teacher22freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher22freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher22rooms = new List<Room>();
            var teacher22requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentUP4"));

            var teacher23freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher23freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher23rooms = new List<Room>();
            var teacher23requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentUPp4"));

            var teacher24freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 7, 22));
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 7, 22));
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Wednesday, 7, 22));
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Thursday, 7, 22));
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 7, 22));
            teacher24freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Saturday, 7, 22));
            var teacher24rooms = new List<Room>();
            var teacher24requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "AsistentDStr4"));

            // ---------------------------------------------------------------------------------------------------

            List<Subject> subjects = new List<Subject>();

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
            subject1roomtypes.Add(RoomType.Lecture);
            var subject3teachers = new List<Teacher>();
            subject1teachers.Add(teachers[2]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "UP", 3));

            var subject4roomtypes = new HashSet<RoomType>();
            subject2roomtypes.Add(RoomType.Lecture);
            var subject4teachers = new List<Teacher>();
            subject2teachers.Add(teachers[3]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "DStr", 3));

            var subject5roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Lecture);
            var subject5teachers = new List<Teacher>();
            subject1teachers.Add(teachers[4]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DIS-upr-1", 2));

            var subject6roomtypes = new HashSet<RoomType>();
            subject2roomtypes.Add(RoomType.Lecture);
            var subject6teachers = new List<Teacher>();
            subject2teachers.Add(teachers[5]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "Algebra-upr-1", 2));

            var subject7roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Computer);
            var subject7teachers = new List<Teacher>();
            subject1teachers.Add(teachers[6]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "UP-upr-1", 2));

            var subject8roomtypes = new HashSet<RoomType>();
            subject2roomtypes.Add(RoomType.Computer);
            var subject8teachers = new List<Teacher>();
            subject2teachers.Add(teachers[7]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "UP-pr-1", 2));

            var subject9roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Lecture);
            var subject9teachers = new List<Teacher>();
            subject1teachers.Add(teachers[8]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DStr-upr-1", 2));

            var subject10roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Lecture);
            var subject10teachers = new List<Teacher>();
            subject1teachers.Add(teachers[9]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DIS-upr-2", 2));

            var subject11roomtypes = new HashSet<RoomType>();
            subject2roomtypes.Add(RoomType.Lecture);
            var subject11teachers = new List<Teacher>();
            subject2teachers.Add(teachers[10]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "Algebra-upr-2", 2));

            var subject12roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Computer);
            var subject12teachers = new List<Teacher>();
            subject1teachers.Add(teachers[11]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "UP-upr-2", 2));

            var subject13roomtypes = new HashSet<RoomType>();
            subject2roomtypes.Add(RoomType.Computer);
            var subject13teachers = new List<Teacher>();
            subject2teachers.Add(teachers[12]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "UP-pr-2", 2));

            var subject14roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Lecture);
            var subject14teachers = new List<Teacher>();
            subject1teachers.Add(teachers[13]);

            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DStr-upr-2", 2));
            var subject15roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Lecture);
            var subject15teachers = new List<Teacher>();
            subject1teachers.Add(teachers[14]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DIS-upr-3", 2));

            var subject16roomtypes = new HashSet<RoomType>();
            subject2roomtypes.Add(RoomType.Lecture);
            var subject16teachers = new List<Teacher>();
            subject2teachers.Add(teachers[15]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "Algebra-upr-3", 2));

            var subject17roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Computer);
            var subject17teachers = new List<Teacher>();
            subject1teachers.Add(teachers[16]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "UP-upr-3", 2));

            var subject18roomtypes = new HashSet<RoomType>();
            subject2roomtypes.Add(RoomType.Computer);
            var subject18teachers = new List<Teacher>();
            subject2teachers.Add(teachers[17]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "UP-pr-3", 2));

            var subject19roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Lecture);
            var subject19teachers = new List<Teacher>();
            subject1teachers.Add(teachers[18]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DStr-upr-3", 2));

            var subject20roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Lecture);
            var subject20teachers = new List<Teacher>();
            subject1teachers.Add(teachers[19]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DIS-upr-4", 2));

            var subject21roomtypes = new HashSet<RoomType>();
            subject2roomtypes.Add(RoomType.Lecture);
            var subject21teachers = new List<Teacher>();
            subject2teachers.Add(teachers[20]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "Algebra-upr-4", 2));

            var subject22roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Computer);
            var subject22teachers = new List<Teacher>();
            subject1teachers.Add(teachers[21]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "UP-upr-4", 2));

            var subject23roomtypes = new HashSet<RoomType>();
            subject2roomtypes.Add(RoomType.Computer);
            var subject23teachers = new List<Teacher>();
            subject2teachers.Add(teachers[22]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "UP-pr-4", 2));

            var subject24roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Lecture);
            var subject24teachers = new List<Teacher>();
            subject1teachers.Add(teachers[23]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "DStr-upr-4", 2));

            // ---------------------------------------------------------------------------------------------------

            List<Group> groups = new List<Group>();

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
            group1subjects.Add(subjects[0]);
            group1subjects.Add(subjects[1]);
            group1subjects.Add(subjects[2]);
            group1subjects.Add(subjects[3]);
            group1subjects.Add(subjects[9]);
            group1subjects.Add(subjects[10]);
            group1subjects.Add(subjects[11]);
            group1subjects.Add(subjects[12]);
            group1subjects.Add(subjects[13]);
            groups.Add(new Group(group2subjects, 20, "Group 2"));

            var group3subjects = new List<Subject>();
            group1subjects.Add(subjects[0]);
            group1subjects.Add(subjects[1]);
            group1subjects.Add(subjects[2]);
            group1subjects.Add(subjects[3]);
            group1subjects.Add(subjects[14]);
            group1subjects.Add(subjects[15]);
            group1subjects.Add(subjects[16]);
            group1subjects.Add(subjects[17]);
            group1subjects.Add(subjects[18]);
            groups.Add(new Group(group3subjects, 20, "Group 3"));

            var group4subjects = new List<Subject>();
            group1subjects.Add(subjects[0]);
            group1subjects.Add(subjects[1]);
            group1subjects.Add(subjects[2]);
            group1subjects.Add(subjects[3]);
            group1subjects.Add(subjects[19]);
            group1subjects.Add(subjects[20]);
            group1subjects.Add(subjects[21]);
            group1subjects.Add(subjects[22]);
            group1subjects.Add(subjects[23]);
            groups.Add(new Group(group4subjects, 18, "Group 4"));

            solutions = new ProgramGenerator().GenerateProgram(rooms, subjects, teachers, groups);
        }
    }
}
