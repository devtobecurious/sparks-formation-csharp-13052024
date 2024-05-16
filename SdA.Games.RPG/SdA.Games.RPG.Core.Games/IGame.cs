namespace SdA.Games.RPG.Core.GamePlays;

public delegate void UtiliserPartie(Game game);

public interface IGame
{
    event UtiliserPartie PartieDemarree;
    // event UtiliserPartie PartieFinie;
    event Action<Game> PartieFinie;

    void Launch();
}
