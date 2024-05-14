namespace DecouvertePOO
{
    #region Sans héritage
    /// <summary>
    /// Classe représentant tout animal confondu
    /// </summary>
    //internal class Animal
    //{
    //    #region Attributs
    //    private string prenom;
    //    private TypeAnimal type;
    //    #endregion

    //    #region Constructors
    //    public Animal(string prenom, TypeAnimal type)
    //    {
    //        this.TypeAnimal = type;
    //        this.Prenom = prenom;
    //        Console.WriteLine("Je me construis");
    //    }
    //    #endregion

    //    #region Methods
    //    public TypeAnimal GetType()
    //    {
    //        return this.type;
    //    }

    //    /// <summary>
    //    /// Permet à un animal de manger
    //    /// </summary>
    //    /// <param name="nourriture"></param>
    //    public void Manger(int duration, string nourriture = "Bamboo", string lieu = "france")
    //    {
    //        //Console.WriteLine("{0}, Miam c'est bon {1}", this.Prenom, nourriture);
    //        switch (this.TypeAnimal)
    //        {
    //            case TypeAnimal.Chimpanze: { } break;
    //            case TypeAnimal.Lion:
    //                {
    //                    Console.WriteLine("Je rugis avant de manger");
    //                }
    //                break;
    //        }
    //    }

    //    public void Dormir(params string[] prenomMoutons) // le tableau est par défaut à vide, non null
    //    {
    //        Console.WriteLine("{0} je compte les moutons", this.Prenom);
    //        for (int i = 0; i < prenomMoutons.Length; i++)
    //        {
    //            Console.WriteLine("Oh un mouton : {0}", prenomMoutons[i]);
    //        }
    //    }

    //    /// <summary>
    //    /// Mange N fois
    //    /// </summary>
    //    /// <param name="nbFois">Entier de 0 à 100</param>
    //    private void Manger(int nbFois)
    //    {
    //        //this.Manger("Bamboo");
    //        //this.Manger("Bamboo 2");
    //        Console.WriteLine("{0} Je mange deux fois", this.Prenom);
    //    }

    //    // Le return changeant ne permet une nouvelle surcharge
    //    //public int Manger(int nbFois)
    //    //{

    //    //}
    //    #endregion

    //    #region Properties
    //    public TypeAnimal TypeAnimal
    //    {
    //        get
    //        {
    //            return this.type;
    //        }
    //        private set
    //        {
    //            if (value == TypeAnimal.ChauveSouris)
    //            {
    //                return;
    //            }

    //            this.type = value;
    //        }
    //    }

    //    public string Prenom
    //    {
    //        get
    //        {
    //            return this.prenom;
    //        }
    //        private set
    //        {
    //            if (string.IsNullOrEmpty(value))
    //            {
    //                value = "Non renseigné";
    //            }
    //            this.prenom = value;
    //        }
    //    }

    //    public int Taille { get; set; }

    //    // Ici le get et le set sont privés
    //    private int Coeur { get; set; }
    //    #endregion
    //}
    #endregion

    #region Avec héritage
    internal abstract class Animal
    {
        #region Attributs
        private string prenom;
        #endregion

        #region Constructors
        public Animal(string prenom) : this(prenom, 100)
        {
            // this.Prenom = prenom;
        }

        public Animal(string prenom, int taille)
        {
            Console.WriteLine("Je me construis");
            this.Prenom = prenom;
            this.Taille = taille;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Permet à un animal de manger
        /// </summary>
        /// <param name="nourriture"></param>
        public void Manger(int duration, string nourriture = "Bamboo", string lieu = "france")
        {
            Console.WriteLine("{0}, Miam c'est bon {1}", this.Prenom, nourriture);
        }

        public virtual void Dormir(params string[] prenomMoutons) // le tableau est par défaut à vide, non null
        {
            Console.WriteLine("{0} je compte les moutons", this.Prenom);
            for (int i = 0; i < prenomMoutons.Length; i++)
            {
                Console.WriteLine("Oh un mouton : {0}", prenomMoutons[i]);
            }
        }

        public abstract void SeDeplacer();

        /// <summary>
        /// Mange N fois
        /// </summary>
        /// <param name="nbFois">Entier de 0 à 100</param>
        private void Manger(int nbFois)
        {
            //this.Manger("Bamboo");
            //this.Manger("Bamboo 2");
            Console.WriteLine("{0} Je mange deux fois", this.Prenom);
        }

        // Le return changeant ne permet une nouvelle surcharge
        //public int Manger(int nbFois)
        //{

        //}
        #endregion

        #region Properties
        public string Prenom
        {
            get
            {
                return this.prenom;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    value = "Non renseigné";
                }
                this.prenom = value;
            }
        }

        public int Taille { get; set; }

        // Ici le get et le set sont privés
        private int Coeur { get; set; }
        #endregion
    }
    #endregion
}
