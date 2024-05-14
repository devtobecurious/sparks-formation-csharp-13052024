namespace SdA.Games.RPG.Core.Models.Characters
{
    /// <summary>
    /// 
    /// </summary>
    public class Personnage
    {
        #region Constructors
        public Personnage(string prenom, int pointDeVie = 100, decimal force = 50)
        {
            this.Prenom = prenom;
            this.PointDeVie = pointDeVie;
            this.Force = force;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// 
        /// </summary>
        public void SeDeplacer()
        {
            Console.WriteLine($"{this.Prenom}, je me déplace");
        }

        /// <summary>
        /// 
        /// </summary>
        public void Attaquer()
        {
            Console.WriteLine($"{this.Prenom}, j'attaque");
        }
        #endregion

        #region Properties
        public string Prenom { get; }
        public int PointDeVie
        {
            get; private set;
        }
        public decimal Force { get; set; }
        #endregion
    }
}
