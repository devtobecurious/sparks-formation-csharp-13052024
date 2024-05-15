namespace DecouvertePOO
{
    internal abstract class Oiseau : Animal, IQuiPeutVoler
    {
        public Oiseau(string prenom) : base(prenom)
        {
        }

        public virtual void Voler()
        {
            Console.WriteLine("I believe I can fly !");
        }

        public virtual void Voler(string test)
        {
            Console.WriteLine("I believe I can fly !");
        }

        //public override void SeDeplacer()
        //{

        //}

        public override abstract void SeDeplacer();
    }
}
