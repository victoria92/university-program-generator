using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UniProgramGen.Data;
using UniProgramGen.Helpers;

namespace UniProgramGen
{
    public partial class RoomsTab : UserControl
    {
        public RoomsTab()
        {
            InitializeComponent();

            Rooms = new List<Room>();
        }

        public List<Room> Rooms { get; private set; }

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRoom = listBoxRooms.SelectedItem as Room;

            if (selectedRoom == null)
            {
                return;
            }

            SetRoomTimeSlots(listBoxRoomMonday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Monday));
            SetRoomTimeSlots(listBoxRoomTuesday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Tuesday));
            SetRoomTimeSlots(listBoxRoomWednesday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Wednesday));
            SetRoomTimeSlots(listBoxRoomThursday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Thursday));
            SetRoomTimeSlots(listBoxRoomFriday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Friday));
            SetRoomTimeSlots(listBoxRoomSaturday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Saturday));
        }

        private void SetRoomTimeSlots(ListBox listBoxRoom, IEnumerable<TimeSlot> timeSlots)
        {
            listBoxRoom.ClearSelected();
            foreach (var timeSlot in timeSlots)
            {
                for (uint i = timeSlot.StartHour; i < timeSlot.EndHour; i++)
			    {
                    listBoxRoom.SetSelected((int) i - 7, true);
			    }
            }
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            var mondayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomMonday, DayOfWeek.Monday);
            var tuesdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomTuesday, DayOfWeek.Monday);
            var wednesdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomWednesday, DayOfWeek.Monday);
            var thursdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomThursday, DayOfWeek.Monday);
            var fridayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomFriday, DayOfWeek.Monday);
            var saturdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomSaturday, DayOfWeek.Monday);

            List<TimeSlot> roomAvailability = new List<TimeSlot>();
            roomAvailability.AddRange(mondayAvailableTime);
            roomAvailability.AddRange(mondayAvailableTime);
            roomAvailability.AddRange(mondayAvailableTime);
            roomAvailability.AddRange(mondayAvailableTime);
            roomAvailability.AddRange(mondayAvailableTime);
            roomAvailability.AddRange(mondayAvailableTime);

            HashSet<RoomType> roomTypes = new HashSet<RoomType>();
            foreach (int selectedIndex in checkedListRoomTypes.SelectedIndices)
            {
                roomTypes.Add((RoomType)selectedIndex);
            }

            Rooms.Add(new Room(roomTypes, (uint) numericUpDownCapacity.Value, roomAvailability, roomName.Text));

            listBoxRooms.DisplayMember = "NameOrNumber";
            listBoxRooms.DataSource = Rooms;
        }
    }
}
