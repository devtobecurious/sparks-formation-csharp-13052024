namespace SdA.Games.RPG.Core.GamePlays
{
    public class DeathMatchCombat : BaseCombat
    {
        #region Public methods
        public override IAttaquant Lancer(IAttaquant attaquant1, IAttaquant attaquant2)
        {
            while (attaquant1.EstEnVie && attaquant2.EstEnVie)
            {
                attaquant1.Attaquer(attaquant2);
                if (attaquant2.EstEnVie)
                {
                    attaquant2.Attaquer(attaquant1);
                }
            }

            return attaquant1.EstEnVie ? attaquant1 : attaquant2;
        }
        #endregion
    }
}
