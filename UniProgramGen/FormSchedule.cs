using System;
using System.IO;
using System.Windows.Forms;

namespace UniProgramGen
{
    public partial class FormSchedule : Form
    {
        public FormSchedule()
        {
            InitializeComponent();

            string curDir = Directory.GetCurrentDirectory();
            string exampleDataPath = String.Format("file:///{0}/../../datafiles/example_solution.html", curDir);
            this.webBrowser.Url = new Uri(exampleDataPath);
        }
    }
}
