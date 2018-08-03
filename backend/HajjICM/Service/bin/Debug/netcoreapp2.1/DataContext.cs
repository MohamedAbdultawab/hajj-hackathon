using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.IO;
using Configuration;
namespace Data
{
    public class DataContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin, ApplicationRoleClaim, ApplicationUserToken>
    {
        private IConfigurationRoot Configuration { get; set; }

        public DataContext()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Using SQL Server database.
            //optionsBuilder.UseSqlServer(Configuration["ConnectionStrings:ConnectionString"]);

            // Using Sqlite database.
            optionsBuilder.UseSqlite(Configuration["ConnectionStrings:ConnectionString"]);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<BuildingType> BuildingTypes { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DeathReason> DeathReasons { get; set; }
        public DbSet<Doctrine> Doctrines { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Mansik> Mansiks { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonCategory> PersonCategories { get; set; }
        public DbSet<PersonLanguage> PersonLanguages { get; set; }
        public DbSet<PersonStatus> PersonStatuses { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }
        public DbSet<Title> Titles { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Core");

            builder.Entity<ApplicationRole>().ToTable("ApplicationRole");
            builder.Entity<ApplicationRoleClaim>().ToTable("ApplicationRoleClaim");
            builder.Entity<ApplicationUser>().ToTable("ApplicationUser");
            builder.Entity<ApplicationUserClaim>().ToTable("ApplicationUserClaim");
            builder.Entity<ApplicationUserLogin>().ToTable("ApplicationUserLogin");
            builder.Entity<ApplicationUserRole>().ToTable("ApplicationUserRole");
            builder.Entity<ApplicationUserToken>().ToTable("ApplicationUserToken");

            builder.ApplyConfiguration(new AddressConfiguration())
                   .ApplyConfiguration(new AddressTypeConfiguration())
                   .ApplyConfiguration(new BloodGroupConfiguration())
                   .ApplyConfiguration(new BloodTypeConfiguration())
                   .ApplyConfiguration(new BuildingTypeConfiguration())
                   .ApplyConfiguration(new BuildingTypeConfiguration())
                   .ApplyConfiguration(new CityConfiguration())
                   .ApplyConfiguration(new CountryConfiguration())
                   .ApplyConfiguration(new DeathReasonConfiguration())
                   .ApplyConfiguration(new DoctrineConfiguration())
                   .ApplyConfiguration(new GenderConfiguration())
                   .ApplyConfiguration(new LanguageConfiguration())
                   .ApplyConfiguration(new MansikConfiguration())
                   .ApplyConfiguration(new MaritalStatusConfiguration())
                   .ApplyConfiguration(new PersonConfiguration())
                   .ApplyConfiguration(new PersonAddressConfiguration())
                   .ApplyConfiguration(new PersonCategoryConfiguration())
                   .ApplyConfiguration(new PersonLanguageConfiguration())
                   .ApplyConfiguration(new PersonStatusConfiguration())
                   .ApplyConfiguration(new PersonTypeConfiguration())
                   .ApplyConfiguration(new TitleConfiguration());

        }
    }
}