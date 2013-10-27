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
            List<Teacher> l = new List<Teacher>();
            HashSet<RoomType> r = new HashSet<RoomType>();
            Teacher teacher = new Teacher(null, "Dyadov");
            listBoxTeachers.DisplayMember = "Name";
            listBoxTeachers.DataSource = new List<Teacher> { teacher };
            listBoxSubjects.DisplayMember = "Name";
        }

        private void listBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject curItem = (Subject)listBoxSubjects.SelectedItem;
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
        }

        private List<Subject> subjects;

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
    }
}
