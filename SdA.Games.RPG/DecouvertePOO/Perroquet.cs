namespace DecouvertePOO
{
    internal class Perroquet : Animal
    {
        #region Constructors
        public Perroquet(string prenom) : base(prenom)
        {
        }
        #endregion

        public override void SeDeplacer()
        {
            throw new NotImplementedException();
        }
    }
}
