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

            Teachers = new List<Teacher>();
        }

        public List<Teacher> Teachers { get; private set; }

        private bool updating = false;

        private void listBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTeacher = listBoxTeachers.SelectedItem as Teacher;
            if (selectedTeacher != null)
            {
                listBoxTeacherMonday.ClearSelected();
                listBoxTeacherTuesday.ClearSelected();
                listBoxTeacherWednesday.ClearSelected();
                listBoxTeacherThursday.ClearSelected();
                listBoxTeacherFriday.ClearSelected();
                listBoxTeacherSaturday.ClearSelected();
                textBoxTeacherName.Text = "";
            } 
        }

        private void listBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FillTeacherTimeTable(Teacher teacher)
        {
            var mondayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherMonday, DayOfWeek.Monday);
            var tuesdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherTuesday, DayOfWeek.Tuesday);
            var wednesdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherWednesday, DayOfWeek.Wednesday);
            var thursdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherMonday, DayOfWeek.Thursday);
            var fridayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherTuesday, DayOfWeek.Friday);
            var saturdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherWednesday, DayOfWeek.Saturday);

            teacher.requirements.availableTimeSlots.AddRange(mondayAvailableTime);
            teacher.requirements.availableTimeSlots.AddRange(tuesdayAvailableTime);
            teacher.requirements.availableTimeSlots.AddRange(wednesdayAvailableTime);
            teacher.requirements.availableTimeSlots.AddRange(thursdayAvailableTime);
            teacher.requirements.availableTimeSlots.AddRange(fridayAvailableTime);
            teacher.requirements.availableTimeSlots.AddRange(saturdayAvailableTime);
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            var mondayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherMonday, DayOfWeek.Monday);
            var tuesdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherTuesday, DayOfWeek.Monday);
            var wednesdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherWednesday, DayOfWeek.Monday);
            var thursdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherThursday, DayOfWeek.Monday);
            var fridayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherFriday, DayOfWeek.Monday);
            var saturdayAvailableTime = UIHelpers.getListBoxRoomDayTimeSlot(listBoxTeacherSaturday, DayOfWeek.Monday);

            List<TimeSlot> teacherAvailability = new List<TimeSlot>();
            teacherAvailability.AddRange(mondayAvailableTime);
            teacherAvailability.AddRange(mondayAvailableTime);
            teacherAvailability.AddRange(mondayAvailableTime);
            teacherAvailability.AddRange(mondayAvailableTime);
            teacherAvailability.AddRange(mondayAvailableTime);
            teacherAvailability.AddRange(mondayAvailableTime);

            Teachers.Add(new Teacher(new Requirements(1, teacherAvailability, null), textBoxTeacherName.Text));

            listBoxTeachers.DisplayMember = "name";
            listBoxTeachers.DataSource = Teachers;
        }
    }
}
