using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UniProgramGen.Data;

namespace UniProgramGen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            State state = State.ExampleData();
            subjectsTab1.Subjects = state.Subjects;
        }

        /*private void listBoxTeacherMonday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxTeacherTuesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxTeacherWednesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();
            
        }

        private void listBoxTeacherThursday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxTeacherFriday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxTeacherSaturday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxRoomMonday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxRoomTuesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxRoomWednesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxRoomThursday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxRoomFriday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxRoomSaturday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxGroupMonday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxGroupTuesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxGroupWednesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxGroupThursday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxGroupFriday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }

        private void listBoxGroupSaturday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxTeacherMonday.SelectedItem.ToString();

        }*/

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
