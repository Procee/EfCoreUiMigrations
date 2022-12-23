using Microsoft.EntityFrameworkCore;

namespace Database;

public class Context : DbContext
{
    public DbSet<Foo> Foos => Set<Foo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("database.sqlite",
            builder =>
            {
                    builder.MigrationsAssembly("EfCoreJetBrainsPlugin");
            });
        base.OnConfiguring(optionsBuilder);
    }
}
