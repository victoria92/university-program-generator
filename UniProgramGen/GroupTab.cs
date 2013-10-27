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

            Groups = new List<Group>();
        }

        public List<Group> Groups { get; private set; }

        private Group previouslySelectedGroup = null;

        public void RefreshSubjects()
        {
            listBoxSubjectsOfGroups.DisplayMember = "";
            listBoxSubjectsOfGroups.DisplayMember = "name";
        }

        public void InitializeBindingSources(BindingSource groupsBindingSource, BindingSource subjectsBindingSource)
        {
            groupsBindingSource.DataSource = Groups;

            listBoxGroups.DisplayMember = "name";
            listBoxGroups.DataSource = groupsBindingSource;

            listBoxSubjectsOfGroups.DisplayMember = "name";
            listBoxSubjectsOfGroups.DataSource = subjectsBindingSource;
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
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

            listBoxGroups.DisplayMember = "";
            listBoxGroups.DisplayMember = "name";
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            Groups.Add(new Group(null, 0, null));
            UpdateGroup(Groups.Last());

            listBoxGroups.ClearSelected();
            listBoxGroups_SelectedIndexChanged(null, null);
        }
    }
}
