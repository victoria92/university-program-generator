using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UniProgramGen.Generator
{
    public class ICalGenerator
    {
        
        public ICalGenerator()
        {

        }

        public void ExportSolution()
        {
            DDay.iCal.iCalendar iCal = new DDay.iCal.iCalendar();
        }
    }
}
