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
            subject = new Subject(r, l, "Algebra", 2);
            Teacher teacher = new Teacher(null, "Dyadov");
            listBoxTeachers.DisplayMember = "Name";
            listBoxTeachers.DataSource = new List<Teacher> { teacher };
            listBoxSubjects.DisplayMember = "Name";
            listBoxSubjects.DataSource = new List<Subject> { subject };

        }

        private Subject subject;

        private void listBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject curItem = (Subject)listBoxSubjects.SelectedItem;
            subject = curItem;
        }

        private void textBoxSubjectName_TextChanged(object sender, EventArgs e)
        {
            string curItem = textBoxSubjectName.Text;
            subject.name = curItem;
        }

        private void listBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teacher curItem = (Teacher)listBoxTeachers.SelectedItem;
            subject.teachers.Add(curItem);
        }

        private void checkedListBoxRoomRequirements_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxRoomRequirements.Items.Count; i++)
            {
                subject.roomTypes.Add((RoomType)checkedListBoxRoomRequirements.Items[i]);
            }
        }

        private void numericUpDownDuration_ValueChanged(object sender, EventArgs e)
        {
            subject.duration = (UInt32)numericUpDownDuration.Value;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Subjects.Add(subject);
        }

        private List<Subject> subjects;

        public List<Subject> Subjects
        {
            get
            {
                return Subjects;
            }
            set
            {
                subjects = value;
                listBoxSubjects.DataSource = value;
            }
        }
    }
}
