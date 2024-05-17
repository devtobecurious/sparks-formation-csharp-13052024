namespace DecouvertePOO
{
    internal interface IMoyenDeDeplacement
    {
        void Bouger();
        void Arreter();
    }

    internal class Velo : IMoyenDeDeplacement
    {
        public void Arreter()
        {
            throw new NotImplementedException();
        }

        public void Bouger()
        {
            this.Rouler();
        }

        public void Rouler()
        {

        }
    }

    internal class VaisseauSpatial : IMoyenDeDeplacement
    {
        public void Arreter()
        {
            throw new NotImplementedException();
        }

        public void Bouger()
        {
            Console.WriteLine("Bidibidip je me déplace vite");
        }
    }

    internal class Voiture : IMoyenDeDeplacement
    {
        public void Bouger()
        {
            this.Avancer();
        }

        public void Arreter()
        {
            throw new NotImplementedException();
        }


        public void Avancer()
        {

        }
    }

    internal class HumainAvecInterface
    {
        // public Velo Velo { get; set; } = new Velo(); // Fortement connecté à la propriété et donc à la classe liée
        public IMoyenDeDeplacement? moyenDeDeplacementParDefaut { get; set; }

        public void SeDeplacer(IMoyenDeDeplacement moyenDeDeplacement)
        {
            if (this.moyenDeDeplacementParDefaut != null)
            {
                moyenDeDeplacement = this.moyenDeDeplacementParDefaut;
            }

            // this.Velo.Rouler();
            moyenDeDeplacement.Bouger();
            moyenDeDeplacement.Arreter();
        }
    }

    internal class Vie
    {
        void Lancer()
        {
            HumainAvecInterface humain = new();

            humain.SeDeplacer(new Velo());
            humain.SeDeplacer(new Voiture());
            humain.SeDeplacer(new VaisseauSpatial());
        }
    }
}
