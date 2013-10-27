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
            HashSet<RoomType> r = new HashSet<RoomType>();
        }

        private void listBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            NUM_SubjectDuration.Value = CurrentSubject.duration;
            TB_SubjectName.Text = CurrentSubject.name;
        }

        private void NUM_SubjectDuration_ValueChanged(object sender, EventArgs e)
        {
            CurrentSubject.duration = (uint) NUM_SubjectDuration.Value;
        }

        private void TB_SubjectName_TextChanged(object sender, EventArgs e)
        {
            CurrentSubject.name = TB_SubjectName.Text;
            RefreshSubjects();
        }

        private void LB_Teachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTechers = LB_Teachers.SelectedItems.Cast<Teacher>();
            CurrentSubject.teachers.RemoveAll(t => true);
            CurrentSubject.teachers.AddRange(selectedTechers);
        }

        private void checkedListBoxRoomRequirements_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = checkedListBoxRoomRequirements.SelectedIndex;
            //CheckState state = checkedListBoxRoomRequirements.GetItemCheckState(index);
            //if (state == CheckState.Unchecked)
            //{
            //    subject.roomTypes.Add((RoomType)index);
            //    checkedListBoxRoomRequirements.SetItemCheckState(index, CheckState.Checked);
            //}
            //else
            //{
            //    subject.roomTypes.Remove((RoomType)index);
            //    checkedListBoxRoomRequirements.SetItemCheckState(index, CheckState.Unchecked);
            //}
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var roomTypes = new HashSet<RoomType>();
            var teachers = new List<Teacher>();
            subjects.Add(new Subject(roomTypes, teachers, "New", 2));
            RefreshSubjects();
        }

        private List<Subject> subjects;
        private List<Teacher> teachers;

        public List<Subject> Subjects
        {
            get
            {
                return subjects;
            }
            set
            {
                subjects = value;
                listBoxSubjects.DataSource = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }
            set
            {
                teachers = value;
                LB_Teachers.DataSource = value;
            }
        }

        public Subject CurrentSubject
        {
            get
            {
                return (Subject)listBoxSubjects.SelectedItem;
            }
        }

        private void RefreshSubjects()
        {
            string displayMember = listBoxSubjects.DisplayMember;
            listBoxSubjects.DisplayMember = null;
            listBoxSubjects.DisplayMember = displayMember;
        }
    }
}
