namespace DecouvertePOO
{
    internal class Lion : Animal
    {
        #region Constructors
        public Lion(string prenom) : base(prenom)
        {

        }
        #endregion

        #region Public methods
        public override void Dormir(params string[] prenomMoutons)
        {
            // base.Dormir(prenomMoutons);
            Console.WriteLine("je dors sur un rocher de malade");
        }

        public void Rugir()
        {
            Console.WriteLine("Roaaaaar");
        }

        public override void SeDeplacer()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
