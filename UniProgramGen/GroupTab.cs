using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UniProgramGen.Data;

namespace UniProgramGen
{
    public partial class GroupTab : UserControl
    {
        public GroupTab()
        {
            InitializeComponent();
            bindingSource.DataSource = Groups;

            listBoxSubjectsOfGroups.DisplayMember = "name";
            listBoxSubjectsOfGroups.DataSource = bindingSource;
        }

        public List<Group> Groups { get; private set; }

        private BindingSource bindingSource = new BindingSource();

        private Group previouslySelectedGroup = null;

        private void listBoxSubjectsOfGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGroup = listBoxGroups.SelectedItem as Group;

            if (selectedGroup == null)
            {
                if (previouslySelectedGroup != null)
                {
                    UpdateGroup(previouslySelectedGroup);
                    previouslySelectedGroup = null;
                }

                listBoxSubjectsOfGroups.ClearSelected();
                numericUpDownStudents.Value = 0;
                groupName.Text = "";
                return;
            }

            previouslySelectedGroup = selectedGroup;

            listBoxSubjectsOfGroups.ClearSelected();
            foreach (var subject in selectedGroup.horarium)
            {
                var index = listBoxSubjectsOfGroups.Items.IndexOf(subject);
                listBoxSubjectsOfGroups.SetSelected(index, true);
            }

            numericUpDownStudents.Value = selectedGroup.size;
            groupName.Text = selectedGroup.name;
        }

        private void UpdateGroup(Group group)
        {
            var subjects = new List<Subject>();
            foreach (Subject subject in listBoxSubjectsOfGroups.SelectedItems)
            {
                subjects.Add(subject);
            }

            group.horarium = subjects;
            group.name = groupName.Text;
            group.size = (uint) numericUpDownStudents.Value;

            listBoxSubjectsOfGroups.DisplayMember = "";
            listBoxSubjectsOfGroups.DisplayMember = "name";
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            Groups.Add(new Group(null, 0, null));
            UpdateGroup(Groups.Last());

            listBoxSubjectsOfGroups.ClearSelected();
            listBoxSubjectsOfGroups_SelectedIndexChanged(null, null);
        }
    }
}
