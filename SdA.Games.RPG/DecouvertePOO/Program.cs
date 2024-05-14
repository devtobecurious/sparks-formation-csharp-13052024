using DecouvertePOO;

// Copie de référence
Animal animal = new Animal("Coco", TypeAnimal.Perroquet); // crée l'instance, donc la référence en mémoire
Animal animal3 = new Animal("Simba", TypeAnimal.Lion);
animal3.Taille = 200;

//animal.Type = TypeAnimal.Perroquet;
//animal.Type = TypeAnimal.Lion;
// animal.Prenom = "Coco";

//var typeAnimal = animal.GetType();
var typeAnimal = animal.TypeAnimal;
//animal.TypeAnimal = TypeAnimal.Perroquet; // Lecture seule

Animal animal2 = animal; // Copie ? Clone ? Non ! on récupère la référence de l'instance qui pointe depuis animal
//animal2.Prenom = "Chita";

ModifierPrenom(animal);
ModifierPrenom(animal2);

Console.WriteLine(animal.Prenom);
Console.WriteLine(animal2.Prenom);

animal.Manger(1);
animal.Manger(1, "herbe");
// animal.Manger(2); // on ne peut pas l'appeler : elle est privée

animal.Dormir();
animal.Dormir("Shaun");
animal.Dormir("Shaun", "Beee");
animal.Dormir("Shaun", "Beee", "Igorrr");

void ModifierPrenom(Animal unAnimal) // On récupére la copie du contenu de la variable passé quand elle est appelée, et donc on a la référence de l'appelant
{
    Console.WriteLine("Le prénom ?");
    unAnimal.Prenom = Console.ReadLine();
}

#region Copie de valeur
int nbPattes = 4;
ModifierNbPattes(out nbPattes);
Console.WriteLine(nbPattes);

//void ModifierNbPattes(ref int nbPattesLocal)
//{
//    nbPattesLocal = 5;
//}

void ModifierNbPattes(out int nbPattesLocal) // in on va pointer vers la variable appelante, on garantit une mise à jour interne, en sortie
{
    nbPattesLocal = 5; // je suis obligé de setter une valeur ! out : par référence et mise à jour
}
#endregion