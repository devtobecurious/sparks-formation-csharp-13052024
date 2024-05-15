using SdA.Games.RPG.Core.GamePlays;

namespace SdA.Games.RPG.Core.Models.Characters
{
    public class Orc : IAttaquant
    {
        public bool EstEnVie => this.PointDeVie > 10;

        public int PointDeVie { get; set; }

        public void Attaquer(IAttaquant ennemi)
        {
            ennemi.PointDeVie -= 10;
        }

        public bool EtreMemePersonne(IAttaquant ennemi)
        {
            return (ennemi as Orc) != null;
        }
    }
}
