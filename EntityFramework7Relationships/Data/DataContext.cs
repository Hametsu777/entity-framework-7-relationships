using EntityFramework7Relationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EntityFramework7Relationships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Character is the name of table being created. Table is usually pluralized version of Model.
        // Need to use dotnet ef migrations add InitialCreate in the PM Console to initialize Database.
        // Migrations folder is created after the database is initialized.
        // Next, need to run dotnet ef database update. This will create the database if it does not exist.
        // For the DbSet Weapons, instead of running the InitialCreate command in PM Console, I ran dotnet ef
        // migrations add CharacterWeaponsRelationship. Don't need to reinitialize database. Just whatever
        // table is being added. Have to run dotnet ef database update to update database when new table is added.
        public DbSet<Character> Characters { get; set; }
        public DbSet<Backpack> Backpacks { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Faction> Factions { get; set; }
    }
}
