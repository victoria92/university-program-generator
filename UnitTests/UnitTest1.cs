using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UniProgramGen.Data;
using UniProgramGen.Helpers;
using Newtonsoft.Json;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private List<RoomType> organic_room_types;
        private List<TimeSlot> available_timeslots;
        private List<Room> rooms;
        private List<Requirements> requirements_list;
        private List<Teacher> teachers;

        public void initalizeExampleData()
        {
            if(organic_room_types == null)
            {
                organic_room_types = new List<RoomType>();
                organic_room_types.Add(RoomType.Projector);
                organic_room_types.Add(RoomType.Komin);
            }

            if(available_timeslots == null)
            {
                var available_timeslot = new TimeSlot(DayOfWeek.Monday, 9, 22);
                available_timeslots = new List<TimeSlot>();
                available_timeslots.Add(available_timeslot);
            }
            
            if(rooms == null)
            {
                var room = new Room(organic_room_types, 150, available_timeslots, "ХФ210");
                rooms = new List<Room>();
                rooms.Add(room);
            }

            if(requirements_list == null)
            {
                var requirements = new Requirements(10, available_timeslots, rooms);
                requirements_list = new List<Requirements>();
                requirements_list.Add(requirements);
                var organich_chemistry_teacher = new Teacher(requirements_list[0], "Prof. Hristo Hristov");
            }
            var organic_chemistry_teachers = new List<Teacher>();

            var s = new Subject(organic_room_types, organic_chemistry_teachers, "Organic Chemistry Lectures", 1);
        }

        [TestMethod]
        public void testSerialization()
        {
            string organic_room_types_serialized = Newtonsoft.Json.JsonConvert.SerializeObject(organic_room_types);
            List<RoomType> organic_room_types_deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RoomType>>(organic_room_types_serialized);
            Assert.AreEqual(organic_room_types_deserialized, organic_room_types);

            string available_timeslots_serialized = Newtonsoft.Json.JsonConvert.SerializeObject(available_timeslots);
            List<TimeSlot> deserialized_available_timeslots = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TimeSlot>>(available_timeslots_serialized);
            Assert.AreEqual(deserialized_available_timeslots, available_timeslots);

            string rooms_serialized = Newtonsoft.Json.JsonConvert.SerializeObject(rooms);
            List<Room> deserialized_rooms = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Room>>(rooms_serialized);

            Assert.AreEqual(deserialized_available_timeslots, available_timeslots);
        }

        [TestMethod]
        public void generateCalendar()
        {

        }
    }
}