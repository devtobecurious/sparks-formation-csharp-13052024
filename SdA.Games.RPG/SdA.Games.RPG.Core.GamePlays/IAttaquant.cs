namespace SdA.Games.RPG.Core.GamePlays
{
    /// <summary>
    /// Contrat pour tous les attaquants des combats <see cref="BaseCombat"></c>
    /// </summary>
    public interface IAttaquant
    {
        /// <summary>
        /// Attaquer un ennemi
        /// </summary>
        /// <param name="ennemi"></param>
        /// <returns></returns>
        void Attaquer(IAttaquant ennemi);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ennemi"></param>
        /// <returns></returns>
        bool EtreMemePersonne(IAttaquant ennemi);

        /// <summary>
        /// 
        /// </summary>
        bool EstEnVie { get; }

        int PointDeVie { get; set; }
    }
}
