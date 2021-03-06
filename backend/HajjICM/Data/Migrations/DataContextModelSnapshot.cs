﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Core")
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("Apartment");

                    b.Property<string>("Building");

                    b.Property<int?>("BuildingTypeId");

                    b.Property<int?>("CityId");

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<int>("CountryId");

                    b.Property<string>("District");

                    b.Property<string>("Floor");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.HasIndex("BuildingTypeId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Entity.AddressType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AddressType");
                });

            modelBuilder.Entity("Entity.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("ApplicationRole");
                });

            modelBuilder.Entity("Entity.ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationRoleClaim");
                });

            modelBuilder.Entity("Entity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("Entity.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUserClaim");
                });

            modelBuilder.Entity("Entity.ApplicationUserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUserLogin");
                });

            modelBuilder.Entity("Entity.ApplicationUserRole", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationUserRole");
                });

            modelBuilder.Entity("Entity.ApplicationUserToken", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("ApplicationUserToken");
                });

            modelBuilder.Entity("Entity.BloodGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Symbol")
                        .IsUnique();

                    b.ToTable("BloodGroup");
                });

            modelBuilder.Entity("Entity.BloodType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<int>("GroupId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Symbol")
                        .IsUnique();

                    b.ToTable("BloodType");
                });

            modelBuilder.Entity("Entity.BuildingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("BuildingType");
                });

            modelBuilder.Entity("Entity.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.Property<int>("PeopleNumber");

                    b.Property<int?>("SupervisorId");

                    b.HasKey("Id");

                    b.HasIndex("SupervisorId");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("Entity.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CountryId", "Name")
                        .IsUnique();

                    b.ToTable("City");
                });

            modelBuilder.Entity("Entity.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("ISO");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Entity.DeathReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("DeathReason");
                });

            modelBuilder.Entity("Entity.Doctrine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Doctrine");
                });

            modelBuilder.Entity("Entity.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("Entity.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("ISO");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Language");
                });

            modelBuilder.Entity("Entity.Mansik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<DateTime>("EndDate");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("Order");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("Latitude")
                        .IsUnique();

                    b.HasIndex("Longitude")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Order")
                        .IsUnique();

                    b.HasIndex("StartDate")
                        .IsUnique();

                    b.ToTable("Mansik");
                });

            modelBuilder.Entity("Entity.MaritalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("MaritalStatus");
                });

            modelBuilder.Entity("Entity.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<long?>("BirthplaceId");

                    b.Property<int?>("BloodTypeId");

                    b.Property<int?>("CategoryId");

                    b.Property<int?>("CityId");

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("DeathDate");

                    b.Property<string>("DeathDescription");

                    b.Property<int?>("DeathReasonId");

                    b.Property<long?>("DeathplaceId");

                    b.Property<int?>("DoctrineId");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("GenderId");

                    b.Property<int>("HomelandId");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("MaritalStatusId");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50);

                    b.Property<string>("Mobile")
                        .HasMaxLength(15);

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(15);

                    b.Property<byte[]>("Photo");

                    b.Property<int?>("StatusId");

                    b.Property<string>("ThirdName")
                        .HasMaxLength(50);

                    b.Property<int?>("TitleId");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("BirthplaceId");

                    b.HasIndex("BloodTypeId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("DeathReasonId");

                    b.HasIndex("DeathplaceId");

                    b.HasIndex("DoctrineId");

                    b.HasIndex("GenderId");

                    b.HasIndex("HomelandId");

                    b.HasIndex("MaritalStatusId");

                    b.HasIndex("NationalId")
                        .IsUnique();

                    b.HasIndex("StatusId");

                    b.HasIndex("TitleId");

                    b.HasIndex("TypeId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Entity.PersonAddress", b =>
                {
                    b.Property<int>("PersonId");

                    b.Property<long>("AddressId");

                    b.Property<int>("TypeId");

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<int?>("StatusId");

                    b.HasKey("PersonId", "AddressId", "TypeId");

                    b.HasIndex("AddressId");

                    b.HasIndex("TypeId");

                    b.ToTable("PersonAddress");
                });

            modelBuilder.Entity("Entity.PersonCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("PersonCategory");
                });

            modelBuilder.Entity("Entity.PersonLanguage", b =>
                {
                    b.Property<int>("PersonId");

                    b.Property<int>("LanguageId");

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.HasKey("PersonId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("PersonLanguage");
                });

            modelBuilder.Entity("Entity.PersonStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("PersonStatus");
                });

            modelBuilder.Entity("Entity.PersonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("PersonType");
                });

            modelBuilder.Entity("Entity.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Title");
                });

            modelBuilder.Entity("Entity.Address", b =>
                {
                    b.HasOne("Entity.BuildingType", "BuildingType")
                        .WithMany("Addresses")
                        .HasForeignKey("BuildingTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Entity.ApplicationRoleClaim", b =>
                {
                    b.HasOne("Entity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entity.ApplicationUserClaim", b =>
                {
                    b.HasOne("Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entity.ApplicationUserLogin", b =>
                {
                    b.HasOne("Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entity.ApplicationUserRole", b =>
                {
                    b.HasOne("Entity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entity.ApplicationUserToken", b =>
                {
                    b.HasOne("Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entity.BloodType", b =>
                {
                    b.HasOne("Entity.BloodGroup", "Group")
                        .WithMany("BloodTypes")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Entity.Campaign", b =>
                {
                    b.HasOne("Entity.Person", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorId");
                });

            modelBuilder.Entity("Entity.City", b =>
                {
                    b.HasOne("Entity.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Entity.Person", b =>
                {
                    b.HasOne("Entity.Address", "Birthplace")
                        .WithMany()
                        .HasForeignKey("BirthplaceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.BloodType", "BloodType")
                        .WithMany("People")
                        .HasForeignKey("BloodTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.PersonCategory", "Category")
                        .WithMany("People")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.City")
                        .WithMany("Population")
                        .HasForeignKey("CityId");

                    b.HasOne("Entity.DeathReason", "DeathReason")
                        .WithMany("People")
                        .HasForeignKey("DeathReasonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.Address", "Deathplace")
                        .WithMany()
                        .HasForeignKey("DeathplaceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.Doctrine", "Doctrine")
                        .WithMany("People")
                        .HasForeignKey("DoctrineId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.Gender", "Gender")
                        .WithMany("People")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.Country", "Homeland")
                        .WithMany("Population")
                        .HasForeignKey("HomelandId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.MaritalStatus", "MaritalStatus")
                        .WithMany("People")
                        .HasForeignKey("MaritalStatusId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.PersonStatus", "Status")
                        .WithMany("People")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.Title", "Title")
                        .WithMany("People")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.PersonType", "Type")
                        .WithMany("People")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Entity.PersonAddress", b =>
                {
                    b.HasOne("Entity.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.Person", "Person")
                        .WithMany("Addresses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.AddressType", "Type")
                        .WithMany("Addresses")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Entity.PersonLanguage", b =>
                {
                    b.HasOne("Entity.Language", "Language")
                        .WithMany("Speakers")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entity.Person", "Person")
                        .WithMany("Languages")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
