using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UniProgramGen.Data;
using UniProgramGen.Generator;
using UniProgramGen.Helpers;

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

        private PersonalSchedule personalSchedule;

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
            personalSchedule = new Helpers.PersonalSchedule(schedules.First());
            RefreshData();
        }

        private void RefreshData()
        {
            listBoxTeachers.DisplayMember = "";
            listBoxRooms.DisplayMember = "";
            listBoxGroups.DisplayMember = "";

            listBoxTeachers.DisplayMember = "name";
            listBoxRooms.DisplayMember = "nameOrNumber";
            listBoxGroups.DisplayMember = "name";
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

            MessageBox.Show("Фалшивите данни са заредени");
        }

        private void dumpFirstSchedule(string filename, object schedule)
        {
            string firstSolutionJson = Newtonsoft.Json.JsonConvert.SerializeObject(schedule, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(filename, firstSolutionJson);
        }

        private void listBoxTeachers_DoubleClick(object sender, EventArgs e)
        {
            Teacher selectedTeacher = (Teacher)listBoxTeachers.SelectedItem;
            listBoxTeachers.SelectedItem = null;
            var selectedSchedule = personalSchedule.GetTeacherProgram(selectedTeacher);

            DisplaySchedule(selectedSchedule);
        }

        private void listBoxRooms_DoubleClick(object sender, EventArgs e)
        {
            Room selectedRoom = (Room)listBoxRooms.SelectedItem;
            listBoxTeachers.SelectedItem = null;
            var selectedSchedule = personalSchedule.GetRoomProgram(selectedRoom);

            DisplaySchedule(selectedSchedule);
        }

        private void listBoxGroups_DoubleClick(object sender, EventArgs e)
        {
            Group selectedGroup = (Group)listBoxGroups.SelectedItem;
            listBoxTeachers.SelectedItem = null;
            var selectedSchedule = personalSchedule.GetGroupProgram(selectedGroup);

            DisplaySchedule(selectedSchedule);
        }

        private void DisplaySchedule(IEnumerable<ScheduledTimeSlot> schedule)
        {
            dumpFirstSchedule("../../datafiles/example_solution.json", schedule);

            // TODO: fix!!!
            //system("ruby ../../../dragons/scripts/run.rb ../../datafiles/example_solution.json");

            FormSchedule formSchedule = new FormSchedule();
            formSchedule.ShowDialog(this);
        }

        [System.Runtime.InteropServices.DllImport("msvcrt.dll")]
        private static extern int system(String command);

        private void button1_Click(object sender, EventArgs e)
        {
            var iCalGen = new ICalGenerator();
            iCalGen.ExportSolution();
            string pr = System.Environment.GetEnvironmentVariable("PROGRAMFILES");
            System.Diagnostics.Process.Start(pr + @"\Microsoft Office 15\root\office15\OUTLOOK.EXE", "/vcal solution.ics");
        }
    }
}
