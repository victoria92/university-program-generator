using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UniProgramGen.Data;

namespace UniProgramGen
{
    public partial class ResultsTab : UserControl
    {
        public ResultsTab()
        {
            InitializeComponent();
        }

        private List<Teacher> teachers;
        private List<Room> rooms;
        private List<Group> groups;
        private List<Subject> subjects;

        internal void InitializeBindingSources(
            BindingSource teachersBS,
            BindingSource roomsBS,
            BindingSource groupsBS,
            BindingSource subjectsBS)
        {
            teachers = (List<Teacher>)teachersBS.DataSource;
            rooms = (List<Room>)roomsBS.DataSource;
            groups = (List<Group>)groupsBS.DataSource;
            subjects = (List<Subject>)subjectsBS.DataSource;

            listBoxTeachers.DataSource = teachersBS;
            listBoxRooms.DataSource = roomsBS;
            listBoxGroups.DataSource = groupsBS;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //new Generator.ProgramGenerator().GenerateProgram();
        }
    }
}
