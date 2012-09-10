using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Web.Models.Mapping;

namespace Web.Models
{
    public class MigrateContext : DbContext
    {
        static MigrateContext()
        {
            Database.SetInitializer<MigrateContext>(null);
        }

		public MigrateContext()
			: base("Name=MigrateContext")
		{
		}

        public DbSet<Config> Configs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Prospect> Prospects { get; set; }
        public DbSet<RoleMembership> RoleMemberships { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Schema> Schemata { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConfigMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new LogMap());
            modelBuilder.Configurations.Add(new LoginMap());
            modelBuilder.Configurations.Add(new MovieMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProspectMap());
            modelBuilder.Configurations.Add(new RoleMembershipMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new SchemaMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
