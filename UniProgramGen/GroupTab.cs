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
    public partial class GroupTab : UserControl
    {
        public GroupTab()
        {
            InitializeComponent();
            Group gr = new Group(null, 20, "Group_6");
            listBoxGroups.DisplayMember = "Name";
            listBoxGroups.DataSource = new List<Group> { gr };
        }

        Group group;

        private void GroupTab_Load(object sender, EventArgs e)
        {

        }

        private void groupName_TextChanged(object sender, EventArgs e)
        {
            string curItem = groupName.Text;
            group.name = curItem;
        }

        private void listBoxSubjectsOfGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject curItem = (Subject)listBoxSubjectsOfGroups.SelectedItem;
            group.horarium.Add(curItem);
        }

        private void numericUpDownStudents_ValueChanged(object sender, EventArgs e)
        {
            group.size = (UInt32)numericUpDownStudents.Value;
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group curItem = (Group)listBoxSubjectsOfGroups.SelectedItem;
            group = curItem;
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            Groups.Add(group);
        }

        public List<Group> Groups
        {
            get
            {
                return Groups;
            }
            set
            {
                Groups = value;
                listBoxGroups.DataSource = value;
            }
        }
    }
}
