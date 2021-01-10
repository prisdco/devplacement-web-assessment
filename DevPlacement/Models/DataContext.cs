using MySql.Data.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPlacement.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DataContext : DbContext
    {
        public DataContext() : base("DbContext")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public virtual DbSet<users> Users { get; set; }
        public virtual DbSet<BioName> BioNames { get; set; }
        public virtual DbSet<Street> Streets { get; set; }
        public virtual DbSet<Coordinates> Coordinates { get; set; }
        public virtual DbSet<Timezone> Timezones { get; set; }
        public virtual DbSet<Location> Locations { get; set; }

        public virtual DbSet<Login> Logins { get; set; }

        public virtual DbSet<Dob> Dobs { get; set; }

        public virtual DbSet<Registered> Registereds { get; set; }

        public virtual DbSet<Id> IDs { get; set; }

        public virtual DbSet<Picture> Pictures { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            modelBuilder.Entity<users>()
                .HasRequired(h => h.bioname)
                .WithRequiredPrincipal(h => h.users);

            modelBuilder.Entity<users>()
                .HasRequired(h => h.location)
                .WithRequiredPrincipal(h => h.users);

            modelBuilder.Entity<users>()
                .HasRequired(h => h.login)
                .WithRequiredPrincipal(h => h.users);

            modelBuilder.Entity<users>()
                .HasRequired(h => h.registered)
                .WithRequiredPrincipal(h => h.users);

            modelBuilder.Entity<users>()
                .HasRequired(h => h.picture)
                .WithRequiredPrincipal(h => h.users);

            modelBuilder.Entity<users>()
                .HasRequired(h => h.id)
                .WithRequiredPrincipal(h => h.users);

            modelBuilder.Entity<users>()
                .HasRequired(h => h.dob)
                .WithRequiredPrincipal(h => h.users);

            modelBuilder.Entity<Location>()
                .HasRequired(h => h.street)
                .WithRequiredPrincipal(h => h.Location);

            modelBuilder.Entity<Location>()
                .HasRequired(h => h.timezone)
                .WithRequiredPrincipal(h => h.Location);

            modelBuilder.Entity<Location>()
                .HasRequired(h => h.coordinates)
                .WithRequiredPrincipal(h => h.Location);
        }

    }
}