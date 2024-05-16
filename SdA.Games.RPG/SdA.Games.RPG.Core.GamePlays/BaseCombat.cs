namespace SdA.Games.RPG.Core.GamePlays;

public delegate void DemarrerCombat(IAttaquant[] attaquants);

/// <summary>
/// Classe parente de tous les types de combat possible
/// </summary>
public abstract class BaseCombat
{
    #region Fields
    public event DemarrerCombat CombatDemarre;
    public event Action<IAttaquant> CombatFini;
    #endregion

    #region Public methods
    /// <summary>
    /// Lancet le combat, selon les règles du gameplay souhaité
    /// </summary>
    /// <returns>Retourne le gagnant</returns>
    public abstract IAttaquant Lancer(IAttaquant attaquant1, IAttaquant attaquant2);
    #endregion

    #region Protected methods
    protected void InvokeDemarreCombat(IAttaquant[] attaquants)
    {
        this.CombatDemarre?.Invoke(attaquants);
    }

    protected void InvokeCombatFini(IAttaquant gagnant)
    {
        this.CombatFini?.Invoke(gagnant);
    }
    #endregion
}
