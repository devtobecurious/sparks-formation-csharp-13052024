namespace DecouvertePOO
{
    internal class ChauveSouris : Animal, IQuiPeutVoler
    {
        public ChauveSouris(string prenom) : base(prenom)
        {
        }

        public override void SeDeplacer()
        {
            throw new NotImplementedException();
        }

        public void Voler()
        {
            Console.WriteLine("I'm batman !!!");
        }
    }
}
