using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UniProgramGen.Data;
using UniProgramGen.Helpers;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void initalizeExampleData()
        {
            var organic_room_types = new List<RoomType>();
            organic_room_types.Add(RoomType.Projector);
            organic_room_types.Add(RoomType.Komin);

            var available_timeslot = new TimeSlot(DayOfWeek.Monday, 9, 22);
            var available_timeslots = new List<TimeSlot>();
            available_timeslots.Add(available_timeslot);
            
            var room = new Room(organic_room_types, 150, available_timeslots, "ХФ210");
            var rooms = new List<Room>();
            rooms.Add(room);

            var organic_chemistry_room_requirements = new Requirements(10, available_timeslots, rooms);
            var organich_chemistry_teacher = new Teacher(organic_chemistry_room_requirements, "Prof. Hristo Hristov");

            var organic_chemistry_teachers = new List<Teacher>();

            var s = new Subject(organic_room_types, organic_chemistry_teachers, "Organic Chemistry Lectures", 1);
        }
    }
}