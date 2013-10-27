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

            BindingSource subjectsBindingSource = new BindingSource();
            BindingSource teachersBindingSource = new BindingSource();
            BindingSource roomsBindingSource = new BindingSource();
            BindingSource groupsBindingSource = new BindingSource();

            tabSubjects.InitializeBindingSources(subjectsBindingSource, teachersBindingSource);
            tabTeachers.SetSubjectsRefreshTeachers(tabSubjects.RefreshTeachers);

            tabGroups.InitializeBindingSources(groupsBindingSource, subjectsBindingSource);
            tabSubjects.SetSubjectsRefreshTeachers(tabGroups.RefreshSubjects);

            tabTeachers.InitializeBindingSources(teachersBindingSource);

            tabRooms.InitializeBindingSources(roomsBindingSource);

            tabResults.InitializeBindingSources(
                teachersBindingSource,
                roomsBindingSource,
                groupsBindingSource,
                subjectsBindingSource);
        }
    }
}
