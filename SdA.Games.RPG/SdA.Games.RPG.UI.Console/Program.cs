// je suis dans la méthode static void Main

// récupère le premier argument passé à ma commande exe
// string argUn = args[0];

#region Infos formation
// char unCharactere = 'a';
// Console.WriteLine(title.Length);

#endregion

#region Exécution du programme
string title = "Seigneur des anneaux Factory";
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(GetTitreFormate(title));

title = "Une aventure de Sam";
Console.WriteLine(GetTitreFormate(title));
Console.ForegroundColor = ConsoleColor.White;
#endregion

#region Coeur d'application
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

