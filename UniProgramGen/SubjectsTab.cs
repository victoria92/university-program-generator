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
    public partial class SubjectsTab : UserControl
    {
        public SubjectsTab()
        {
            InitializeComponent();

            Subjects = new List<Subject>();
            subjectsBindingSource.DataSource = Subjects;

            listBoxSubjects.DisplayMember = "name";
            listBoxSubjects.DataSource = subjectsBindingSource;
        }

        public void InitializeBindingSources(BindingSource teachersBindingSource)
        {
            LB_Teachers.DataSource = teachersBindingSource;
        }

        public BindingSource subjectsBindingSource = new BindingSource();

        private Subject previouslySelectedSubject = null;

        private void ClearCheckedListRoomTypes()
        {
            foreach (int selectedIndices in checkedListBoxRoomRequirements.CheckedIndices)
            {
                checkedListBoxRoomRequirements.SetItemChecked(selectedIndices, false);
            }
        }

        private void listBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSubject = listBoxSubjects.SelectedItem as Subject;
            if (selectedSubject == null)
            {
                if (previouslySelectedSubject != null)
                {
                    UpdateSubject(previouslySelectedSubject);
                    previouslySelectedSubject = null;
                }

                ClearCheckedListRoomTypes();
                LB_Teachers.ClearSelected();
                TB_SubjectName.Text = "";
                NUM_SubjectDuration.Value = 0;
                return;
            }

            previouslySelectedSubject = selectedSubject;

            ClearCheckedListRoomTypes();
            foreach (var roomType in selectedSubject.roomTypes)
            {
                checkedListBoxRoomRequirements.SetItemChecked((int)roomType, true);
            }

            LB_Teachers.ClearSelected();
            foreach (var teacher in selectedSubject.teachers)
            {
                LB_Teachers.SetSelected(LB_Teachers.Items.IndexOf(teacher), true);
            }

            TB_SubjectName.Text = selectedSubject.name;
            NUM_SubjectDuration.Value = selectedSubject.duration;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Subjects.Add(new Subject(null, null, null, 0));
            UpdateSubject(Subjects.Last());

            listBoxSubjects.ClearSelected();
            listBoxSubjects_SelectedIndexChanged(null, null);
        }

        private void UpdateSubject(Subject subject)
        {
            HashSet<RoomType> roomTypes = new HashSet<RoomType>();
            foreach (int selectedIndex in checkedListBoxRoomRequirements.CheckedIndices)
            {
                roomTypes.Add((RoomType)selectedIndex);
            }

            var teachers = new List<Teacher>();
            foreach (Teacher teacher in LB_Teachers.SelectedItems)
            {
                teachers.Add(teacher);
            }

            subject.duration = (uint) NUM_SubjectDuration.Value;
            subject.name = TB_SubjectName.Text;
            subject.roomTypes = roomTypes;
            subject.teachers = teachers;

            listBoxSubjects.DisplayMember = "";
            listBoxSubjects.DisplayMember = "name";
        }

        public List<Subject> Subjects { get; private set; }
    }
}
