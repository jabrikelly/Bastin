using Microsoft.EntityFrameworkCore;

namespace BastinWebApp.Models
{
    public class BastinWebAppContext : DbContext
    {
        public BastinWebAppContext(DbContextOptions<BastinWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Privilege> Privilege { get; set; }
        public DbSet<Gebruiker> Gebruiker { get; set; }
        public DbSet<Melding> Melding { get; set; }
    }
}


// AANMAKEN TABELLEN
// dotnet restore
// dotnet aspnet-codegenerator controller -name PrivilegeController -m Privilege -dc BastinWebAppContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
// dotnet aspnet-codegenerator controller -name GebruikerController -m Gebruiker -dc BastinWebAppContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
// dotnet aspnet-codegenerator controller -name MeldingController -m Melding -dc BastinWebAppContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries