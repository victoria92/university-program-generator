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

            SortTeachersByWeight(teachers);
        }

        private void SortTeachersByWeight(List<Teacher> teachers)
        {
            teachers.Sort((teacher1, teacher2) =>
                {
                    var res = teacher1.requirements.weight - teacher2.requirements.weight;
                    return Math.Sign(res != 0 ? res :
                        teacher1.requirements.internalWeight - teacher2.requirements.internalWeight);
                });
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
