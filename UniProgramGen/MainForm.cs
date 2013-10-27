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

            BindingSource subjectsBindingSource = new BindingSource();
            BindingSource teachersBindingSource = new BindingSource();
            BindingSource roomsBindingSource = new BindingSource();
            BindingSource groupsBindingSource = new BindingSource();

            TAB_Subjects.InitializeBindingSources(subjectsBindingSource, teachersBindingSource);
            TABS_Teachers.SetSubjectsRefreshTeachers(TAB_Subjects.RefreshTeachers);

            TAB_Groups.InitializeBindingSources(groupsBindingSource, subjectsBindingSource);
            TAB_Subjects.SetSubjectsRefreshTeachers(TAB_Groups.RefreshSubjects);

            TABS_Teachers.InitializeBindingSources(teachersBindingSource);

            TAB_Rooms.InitializeBindingSources(roomsBindingSource);
        }
    }
}
