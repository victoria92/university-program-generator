using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniProgramGen
{
    public partial class ResultsTab : UserControl
    {
        public ResultsTab()
        {
            InitializeComponent();
        }

        internal void InitializeBindingSources(
            BindingSource teachersBS,
            BindingSource roomsBS,
            BindingSource groupsBS)
        {
            listBoxTeachers.DataSource = teachersBS;
            listBoxRooms.DataSource = roomsBS;
            listBoxGroups.DataSource = groupsBS;
        }
    }
}
