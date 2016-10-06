using System.Data.Entity;

namespace Nfe.Client.Tests
{
    public class PlexosContext : DbContext
    {
        static PlexosContext()
        {
            Database.SetInitializer<PlexosContext>(null);
        }

        public PlexosContext()
            : base("Name=Plexos_TESTEContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(PlexosContext).Assembly);
        }
    }
}
