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
            bindingSource.DataSource = Rooms;

            listBoxRooms.DisplayMember = "NameOrNumber";
            listBoxRooms.DataSource = bindingSource;
        }

        public List<Room> Rooms { get; private set; }

        private bool updating = false;

        private BindingSource bindingSource = new BindingSource();

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

            UIHelpers.SetObjectTimeSlots(listBoxRoomMonday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Monday), ref updating);
            UIHelpers.SetObjectTimeSlots(listBoxRoomTuesday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Tuesday), ref updating);
            UIHelpers.SetObjectTimeSlots(listBoxRoomWednesday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Wednesday), ref updating);
            UIHelpers.SetObjectTimeSlots(listBoxRoomThursday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Thursday), ref updating);
            UIHelpers.SetObjectTimeSlots(listBoxRoomFriday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Friday), ref updating);
            UIHelpers.SetObjectTimeSlots(listBoxRoomSaturday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Saturday), ref updating);

            ClearCheckedListRoomTypes();
            foreach (var roomType in selectedRoom.types)
            {
                checkedListRoomTypes.SetItemChecked((int) roomType, true);
            }
            numericUpDownCapacity.Value = selectedRoom.capacity;
            roomName.Text = selectedRoom.nameOrNumber;
        }

        private List<TimeSlot> GetRoomAvailability()
        {
            var mondayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxRoomMonday, DayOfWeek.Monday);
            var tuesdayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxRoomTuesday, DayOfWeek.Tuesday);
            var wednesdayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxRoomWednesday, DayOfWeek.Wednesday);
            var thursdayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxRoomThursday, DayOfWeek.Thursday);
            var fridayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxRoomFriday, DayOfWeek.Friday);
            var saturdayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxRoomSaturday, DayOfWeek.Saturday);

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
            var roomAvailability = GetRoomAvailability();

            HashSet<RoomType> roomTypes = new HashSet<RoomType>();
            foreach (int selectedIndex in checkedListRoomTypes.CheckedIndices)
            {
                roomTypes.Add((RoomType) selectedIndex);
            }

            Rooms.Add(new Room(roomTypes, (uint) numericUpDownCapacity.Value, roomAvailability, roomName.Text));

            bindingSource.ResetBindings(false);

            listBoxRooms.ClearSelected();
            listBoxRooms_SelectedIndexChanged(null, null);
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
                selectedRoom.availability = GetRoomAvailability();
            }
        }
    }
}
