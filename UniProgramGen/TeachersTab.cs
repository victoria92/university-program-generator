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
            bindingSource.DataSource = Teachers;

            listBoxTeachers.DisplayMember = "name";
            listBoxTeachers.DataSource = bindingSource;
        }

        public List<Teacher> Teachers { get; private set; }

        public BindingSource bindingSource = new BindingSource();

        private void listBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTeacher = listBoxTeachers.SelectedItem as Teacher;

            if (selectedTeacher == null)
            {
                listBoxTeacherMonday.ClearSelected();
                listBoxTeacherTuesday.ClearSelected();
                listBoxTeacherWednesday.ClearSelected();
                listBoxTeacherThursday.ClearSelected();
                listBoxTeacherFriday.ClearSelected();
                listBoxTeacherSaturday.ClearSelected();

                textBoxTeacherName.Text = "";
                return;
            }

            UIHelpers.SetObjectTimeSlots(listBoxTeacherMonday, selectedTeacher.requirements.availableTimeSlots.Where(t => t.Day == DayOfWeek.Monday));
            UIHelpers.SetObjectTimeSlots(listBoxTeacherTuesday, selectedTeacher.requirements.availableTimeSlots.Where(t => t.Day == DayOfWeek.Tuesday));
            UIHelpers.SetObjectTimeSlots(listBoxTeacherWednesday, selectedTeacher.requirements.availableTimeSlots.Where(t => t.Day == DayOfWeek.Wednesday));
            UIHelpers.SetObjectTimeSlots(listBoxTeacherThursday, selectedTeacher.requirements.availableTimeSlots.Where(t => t.Day == DayOfWeek.Thursday));
            UIHelpers.SetObjectTimeSlots(listBoxTeacherFriday, selectedTeacher.requirements.availableTimeSlots.Where(t => t.Day == DayOfWeek.Friday));
            UIHelpers.SetObjectTimeSlots(listBoxTeacherSaturday, selectedTeacher.requirements.availableTimeSlots.Where(t => t.Day == DayOfWeek.Saturday));

            textBoxTeacherName.Text = selectedTeacher.name;
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            List<TimeSlot> teacherAvailability = GetTeacherAvailability();

            Teachers.Add(new Teacher(new Requirements(1, teacherAvailability, null), textBoxTeacherName.Text));

            bindingSource.ResetBindings(false);

            listBoxTeachers.ClearSelected();
            listBoxTeachers_SelectedIndexChanged(null, null);
        }

        private List<TimeSlot> GetTeacherAvailability()
        {
            var mondayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxTeacherMonday, DayOfWeek.Monday);
            var tuesdayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxTeacherTuesday, DayOfWeek.Tuesday);
            var wednesdayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxTeacherWednesday, DayOfWeek.Wednesday);
            var thursdayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxTeacherThursday, DayOfWeek.Thursday);
            var fridayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxTeacherFriday, DayOfWeek.Friday);
            var saturdayAvailableTime = UIHelpers.GetListBoxRoomDayTimeSlot(listBoxTeacherSaturday, DayOfWeek.Saturday);

            List<TimeSlot> teacherAvailability = new List<TimeSlot>();
            teacherAvailability.AddRange(mondayAvailableTime);
            teacherAvailability.AddRange(tuesdayAvailableTime);
            teacherAvailability.AddRange(wednesdayAvailableTime);
            teacherAvailability.AddRange(thursdayAvailableTime);
            teacherAvailability.AddRange(fridayAvailableTime);
            teacherAvailability.AddRange(saturdayAvailableTime);
            return teacherAvailability;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
