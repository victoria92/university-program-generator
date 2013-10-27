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

            TAB_Subjects.InitializeBindingSources(TABS_Teachers.bindingSource);
            TABS_Teachers.SetSubjectsRefreshTeachers(TAB_Subjects.RefreshTeachers);

            TAB_Groups.InitializeBindingSources(TAB_Subjects.subjectsBindingSource);
            TAB_Subjects.SetSubjectsRefreshTeachers(TAB_Groups.RefreshSubjects);
        }
    }
}
