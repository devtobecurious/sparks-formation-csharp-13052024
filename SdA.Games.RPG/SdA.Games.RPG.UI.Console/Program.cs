// je suis dans la méthode static void Main

// récupère le premier argument passé à ma commande exe
//using SdA.Games.RPG.Core.Models.Characters;
using SdA.Games.RPG.UI.Console;
using System.Globalization;

var culture = new CultureInfo("en-EN");
System.Threading.Thread.CurrentThread.CurrentCulture = culture;

string argUn = args[0];
char premierChar = argUn[0]; // tableau de caractère

#region Infos formation
// char unCharactere = 'a';
// Console.WriteLine(title.Length);

//DateTime date = DateTime.Now;
//Console.WriteLine(date.ToString("dddd dd MMMM yyyy", new CultureInfo("fr-CA")));
#endregion

#region Exécution du programme
string title = "Seigneur des anneaux Factory";
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(GetTitreFormate(title));
// {
var nomJoueur = DemanderNomJoueur();

// }

// Concaténer : v1
// title = "Une aventure de " + nomJoueur;
// Concaténer : v2 => interpolation
// title = $"Une aventure de {nomJoueur.ToUpper()} // {nomJoueur.ToLower()}";
title = string.Format("Une aventure de {0} / {0}", nomJoueur.ToUpper());

Console.WriteLine(GetTitreFormate(title));
Console.ForegroundColor = ConsoleColor.White;


AfficherMenu();
SaisirProfil();
#endregion

#region Coeur d'application
void SaisirProfil()
{
    Player player = new Player("Hello");
    player.Age = VerifierAgeJoueur();
}

DateTime DemanderDateNaissance()
{
    //DateTime dateTime = DateTime.Parse(dateSaisie);
    DateTime dateReel = DateTime.MinValue;
    bool isConversionOK = false;

    do
    {
        Console.WriteLine("Saisis la date de naissance");
        string dateSaisie = Console.ReadLine();

        isConversionOK = DateTime.TryParse(dateSaisie, out dateReel);

    } while (!isConversionOK);

    Console.WriteLine("Date récupérée {0}", dateReel.ToString());

    return dateReel;
}

int VerifierAgeJoueur()
{
    const int AgeRequis = 13;
    // DateOnly
    // TimeOnly
    DateTime dateNaissance = DemanderDateNaissance();
    TimeSpan soustraction = DateTime.Now - dateNaissance;

    int age = (int)soustraction.TotalDays / 365;

    if (age < AgeRequis)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Tu n'as pas l'âge requis, petit coquin ;)");
        Environment.Exit(0);
    }

    return age;
}

void AfficherMenu()
{
    //string[] menuItems = new string[6];
    //menuItems[0] = "0. Saisie profil";

    #region Premiere façon de faire avec un tableau
    //ChoixMenu choixMenu = ChoixMenu.NouvellePartie;

    //string[] menuItems = new string[]
    //{
    //    "Saisie profil",
    //    "Démarrer la partie",
    //    "Reprendre la partie en cours",
    //    "Charger une partie existante",
    //    "Options",
    //    "Quitter"
    //};

    //Console.WriteLine("MENU");
    //for (int i = 0; i < menuItems.Length; i++)
    //{
    //    AfficherLigneMenu(i, menuItems[i]);
    //}
    #endregion

    var tableauItems = Enum.GetNames<ChoixMenu>();
    foreach (var keyInEnum in tableauItems)
    {
        var value = (ChoixMenu)Enum.Parse(typeof(ChoixMenu), keyInEnum);
        Console.WriteLine("{0}. {1}", (int)value, keyInEnum);
    }

    ChoixAction();
}

void ChoixAction()
{
    ChoixMenu choix = (default); // Ici, ça sera SaisieProfil

    switch (choix)
    {
        case ChoixMenu.SaisieProfil:
            {

            }
            break;

        case ChoixMenu.Options:
            {

            }
            break;
    }
}

void AfficherLigneMenu(int i, string content)
{
    Console.WriteLine("{0}. {1}", i, content.ToUpper());
}

string DemanderNomJoueur()
{
    Console.WriteLine("Donne moi le nom du héros, {0}", "stp");
    var nomJoueur = Console.ReadLine();

    return nomJoueur;
}

// fonction locale
string GetTitreFormate(string title)
{
    if (string.IsNullOrEmpty(title))
    {
        return string.Empty;
    }

    return title.PadLeft(title.Length + 2, '=').PadRight(title.Length + 4, '=');
}
#endregion

