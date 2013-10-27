using System;
using System.Collections.Generic;
using System.Linq;
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

        internal void InitializeBindingSources(BindingSource teachersBindingSource)
        {
            teachersBindingSource.DataSource = Teachers;

            listBoxTeachers.DisplayMember = "name";
            listBoxTeachers.DataSource = teachersBindingSource;
        }

        private Action refreshSubjectsTab;

        public List<Teacher> Teachers { get; private set; }

        private Teacher previouslySelectedTeacher = null;

        private void listBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTeacher = listBoxTeachers.SelectedItem as Teacher;

            if (selectedTeacher == null)
            {
                if (previouslySelectedTeacher != null)
                {
                    UpdateTeacher(previouslySelectedTeacher);
                }

                listBoxTeacherMonday.ClearSelected();
                listBoxTeacherTuesday.ClearSelected();
                listBoxTeacherWednesday.ClearSelected();
                listBoxTeacherThursday.ClearSelected();
                listBoxTeacherFriday.ClearSelected();
                listBoxTeacherSaturday.ClearSelected();

                textBoxTeacherName.Text = "";
                return;
            }

            previouslySelectedTeacher = selectedTeacher;

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
            Teachers.Add(new Teacher(null, null));
            UpdateTeacher(Teachers.Last());

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

            var teacherAvailability = new List<TimeSlot>();
            teacherAvailability.AddRange(mondayAvailableTime);
            teacherAvailability.AddRange(tuesdayAvailableTime);
            teacherAvailability.AddRange(wednesdayAvailableTime);
            teacherAvailability.AddRange(thursdayAvailableTime);
            teacherAvailability.AddRange(fridayAvailableTime);
            teacherAvailability.AddRange(saturdayAvailableTime);
            return teacherAvailability;
        }

        private void UpdateTeacher(Teacher teacher)
        {
            previouslySelectedTeacher = null;

            teacher.requirements = new Requirements(1, GetTeacherAvailability(), null);
            teacher.name = textBoxTeacherName.Text;

            listBoxTeachers.DisplayMember = "";
            listBoxTeachers.DisplayMember = "name";

            refreshSubjectsTab();
        }

        internal void SetSubjectsRefreshTeachers(Action action)
        {
            refreshSubjectsTab = action;
        }
    }
}
