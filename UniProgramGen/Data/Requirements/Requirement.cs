
namespace UniProgramGen.Data
{
    public abstract class Requirement
    {
        public readonly double weight;

        public abstract bool isSatisfied();
    }
}
