using SdA.Games.RPG.Core.Models.Characters;

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
    public abstract Personnage Lancer(Personnage attaquant1, Personnage attaquant2);
    #endregion
}
