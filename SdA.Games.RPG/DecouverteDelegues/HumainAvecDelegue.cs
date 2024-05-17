namespace DecouverteDelegues
{
    public delegate void Bouger();

    public class Voiture
    {
        public void Avancer()
        {

        }
    }

    public class Velo
    {
        public void Rouler()
        {

        }
    }

    internal class HumainAvecDelegue
    {
        public Bouger? bougerParDefaut;

        public void SeDeplacer(Bouger bouger)
        {
            if (this.bougerParDefaut != null)
            {
                bouger = this.bougerParDefaut;
            }
            bouger();
        }
    }

    internal class VaisseauSpatial
    {
        public void Bouger()
        {
            Console.WriteLine("Bidibidip je me déplace vite");
        }
    }

    internal class Vie
    {
        void Lancer()
        {
            HumainAvecDelegue humain = new();
            var voiture = new Voiture();
            var velo = new Velo();
            var vaisseau = new VaisseauSpatial();

            humain.SeDeplacer(velo.Rouler);
            humain.SeDeplacer(voiture.Avancer);
            humain.SeDeplacer(vaisseau.Bouger);
        }
    }
}
