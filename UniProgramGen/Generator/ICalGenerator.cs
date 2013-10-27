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
        public string loadGeneratedJSON()
        {
            string json_output = File.ReadAllText(@"..\..\..\UniProgramGen\db\program_generated_example.js");
            return json_output;
        }

        public void readGeneratedJSON()
        {
            DDay.iCal.iCalendar iCal = new DDay.iCal.iCalendar();
        }
    }
}
