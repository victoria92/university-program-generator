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

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private List<TimeSlot> getListBoxRoomDayTimeSlot(ListBox listBox, DayOfWeek dayOfWeek)
        {
            uint startHour = 0;
            uint endHour = 0;
            uint previousHour = 0;

            List<TimeSlot> result = new List<TimeSlot>();

            foreach (string selectedItem in listBox.SelectedItems)
            {
                uint hour = Convert.ToUInt32(selectedItem.Remove(selectedItem.Length - 3));
                if (hour != previousHour + 1) // new Timeslot
                {
                    if (startHour != 0)
                    {
                        result.Add(new TimeSlot(dayOfWeek, startHour, endHour));
                    }
                    startHour = hour;
                }

                endHour = hour + 1;
                previousHour = hour;
            }
            return result;
        }

        public List<Room> Rooms { get; private set; }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            var mondayAvailableTime = getListBoxRoomDayTimeSlot(listBoxRoomMonday, DayOfWeek.Monday);
            var tuesdayAvailableTime = getListBoxRoomDayTimeSlot(listBoxRoomTuesday, DayOfWeek.Monday);
            var wednesdayAvailableTime = getListBoxRoomDayTimeSlot(listBoxRoomWednesday, DayOfWeek.Monday);
            var thursdayAvailableTime = getListBoxRoomDayTimeSlot(listBoxRoomThursday, DayOfWeek.Monday);
            var fridayAvailableTime = getListBoxRoomDayTimeSlot(listBoxRoomFriday, DayOfWeek.Monday);
            var saturdayAvailableTime = getListBoxRoomDayTimeSlot(listBoxRoomSaturday, DayOfWeek.Monday);

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
