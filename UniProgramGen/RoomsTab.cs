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

        private bool updating = false;

        private void ClearCheckedListRoomTypes()
        {
            foreach (int selectedIndices in checkedListRoomTypes.CheckedIndices)
            {
                checkedListRoomTypes.SetItemChecked(selectedIndices, false);
            }
        }

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRoom = listBoxRooms.SelectedItem as Room;

            if (selectedRoom == null)
            {
                listBoxRoomMonday.ClearSelected();
                listBoxRoomTuesday.ClearSelected();
                listBoxRoomWednesday.ClearSelected();
                listBoxRoomThursday.ClearSelected();
                listBoxRoomFriday.ClearSelected();
                listBoxRoomSaturday.ClearSelected();

                ClearCheckedListRoomTypes();

                numericUpDownCapacity.Value = 0;

                roomName.Text = "";
                return;
            }

            SetRoomTimeSlots(listBoxRoomMonday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Monday));
            SetRoomTimeSlots(listBoxRoomTuesday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Tuesday));
            SetRoomTimeSlots(listBoxRoomWednesday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Wednesday));
            SetRoomTimeSlots(listBoxRoomThursday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Thursday));
            SetRoomTimeSlots(listBoxRoomFriday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Friday));
            SetRoomTimeSlots(listBoxRoomSaturday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Saturday));

            ClearCheckedListRoomTypes();
            foreach (var roomType in selectedRoom.types)
            {
                checkedListRoomTypes.SetItemChecked((int) roomType, true);
            }
            numericUpDownCapacity.Value = selectedRoom.capacity;
            roomName.Text = selectedRoom.nameOrNumber;
        }

        private void SetRoomTimeSlots(ListBox listBoxRoom, IEnumerable<TimeSlot> timeSlots)
        {
            updating = true;
            listBoxRoom.ClearSelected();
            foreach (var timeSlot in timeSlots)
            {
                for (uint i = timeSlot.StartHour; i < timeSlot.EndHour; i++)
			    {
                    listBoxRoom.SetSelected((int) i - 7, true);
			    }
            }
            updating = false;
        }

        private List<TimeSlot> getRoomAvailability()
        {
            var mondayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomMonday, DayOfWeek.Monday);
            var tuesdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomTuesday, DayOfWeek.Tuesday);
            var wednesdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomWednesday, DayOfWeek.Wednesday);
            var thursdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomThursday, DayOfWeek.Thursday);
            var fridayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomFriday, DayOfWeek.Friday);
            var saturdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxRoomSaturday, DayOfWeek.Saturday);

            var roomAvailability = new List<TimeSlot>();
            roomAvailability.AddRange(mondayAvailableTime);
            roomAvailability.AddRange(tuesdayAvailableTime);
            roomAvailability.AddRange(wednesdayAvailableTime);
            roomAvailability.AddRange(thursdayAvailableTime);
            roomAvailability.AddRange(fridayAvailableTime);
            roomAvailability.AddRange(saturdayAvailableTime);

            return roomAvailability;
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            var roomAvailability = getRoomAvailability();

            HashSet<RoomType> roomTypes = new HashSet<RoomType>();
            foreach (int selectedIndex in checkedListRoomTypes.CheckedIndices)
            {
                roomTypes.Add((RoomType) selectedIndex);
            }

            Rooms.Add(new Room(roomTypes, (uint) numericUpDownCapacity.Value, roomAvailability, roomName.Text));

            listBoxRooms.DisplayMember = "NameOrNumber";
            listBoxRooms.DataSource = Rooms;

            listBoxRooms.ClearSelected();
        }

        private void listBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updating)
            {
                return;
            }
            var selectedRoom = listBoxRooms.SelectedItem as Room;
            if (selectedRoom != null)
            {
                selectedRoom.availability = getRoomAvailability();
            }
        }
    }
}
