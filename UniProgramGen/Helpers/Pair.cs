
namespace UniProgramGen.Helpers
{
    public class Pair<T, U>
    {
        public readonly T first;
        public readonly U second;

        public Pair(T first, U second)
        {
            this.first = first;
            this.second = second;
        }
    }
}
