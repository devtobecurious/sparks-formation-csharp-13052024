
using DecouverteEfCore;
using Microsoft.EntityFrameworkCore;

var builder = new DbContextOptionsBuilder<DefaultDbContext>();

builder.UseSqlServer("Server=DESKTOP-1446PBQ;Database=SdA.Games.BaseDeDonnees.DEV;Trusted_Connection=True;TrustServerCertificate=Yes;", options =>
{
    options.CommandTimeout(1200);
});
// c'est ici que l'on va dire qu'on utilise sql server

var context = new DefaultDbContext(builder.Options);


// Première étape : on prépare une requête => elle ne fait rien, elle n'est pas exécutée
var query = from item in context.Orc
            select item;

//var list = query.ToList()// Operator d'exécution : va se connecter, exécuter, et retourner une liste, et fermer la connection
//                .Where(item => item.Force > 10)
//                .ToList(); 

var list = query
                .Where(item => item.Force > 10)
                .ToList();

foreach (var item in list)
{
    Console.WriteLine(item.Prenom);
}

foreach (var item in list)
{
    Console.WriteLine(item.Prenom);
}

//foreach (var item in query) // Attention, on se reconnecte !!
//{
//    Console.WriteLine(item.Prenom);
//}

//foreach (var item in query) // Attention, on se reconnecte !!
//{
//    Console.WriteLine(item.Prenom);
//}
