using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UniProgramGen.Data;
using UniProgramGen.Helpers;

namespace UniProgramGen
{
    public partial class TeachersTab : UserControl
    {
        public TeachersTab()
        {
            InitializeComponent();

            listBoxTeachers.DisplayMember = "Name";
        }

        public List<Teacher> Teachers { get; set; }

        private void listBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
