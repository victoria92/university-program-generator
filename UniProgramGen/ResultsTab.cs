using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UniProgramGen.Data;
using UniProgramGen.Generator;

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
            var schedules = new ProgramGenerator().GenerateProgram(rooms, subjects, teachers, groups);
            var schedule = schedules.First();

            string firstSolutionJson = Newtonsoft.Json.JsonConvert.SerializeObject(schedule, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("../../datafiles/example_solution.json", firstSolutionJson);
        }

        private void buttonDummyData_Click(object sender, EventArgs e)
        {
            Data.DBManager db = new DBManager();
            db.initInputData();

            teachers.RemoveAll(x => true);
            teachers.AddRange(db.teachers);
            rooms.RemoveAll(x => true);
            rooms.AddRange(db.rooms);
            subjects.RemoveAll(x => true);
            subjects.AddRange(db.subjects);
            groups.RemoveAll(x => true);
            groups.AddRange(db.groups);

            var program = db.solutions;
            
        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            listBoxTeachers.DisplayMember = "";
            listBoxRooms.DisplayMember = "";
            listBoxGroups.DisplayMember = "";

            listBoxTeachers.DisplayMember = "name";
            listBoxRooms.DisplayMember = "nameOrNumber";
            listBoxGroups.DisplayMember = "name";
        }

        private void listBoxTeachers_Click(object sender, EventArgs e)
        {
            Teacher selectedTeacher = (Teacher)listBoxTeachers.SelectedItem;
            // Helpers.PersonalSchedule personalSchedule = new Helpers.PersonalSchedule(); WIP
        }
    }
}
