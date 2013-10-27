using System;
using System.Collections.Generic;
using System.Linq;
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

            listBoxRooms.DisplayMember = "nameOrNumber";
            listBoxRooms.DataSource = bindingSource;
        }

        public List<Room> Rooms { get; private set; }

        private BindingSource bindingSource = new BindingSource();

        private Room previouslySelectedRoom = null;

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
                if (previouslySelectedRoom != null)
                {
                    UpdateRoom(previouslySelectedRoom);
                    previouslySelectedRoom = null;
                }

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

            previouslySelectedRoom = selectedRoom;

            UIHelpers.SetObjectTimeSlots(listBoxRoomMonday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Monday));
            UIHelpers.SetObjectTimeSlots(listBoxRoomTuesday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Tuesday));
            UIHelpers.SetObjectTimeSlots(listBoxRoomWednesday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Wednesday));
            UIHelpers.SetObjectTimeSlots(listBoxRoomThursday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Thursday));
            UIHelpers.SetObjectTimeSlots(listBoxRoomFriday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Friday));
            UIHelpers.SetObjectTimeSlots(listBoxRoomSaturday, selectedRoom.availability.Where(t => t.Day == DayOfWeek.Saturday));

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
            Rooms.Add(new Room(null, 0, null, null));
            UpdateRoom(Rooms.Last());

            listBoxRooms.ClearSelected();
            listBoxRooms_SelectedIndexChanged(null, null);
        }

        private void UpdateRoom(Room room)
        {
            var roomAvailability = GetRoomAvailability();

            HashSet<RoomType> roomTypes = new HashSet<RoomType>();
            foreach (int selectedIndex in checkedListRoomTypes.CheckedIndices)
            {
                roomTypes.Add((RoomType)selectedIndex);
            }

            room.availability = roomAvailability;
            room.capacity = (uint) numericUpDownCapacity.Value;
            room.nameOrNumber = roomName.Text;
            room.types = roomTypes;

            listBoxRooms.DisplayMember = "";
            listBoxRooms.DisplayMember = "nameOrNumber";
        }
    }
}
