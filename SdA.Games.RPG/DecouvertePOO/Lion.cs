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
        public void Rugir()
        {
            Console.WriteLine("Roaaaaar");
        }
        #endregion
    }
}
