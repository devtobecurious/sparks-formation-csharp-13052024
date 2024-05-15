namespace SdA.Games.RPG.Core.GamePlays;

/// <summary>
/// Classe parente de tous les types de combat possible
/// </summary>
public abstract class BaseCombat
{
    #region Public methods
    /// <summary>
    /// Lancet le combat, selon les règles du gameplay souhaité
    /// </summary>
    /// <returns>Retourne le gagnant</returns>
    public abstract IAttaquant Lancer(IAttaquant attaquant1, IAttaquant attaquant2);
    #endregion
}
