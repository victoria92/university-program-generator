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
            List<RoomType> r = new List<RoomType>();
            subject = new Subject(r, l, "Algebra", 2);
            listBoxTeachers.DisplayMember = "Name";
            listBoxTeachers.DataSource = new Subject[] { subject };

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

        }

        private void checkedListBoxRoomRequirements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownDuration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
