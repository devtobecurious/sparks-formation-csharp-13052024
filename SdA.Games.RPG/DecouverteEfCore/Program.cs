
using DecouverteEfCore;
using Microsoft.EntityFrameworkCore;

var builder = new DbContextOptionsBuilder<DefaultDbContext>();

builder.UseSqlServer("Server=DESKTOP-1446PBQ;Database=SdA.Games.BaseDeDonnees.DEV;Trusted_Connection=True;TrustServerCertificate=Yes;", options =>
{
    options.CommandTimeout(1200);
});
// c'est ici que l'on va dire qu'on utilise sql server

var context = new DefaultDbContext(builder.Options);

var queryForces = from item in context.Orcs
                  where item.Force > 10
                  select item.Force;

var sumForces = queryForces.Sum();


// Première étape : on prépare une requête => elle ne fait rien, elle n'est pas exécutée
var query = from item in context.Orcs
            let firstChar = item.Prenom.Substring(0, 1)
            where item.Force > 10 && firstChar == "f"
            orderby item.Force descending
            select item;

var query2 = context.Orcs.Where(item => item.Force > 10 && item.Prenom.Substring(0, 1) == "f")
                        .OrderByDescending(item => item.Force)
                        .Select(item => item);

//var list = query.ToList()// Operator d'exécution : va se connecter, exécuter, et retourner une liste, et fermer la connection
//                .Where(item => item.Force > 10)
//                .ToList(); 

var list = query
                //.Where(item => item.Force > 10)
                .ToList();

Console.WriteLine("---------------------------");
foreach (var item in list)
{
    Console.WriteLine(item.Prenom);
}

//foreach (var item in list)
//{
//    Console.WriteLine(item.Prenom);
//}
Console.WriteLine("---------------------------");

var orc = new Orc()
{
    Force = 11,
    Height = 100,
    PointsDeVie = 150,
    Prenom = $"Floiojnu-{DateTime.Now.Ticks.ToString()}"
};

context.SavedChanges += (sender, e) =>
{
    Console.WriteLine("Sauvegarde réussie !");
};

context.Orcs.Add(orc); // Il n'est pas enregistré en base ! juste mis en RAM avec l'état Ajouté
context.SaveChanges();

//context.SavedChanges += Context_SavedChanges;

//void Context_SavedChanges(object? sender, SavedChangesEventArgs e)
//{

//}


//void Context_SavedChanges(object? sender, SavedChangesEventArgs e)
//{
//    throw new NotImplementedException();
//}

Console.WriteLine("---------------------------");

foreach (var item in query) // Attention, on se reconnecte !!
{
    Console.WriteLine(item.Prenom);
}

//foreach (var item in query) // Attention, on se reconnecte !!
//{
//    Console.WriteLine(item.Prenom);
//}
