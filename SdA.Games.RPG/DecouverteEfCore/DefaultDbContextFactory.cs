using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DecouverteEfCore
{
    public class DefaultDbContextFactory : IDesignTimeDbContextFactory<DefaultDbContext>
    {
        public DefaultDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DefaultDbContext>();

            builder.UseSqlServer("Server=DESKTOP-1446PBQ;Database=SdA.Games.BaseDeDonnees.DEV;Trusted_Connection=True;TrustServerCertificate=Yes;", options =>
            {
                options.CommandTimeout(1200);
            });

            return new DefaultDbContext(builder.Options);
        }
    }
}
