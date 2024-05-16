namespace SdA.Games.RPG.Core.GamePlays
{
    public class DeathMatchCombat : BaseCombat
    {
        #region Public methods
        public override IAttaquant Lancer(IAttaquant attaquant1, IAttaquant attaquant2)
        {
            //IAttaquant[] attaquants = new IAttaquant[] { attaquant1, attaquant2 };
            IAttaquant[] attaquants = [attaquant1, attaquant2];
            this.InvokeDemarreCombat(attaquants);

            while (attaquant1.EstEnVie && attaquant2.EstEnVie)
            {
                attaquant1.Attaquer(attaquant2);
                if (attaquant2.EstEnVie)
                {
                    attaquant2.Attaquer(attaquant1);
                }
            }

            IAttaquant gagnant = attaquant1.EstEnVie ? attaquant1 : attaquant2;
            this.InvokeCombatFini(gagnant);

            return gagnant;
        }
        #endregion
    }
}
