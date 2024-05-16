namespace SdA.Games.RPG.Core.Presentations
{
    public class Grid(int nbRows, int nbCols, AfficherGrid? afficherGrid = null)
    {
        /// <summary>
        /// lecture seul de référence : une seule et unique
        /// </summary>
        private readonly List<Cell> cells = new List<Cell>();

        public void Add(Cell cell)
        {
            this.cells.Add(cell);
        }

        public void Prepare()
        {
            this.Prepare(nbRows, nbCols);
        }

        public void Prepare(int nbRows = 10, int nbCols = 10)
        {
            this.cells.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    this.Add(new Cell(i, j));
                }
            }
        }

        public string Display()
        {
            string content = string.Empty;

            //foreach (Cell cell in this.cells)
            //{
            //    content += cell;
            //}
            for (int i = 0; i < nbRows; i++)
            {
                for (int j = 0; j < nbRows; j++)
                {
                    Cell cell = this.cells.Where(item => item.I == i && item.J == j)
                                          .Single();
                    content += cell;
                }
                content += "\n";
            }


            afficherGrid?.Invoke(this, content);

            return content;
        }
    }
}
