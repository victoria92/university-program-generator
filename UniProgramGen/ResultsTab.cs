using System;
using System.Collections.Generic;
using System.Linq;
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
            DumpExampleSolution();
            return;

            var generator = new Generator.ProgramGenerator();
            var program = generator.GenerateProgram(rooms, subjects, teachers, groups);
        }

        private void DumpExampleSolution()
        {
            Data.DBManager db = new DBManager();
            db.getTestData();
            var program = new Generator.ProgramGenerator().GenerateProgram(db.rooms, db.subjects, db.teachers, db.groups);
            var firstSolution = program.First();

            string firstSolutionJson = Newtonsoft.Json.JsonConvert.SerializeObject(firstSolution);
            System.IO.File.WriteAllText("../../datafiles/example_solution.json", firstSolutionJson);
        }
    }
}
