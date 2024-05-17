namespace DecouverteEvenements_ADeveloperStory
{
    internal delegate void DemarrerCreation(CreateurPDF createur);
    internal delegate void DemarrageCreationFichier(string nomFichier);

    internal class CreateurPDF
    {
        public event DemarrerCreation Demarrage;
        public event DemarrageCreationFichier CreationFichierDemaree;

        public void Creer(string[] nomsDeFichier)
        {
            // Code de préparation 

            // Démarrage
            this.Demarrage?.Invoke(this);
            foreach (var nom in nomsDeFichier)
            {
                // création du fichier
                this.CreationFichierDemaree?.Invoke(nom); // J'appelle une à plusieurs méthodes qui m'ont été passé, je les exécute en une seule ligne de code

                // fin de création de fichier
            }

            // Code de fermeture 

            // Fin  de création des fichiers
        }
    }

    internal class SauvegardeBDD
    {
        public void Save(string info)
        {
            Console.WriteLine("J'écris en bdd");
        }
    }

    internal class UtilisationPourCreationPDF
    {
        public void Generer()
        {
            CreateurPDF createur = new();
            SauvegardeBDD sauvegarde = new();

            //createur.Demarrage += moteurCreationPDF =>
            //{
            //    Console.WriteLine("Lancement de la création des pdf");
            //};
            createur.Demarrage += moteurCreationPDF => Console.WriteLine("Lancement de la création des pdf");

            createur.CreationFichierDemaree += nomFichier =>
            {
                Console.WriteLine($"Démarrage création fichier PDF depuis : {nomFichier}");

                //
            };

            createur.CreationFichierDemaree += nomFichier =>
            {
                // File.AppendAllText(@"H:\Tmps\Log\log.txt", $"Démarrage : fichier {nomFichier}");
                using var stream = new StreamWriter(@"H:\\Tmps\\Log\\log.txt\", false);
                stream.WriteLine($"Démarrage : fichier {nomFichier}");
            };

            createur.CreationFichierDemaree += sauvegarde.Save;

            createur.Creer(["fichier1", "fichier2"]);
        }

    }
}
