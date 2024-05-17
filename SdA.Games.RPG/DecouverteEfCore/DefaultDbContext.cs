using Microsoft.EntityFrameworkCore;
namespace DecouverteEfCore;

public class DefaultDbContext : DbContext
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
    {
    }

    protected DefaultDbContext()
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Orc>().HasKey(x => x.Id);
        modelBuilder.Entity<Orc>().ToTable("Orc"); // Le nom de la table n'est pas Orcs (le nom de la property) mais Orc
    }

    #region Listings des liens vers les différentes tables en base
    public DbSet<Orc> Orcs { get; set; } // Convention : le nom de la propriété est le nom de la table en base (par défaut)..ça peut se changer .. ;)
    #endregion
}
