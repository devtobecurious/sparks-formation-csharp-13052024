namespace SdA.Games.RPG.Core.Models.Characters
{
    /// <summary>
    /// 
    /// </summary>
    public class Personnage
    {
        #region Statics
        public static int __NBInstances = 0;
        private static Random __random = new Random();
        #endregion

        #region Constructors
        public Personnage(string prenom, int pointDeVie = 100, int force = 50)
        {
            this.Prenom = prenom;
            this.PointDeVie = pointDeVie;
            this.Force = force;

            __NBInstances++;
        }
        #endregion

        #region Public methods
        public static void SayHello()
        {
            Console.WriteLine("Je ne peux pas appeler de valeur d'instance");
        }

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
        public void Attaquer(Personnage personnage)
        {
            // Guardien de ma méthode
            if (personnage.Prenom == this.Prenom)
            {
                return;
            }

            var coup = Personnage.__random.Next(1, this.Force + 1);
            Console.WriteLine($"{this.Prenom}, j'attaque avec un coup : {coup}");
            personnage.PointDeVie -= coup;
        }

        public override string ToString()
        {
            return $"{this.Prenom} / Vie : {this.PointDeVie}";
        }
        #endregion

        #region Properties
        public string Prenom { get; }

        private int pointDeVie = 100;
        public int PointDeVie
        {
            get => this.pointDeVie;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                this.pointDeVie = value;
            }
        }

        //public bool EstEnVie { get { return this.PointDeVie > 0; } }
        // public bool EstEnVie {  get => this.PointDeVie > 0; }
        public bool EstEnVie => this.PointDeVie > 0;

        public int Force { get; set; }
        #endregion
    }
}
