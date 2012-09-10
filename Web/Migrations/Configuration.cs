namespace Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
using Web.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Web.Models.SupplyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            //DropCreateDatabaseAlways<SupplyContext> = true;

        }

        protected override void Seed(Web.Models.SupplyContext context)
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
            context.Customers.AddOrUpdate(
                x => x.FirstName,
                    new Customer { FirstName = "aaa", LastName = "aaa", Email = "aaa@a.com" }
                    );
        }
    }
}
