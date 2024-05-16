
using SdA.Games.RPG.Core.Models.Characters;

namespace SdA.Games.RPG.Core.GamePlays;

public enum Status
{
    Draft,
    Started,
    Killed,
    Finished
}

public class Game : IGame
{
    public event UtiliserPartie PartieDemarree;
    public event Action<Game> PartieFinie;

    private Status status = Status.Draft;
    private BaseCombat combat = new DeathMatchCombat();


    public void Launch()
    {
        this.status = Status.Started;
        this.PartieDemarree?.Invoke(this);

        combat.CombatDemarre += attaquants =>
        {
            Console.WriteLine("Combat démarré");
        };

        combat.CombatFini += attaquant =>
        {
            this.PartieFinie?.Invoke(this);
        };

        combat.Lancer(new Personnage("Aragorn"), new Orc());

        this.status = Status.Finished;
    }
}
