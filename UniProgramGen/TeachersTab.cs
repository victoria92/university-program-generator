using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UniProgramGen.Data;

namespace UniProgramGen
{
    public partial class TeachersTab : UserControl
    {
        public TeachersTab()
        {
            InitializeComponent();
        }

        private Teacher t;

        private void listBoxTeacherMonday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            int start_hour = Convert.ToInt32(curItem);
            t.requirements.timeRequirements.append(TimeSlot(DayOfWeek.Monday, start_hour, start_hour + 1));
        }

        private void listBoxTeacherTuesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            int start_hour = Convert.ToInt32(curItem);
            t.requirements.timeRequirements.append(TimeSlot(DayOfWeek.Tuesday, start_hour, start_hour + 1));
        }

        private void listBoxTeacherWednesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            int start_hour = Convert.ToInt32(curItem);
            t.requirements.timeRequirements.append(TimeSlot(DayOfWeek.Wednesday, start_hour, start_hour + 1));
        }

        private void listBoxTeacherThursday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            int start_hour = Convert.ToInt32(curItem);
            t.requirements.timeRequirements.append(TimeSlot(DayOfWeek.Thursday, start_hour, start_hour + 1));
        }

        private void listBoxTeacherFriday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            int start_hour = Convert.ToInt32(curItem);
            t.requirements.timeRequirements.append(TimeSlot(DayOfWeek.Friday, start_hour, start_hour + 1));
        }

        private void listBoxTeacherSaturday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            int start_hour = Convert.ToInt32(curItem);
            t.requirements.timeRequirements.append(TimeSlot(DayOfWeek.Saturday, start_hour, start_hour + 1));
        }

        private void listBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
