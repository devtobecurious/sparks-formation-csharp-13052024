namespace SdA.Games.RPG.Core.Models.Characters;

/// <summary>
/// 
/// </summary>
public class Player // internal: que pour l'assembly, pas dans un autre projet
{
    #region Constructors
    public Player(string prenom)
    {
        Prenom = prenom;
    }
    #endregion

    #region Properties
    public string Prenom { get; private set; }

    public int Age { get; set; }
    #endregion
}

//namespace TestNamespace
//{
//    public class Player { }
//}
