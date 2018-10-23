using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApplication3
{
    class TiendaContext : DbContext
    {
        public TiendaContext(): base() 
       {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TiendaContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TiendaContext, Migrations.Configuration>());
        }

        public DbSet<Producto> Producto { get; set; }
        /*  public DbSet<Campaña> Campañas { get; set; }
          public DbSet<RssReutilizable> RSSreutilizables { get; set; }
          public DbSet<Banner> Banners { get; set; }
          public DbSet<Imagen> Imagens { get; set; }
          public DbSet<RSS> Rsses { get; set; }
          public DbSet<TextoFijo> TextoFijos { get; set; }
          public DbSet<ContenidoBanner> Fuentes { get; set; }
          */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
