namespace SdA.Games.RPG.Core.Presentations
{
    public class Cell(int i, int j)
    {

        public Cell() : this(0, 0)
        {

        }

        public override string ToString()
        {
            return "|_|";
        }
        public int I { get; init; } = i;
        public int J { get; init; } = j;
    }
}
