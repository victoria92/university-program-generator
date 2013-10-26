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
            TimeSlot time = new TimeSlot(DayOfWeek.Monday, 7, 9);
            List<TimeSlot> available = new List<TimeSlot> { time };
            Room r = new Room(null, 20, available, "200");
            listBoxRooms.DisplayMember = "NameOrNumber";
            listBoxRooms.DataSource = new List<Room> { r };
        }

        Room room;

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            Room curItem = (Room)listBoxRooms.SelectedItem;
            room = curItem;
        }

        private void roomName_TextChanged(object sender, EventArgs e)
        {
            string curItem = roomName.Text;
            room.nameOrNumber = curItem;
        }

        private void checkedListRoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListRoomTypes.Items.Count; i++)
            {
                room.types.Add((RoomType)checkedListRoomTypes.Items[i]);
            }
        }

        private void numericUpDownCapacity_ValueChanged(object sender, EventArgs e)
        {
            room.capacity = (UInt32)numericUpDownCapacity.Value;
        }

        private void listBoxRoomMonday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxRoomMonday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Monday, start_hour, start_hour + 1);
            room.availability.Add(time);
        }

        private void listBoxRoomTuesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxRoomTuesday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Tuesday, start_hour, start_hour + 1);
            room.availability.Add(time);
        }

        private void listBoxRoomWednesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxRoomWednesday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Wednesday, start_hour, start_hour + 1);
            room.availability.Add(time);
        }

        private void listBoxRoomThursday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxRoomThursday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Thursday, start_hour, start_hour + 1);
            room.availability.Add(time);
        }

        private void listBoxRoomFriday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxRoomFriday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Friday, start_hour, start_hour + 1);
            room.availability.Add(time);
        }

        private void listBoxRoomSaturday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxRoomSaturday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Saturday, start_hour, start_hour + 1);
            room.availability.Add(time);
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            Rooms.Add(room);
        }

        public List<Room> Rooms
        {
            get
            {
                return Rooms;
            }
            set
            {
                Rooms = value;
                listBoxRooms.DataSource = value;
            }
        }
    }
}
