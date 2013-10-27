using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UniProgramGen.Helpers
{
    public static class UIHelpers
    {
        public static List<TimeSlot> getListBoxRoomDayTimeSlot(ListBox listBox, DayOfWeek dayOfWeek)
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
    }
}
