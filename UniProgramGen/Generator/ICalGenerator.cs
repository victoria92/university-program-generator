using DDay.iCal;
using DDay.iCal.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UniProgramGen.Data;

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
            var t = new DBManager();
            t.tTestData();
            foreach(ScheduledTimeSlot[] solution in (t.solutions))
            {
            for (int i = 0; i < solution.Length; i++)
            {
                Event evt = iCal.Create<Event>();

                
                evt.Start = iCalDateTime.Today.AddHours((int)solution[i].timeSlot.StartHour);
                evt.Start.AddDays((int)(solution[i].timeSlot.Day));

                evt.End = iCalDateTime.Today.AddHours((int)solution[i].timeSlot.EndHour);
                evt.Start.AddDays((int)(solution[i].timeSlot.Day));

                evt.Summary = string.Join(", ", solution[i].groups.Select(g => g.name));

                evt.Location = solution[i].room.nameOrNumber;
            }
            }

            ISerializationContext ctx = new SerializationContext();
            ISerializerFactory factory = new DDay.iCal.Serialization.iCalendar.SerializerFactory();
            // Get a serializer for our object
            IStringSerializer serializer = factory.Build(iCal.GetType(), ctx) as IStringSerializer;

            string output = serializer.SerializeToString(iCal);
            var bytes = Encoding.UTF8.GetBytes(output);

            File.WriteAllBytes("solution.ics", bytes);
        }
    }
}
