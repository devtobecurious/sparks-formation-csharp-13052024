using SdA.Games.RPG.Core.Models.Characters;

BaseCombat combat = new DeathMatchCombat();

DemarrerCombat(combat);
// Personnage.__NBInstances : variable globale à la classe

void DemarrerCombat(BaseCombat combat)
{
    var perso1 = new Personnage("Aragorn");
    var perso2 = new Personnage("Sauron");
    var gagnant = combat.Lancer(perso1, perso2);

    Console.WriteLine("Le gagnant de ce match est {0}", gagnant);
}
