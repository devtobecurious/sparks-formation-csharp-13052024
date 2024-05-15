namespace DecouvertePOO
{
    internal class Tigre : Animal
    {
        public Tigre(string prenom, int taille) : base(prenom, taille, "orange")
        {
        }

        public override void Dormir(params string[] prenomMoutons)
        {
            base.Dormir(prenomMoutons);
            Console.WriteLine("Je mange tous les moutons");
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Tigre déplacement");
        }
    }
}
