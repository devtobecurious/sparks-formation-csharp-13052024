using SdA.Games.RPG.Core.Presentations;

AfficherGrid afficherGrid = (grid, content) =>
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(content);
    Console.ForegroundColor = ConsoleColor.White;
};
Grid grid = new Grid(10, 10, afficherGrid);

grid.Prepare();
grid.Display();

// Mieux vaut le faire dans la grid, ça appartient en fait à la Grid
//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        grid.Add(new Cell());
//    }
//}

