using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace WindowsFormsApplication3.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsApplication3.TiendaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WindowsFormsApplication3.TiendaContext";
        }

        protected override void Seed(WindowsFormsApplication3.TiendaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
