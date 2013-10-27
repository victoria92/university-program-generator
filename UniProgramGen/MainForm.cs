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
            TAB_Subjects.Subjects = state.Subjects;
            TAB_Subjects.Teachers = state.Teachers;
        }
    }
}
