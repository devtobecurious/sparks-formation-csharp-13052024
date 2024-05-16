
using SdA.Games.RPG.Core.GamePlays;

UtiliserPartie partieDemarree = game =>
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("$$$$$ DEMARRAGE PARTIE $$$$$");

    Console.ForegroundColor = ConsoleColor.White;
};


Game game = new();

game.PartieDemarree += partieDemarree;
// game.PartieDemarree += partieDemarree; // Ici, ça va aussi exécuter la méthode, même si elle porte le même nom
game.PartieDemarree += game =>
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Enregistrement en base de données ....");
    Console.ForegroundColor = ConsoleColor.White;
};
//game.PartieDemarree -= partieDemarree;
//game.PartieDemarree -= partieDemarree;

game.Launch();
