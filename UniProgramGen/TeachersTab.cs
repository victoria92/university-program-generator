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
    public partial class TeachersTab : UserControl
    {
        public TeachersTab()
        {
            InitializeComponent();

            teacher = new Teacher(null, "Dyadov");
            listBoxTeachers.DisplayMember = "Name";
            listBoxTeachers.DataSource = new Teacher[] {teacher};
            Teachers = new Teacher[] { teacher };
        }

        public Teacher[] Teachers
        {
            get;
            set;
        }

        private Teacher teacher;

        private void listBoxTeacherMonday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Monday, start_hour, start_hour + 1);
            teacher.requirements.availableTimeSlots.Add(time);
        }

        private void listBoxTeacherTuesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Tuesday, start_hour, start_hour + 1);
            teacher.requirements.availableTimeSlots.Add(time);
        }

        private void listBoxTeacherWednesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Wednesday, start_hour, start_hour + 1);
            teacher.requirements.availableTimeSlots.Add(time);
        }

        private void listBoxTeacherThursday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Thursday, start_hour, start_hour + 1);
            teacher.requirements.availableTimeSlots.Add(time);
        }

        private void listBoxTeacherFriday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Friday, start_hour, start_hour + 1);
            teacher.requirements.availableTimeSlots.Add(time);
        }

        private void listBoxTeacherSaturday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            uint start_hour = Convert.ToUInt32(curItem);
            TimeSlot time = new TimeSlot(DayOfWeek.Saturday, start_hour, start_hour + 1);
            teacher.requirements.availableTimeSlots.Add(time);
        }

        private void listBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teacher curItem = (Teacher)listBoxTeacherMonday.SelectedItem;
            teacher = curItem;
        }

        private void TeachersTab_Load(object sender, EventArgs e)
        {

        }
    }
}
