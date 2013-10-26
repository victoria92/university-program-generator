using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniProgramGen.Data;

namespace UniProgramGen.Generator
{
    public class ProgramGenerator
    {
        public void GenerateProgram(List<Room> rooms, List<Subject> subjects, List<Teacher> teachers, List<Group> groups)
        {
            CalculateRequirementInternalWeights(rooms.Count, teachers.Select(t => t.requirements));

            //teachers.Sort((teacher1, teacher2) => teacher1.requirements < teacher2.requirements);
        }

        private void CalculateRequirementInternalWeights(int roomsLength, IEnumerable<Requirements> requirements)
        {
            foreach (var requirement in requirements)
            {
                requirement.CalculateInternalWeight(roomsLength);
            }
        }
    }

}
