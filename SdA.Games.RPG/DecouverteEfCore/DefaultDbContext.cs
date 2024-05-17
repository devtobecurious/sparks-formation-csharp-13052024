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

    #region Listings des liens vers les différentes tables en base
    public DbSet<Orc> Orc { get; set; } // Convention : le nom de la propriété est le nom de la table en base (par défaut)..ça peut se changer .. ;)
    #endregion
}
