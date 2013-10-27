using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UniProgramGen.Generator
{
    public class ICalGenerator
    {
        byte[] buffer;
        
        public ICalGenerator()
        {

        }

        public void readGeneratedJSON()
        {
            string json_output = File.ReadAllText(@"db\program_is.json");
            Console.WriteLine(json_output);

        }
    }
}
