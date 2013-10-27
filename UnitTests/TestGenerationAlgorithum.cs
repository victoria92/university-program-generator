using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UniProgramGen.Data;
using UniProgramGen.Generator;

namespace UnitTests
{
    [TestClass]
    public class TestGenerationAlgorithum
    {
        [TestMethod]
        public void TestAlgorythm1()
        {
            List<Room> rooms = new List<Room>();

            var roomType1 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Computer);
            var availabilityRoom1 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom1.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 13, 15));
            availabilityRoom1.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Sunday, 16, 17));
            availabilityRoom1.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 12, 17));
            rooms.Add(new Room(roomType1, 30, availabilityRoom1, "404"));

            var roomType2 = new HashSet<RoomType>();
            roomType2.Add(RoomType.Lecture);
            var availabilityRoom2 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 13, 14));
            availabilityRoom2.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Sunday, 11, 17));
            rooms.Add(new Room(roomType2, 60, availabilityRoom2, "326"));

            var roomType3 = new HashSet<RoomType>();
            roomType1.Add(RoomType.Computer);
            roomType1.Add(RoomType.Projector);
            var availabilityRoom3 = new List<UniProgramGen.Helpers.TimeSlot>();
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 12, 14));
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 13, 19));
            availabilityRoom3.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 12, 17));
            rooms.Add(new Room(roomType3, 10, availabilityRoom3, "01"));

            // ---------------------------------------------------------------------------------------------------

            List<Teacher> teachers = new List<Teacher>();

            var teacher1freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher1freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Monday, 12, 13));
            teacher1freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Friday, 12, 20));
            var teacher1rooms = new List<Room>();
            teacher1rooms.Add(rooms[1]);
            teacher1rooms.Add(rooms[2]);
            var teacher1requirements = new Requirements(0.3, teacher1freeTime, teacher1rooms);
            teachers.Add(new Teacher(teacher1requirements, "Kiki Vladimiki"));

            var teacher2freeTime = new List<UniProgramGen.Helpers.TimeSlot>();
            teacher2freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Sunday, 11, 18));
            teacher2freeTime.Add(new UniProgramGen.Helpers.TimeSlot(DayOfWeek.Tuesday, 12, 20));
            var teacher2rooms = new List<Room>();
            teacher2rooms.Add(rooms[0]);
            var teacher2requirements = new Requirements(1, teacher2freeTime, teacher2rooms);
            teachers.Add(new Teacher(teacher2requirements, "Pesho Kelesho"));

            // ---------------------------------------------------------------------------------------------------

            List<Subject> subjects = new List<Subject>();

            var subject1roomtypes = new HashSet<RoomType>();
            subject1roomtypes.Add(RoomType.Computer);
            var subject1teachers = new List<Teacher>();
            subject1teachers.Add(teachers[0]);
            subjects.Add(new Subject(subject1roomtypes, subject1teachers, "OOP", 2));

            var subject2roomtypes = new HashSet<RoomType>();
            subject2roomtypes.Add(RoomType.Lecture);
            var subject2teachers = new List<Teacher>();
            subject2teachers.Add(teachers[1]);
            subjects.Add(new Subject(subject2roomtypes, subject2teachers, "KARH", 1));

            // ---------------------------------------------------------------------------------------------------

            List<Group> groups = new List<Group>();

            var group1subjects = new List<Subject>();
            group1subjects.Add(subjects[0]);
            groups.Add(new Group(group1subjects, 5, "SoftInj1"));

            var group2subjects = new List<Subject>();
            group2subjects.Add(subjects[0]);
            group2subjects.Add(subjects[1]);
            groups.Add(new Group(group2subjects, 6, "SoftInj2"));

            var group3subjects = new List<Subject>();
            group3subjects.Add(subjects[0]);
            group3subjects.Add(subjects[1]);
            groups.Add(new Group(group3subjects, 12, "KompNauki"));

            var generatorRessult = new ProgramGenerator().GenerateProgram(rooms, subjects, teachers, groups);
            
            var ser = new Newtonsoft.Json.JsonSerializer();
            
            var ser_string = Newtonsoft.Json.JsonConvert.SerializeObject(generatorRessult);
            System.IO.File.WriteAllText(@"..\..\program_generated_test.js", ser_string);
                        
        }
    }
}
