// See https://aka.ms/new-console-template for more information
// La signature est : void (string ?)

using DecouverteDelegues;

//Console.WriteLine("Hello, World!");


Afficher pourAffichage = Console.WriteLine;
// Afficher pourAffichage2 = Console.ReadLine; // => pas même signature

pourAffichage("Hello ");



void CalculerSomme(int a, int b, Afficher? afficher)
{
    var result = a + b;
    // Qu'est ce que je veux faire : Afficher le resultat
    // afficher(result.ToString()); // on présuppose qu'on a passé une méthode à l'exécution !
    // afficher.Invoke(result.ToString()); // on présuppose qu'on a passé une méthode à l'exécution !
    afficher?.Invoke(result.ToString());
}

void AfficherEnRouge(string? param)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(param);
    Console.ForegroundColor = ConsoleColor.White;
}

CalculerSomme(1, 3, Console.WriteLine);
CalculerSomme(1, 3, AfficherEnRouge);

void TestAfficherEnMaj(string? mess)
{
    Console.WriteLine(mess.ToUpper());
}

Afficher afficher = TestAfficherEnMaj;

Afficher afficher2 = mess => Console.WriteLine(mess.ToUpper()); // avant '=>' ce sont les paramètres d'entrées // après '=>' corps de la méthode

Afficher afficher3 = (mess) =>
{
    Console.WriteLine(mess.ToUpper());
};

CalculerSomme(1, 5, mess => Console.WriteLine(mess.ToLower()));
CalculerSomme(1, 5, null);
