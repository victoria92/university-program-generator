﻿using System;
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
            subjectsTab1.Subjects = state.Subjects;
            teachersTab1.Teachers = state.Teachers;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
