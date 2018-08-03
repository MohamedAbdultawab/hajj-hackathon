using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Core");

            migrationBuilder.CreateTable(
                name: "AddressType",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRole",
                schema: "Core",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                schema: "Core",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BloodGroup",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Symbol = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingType",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    ISO = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeathReason",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeathReason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctrine",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctrine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    ISO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mansik",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Order = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    Latitude = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mansik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonCategory",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonStatus",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonType",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRoleClaim",
                schema: "Core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationRoleClaim_ApplicationRole_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Core",
                        principalTable: "ApplicationRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserClaim",
                schema: "Core",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserClaim_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "Core",
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserLogin",
                schema: "Core",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_ApplicationUserLogin_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "Core",
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserRole",
                schema: "Core",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserRole_ApplicationRole_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Core",
                        principalTable: "ApplicationRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserRole_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "Core",
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserToken",
                schema: "Core",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_ApplicationUserToken_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "Core",
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BloodType",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Symbol = table.Column<string>(maxLength: 20, nullable: false),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BloodType_BloodGroup_GroupId",
                        column: x => x.GroupId,
                        principalSchema: "Core",
                        principalTable: "BloodGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Core",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Building = table.Column<string>(nullable: true),
                    BuildingTypeId = table.Column<int>(nullable: true),
                    Floor = table.Column<string>(nullable: true),
                    Apartment = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_BuildingType_BuildingTypeId",
                        column: x => x.BuildingTypeId,
                        principalSchema: "Core",
                        principalTable: "BuildingType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Core",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Core",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    ThirdName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    HomelandId = table.Column<int>(nullable: false),
                    NationalId = table.Column<string>(maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BirthplaceId = table.Column<long>(nullable: true),
                    DeathDate = table.Column<DateTime>(nullable: true),
                    DeathplaceId = table.Column<long>(nullable: true),
                    DeathReasonId = table.Column<int>(nullable: true),
                    DeathDescription = table.Column<string>(nullable: true),
                    BloodTypeId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    TypeId = table.Column<int>(nullable: true),
                    StatusId = table.Column<int>(nullable: true),
                    GenderId = table.Column<int>(nullable: false),
                    MaritalStatusId = table.Column<int>(nullable: true),
                    DoctrineId = table.Column<int>(nullable: true),
                    TitleId = table.Column<int>(nullable: true),
                    Photo = table.Column<byte[]>(nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(maxLength: 15, nullable: true),
                    Phone = table.Column<string>(maxLength: 15, nullable: true),
                    CityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Address_BirthplaceId",
                        column: x => x.BirthplaceId,
                        principalSchema: "Core",
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_BloodType_BloodTypeId",
                        column: x => x.BloodTypeId,
                        principalSchema: "Core",
                        principalTable: "BloodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_PersonCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "Core",
                        principalTable: "PersonCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Core",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_DeathReason_DeathReasonId",
                        column: x => x.DeathReasonId,
                        principalSchema: "Core",
                        principalTable: "DeathReason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Address_DeathplaceId",
                        column: x => x.DeathplaceId,
                        principalSchema: "Core",
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Doctrine_DoctrineId",
                        column: x => x.DoctrineId,
                        principalSchema: "Core",
                        principalTable: "Doctrine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Gender_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "Core",
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Country_HomelandId",
                        column: x => x.HomelandId,
                        principalSchema: "Core",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_MaritalStatus_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalSchema: "Core",
                        principalTable: "MaritalStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_PersonStatus_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "Core",
                        principalTable: "PersonStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Title_TitleId",
                        column: x => x.TitleId,
                        principalSchema: "Core",
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_PersonType_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "Core",
                        principalTable: "PersonType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Campaigns",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    SupervisorId = table.Column<int>(nullable: true),
                    PeopleNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campaigns_Person_SupervisorId",
                        column: x => x.SupervisorId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonAddress",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    AddressId = table.Column<long>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAddress", x => new { x.PersonId, x.AddressId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_PersonAddress_Address_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "Core",
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonAddress_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonAddress_AddressType_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "Core",
                        principalTable: "AddressType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonLanguage",
                schema: "Core",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonLanguage", x => new { x.PersonId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_PersonLanguage_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "Core",
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonLanguage_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_BuildingTypeId",
                schema: "Core",
                table: "Address",
                column: "BuildingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CityId",
                schema: "Core",
                table: "Address",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CountryId",
                schema: "Core",
                table: "Address",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressType_Name",
                schema: "Core",
                table: "AddressType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Core",
                table: "ApplicationRole",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRoleClaim_RoleId",
                schema: "Core",
                table: "ApplicationRoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Core",
                table: "ApplicationUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Core",
                table: "ApplicationUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserClaim_UserId",
                schema: "Core",
                table: "ApplicationUserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserLogin_UserId",
                schema: "Core",
                table: "ApplicationUserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserRole_RoleId",
                schema: "Core",
                table: "ApplicationUserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodGroup_Name",
                schema: "Core",
                table: "BloodGroup",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BloodGroup_Symbol",
                schema: "Core",
                table: "BloodGroup",
                column: "Symbol",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BloodType_GroupId",
                schema: "Core",
                table: "BloodType",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodType_Name",
                schema: "Core",
                table: "BloodType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BloodType_Symbol",
                schema: "Core",
                table: "BloodType",
                column: "Symbol",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BuildingType_Name",
                schema: "Core",
                table: "BuildingType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_SupervisorId",
                schema: "Core",
                table: "Campaigns",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId_Name",
                schema: "Core",
                table: "City",
                columns: new[] { "CountryId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Country_Name",
                schema: "Core",
                table: "Country",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeathReason_Name",
                schema: "Core",
                table: "DeathReason",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctrine_Name",
                schema: "Core",
                table: "Doctrine",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gender_Name",
                schema: "Core",
                table: "Gender",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Language_Name",
                schema: "Core",
                table: "Language",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mansik_Latitude",
                schema: "Core",
                table: "Mansik",
                column: "Latitude",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mansik_Longitude",
                schema: "Core",
                table: "Mansik",
                column: "Longitude",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mansik_Name",
                schema: "Core",
                table: "Mansik",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mansik_Order",
                schema: "Core",
                table: "Mansik",
                column: "Order",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mansik_StartDate",
                schema: "Core",
                table: "Mansik",
                column: "StartDate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaritalStatus_Name",
                schema: "Core",
                table: "MaritalStatus",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_BirthplaceId",
                schema: "Core",
                table: "Person",
                column: "BirthplaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_BloodTypeId",
                schema: "Core",
                table: "Person",
                column: "BloodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CategoryId",
                schema: "Core",
                table: "Person",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CityId",
                schema: "Core",
                table: "Person",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_DeathReasonId",
                schema: "Core",
                table: "Person",
                column: "DeathReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_DeathplaceId",
                schema: "Core",
                table: "Person",
                column: "DeathplaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_DoctrineId",
                schema: "Core",
                table: "Person",
                column: "DoctrineId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_GenderId",
                schema: "Core",
                table: "Person",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_HomelandId",
                schema: "Core",
                table: "Person",
                column: "HomelandId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_MaritalStatusId",
                schema: "Core",
                table: "Person",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_NationalId",
                schema: "Core",
                table: "Person",
                column: "NationalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_StatusId",
                schema: "Core",
                table: "Person",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_TitleId",
                schema: "Core",
                table: "Person",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_TypeId",
                schema: "Core",
                table: "Person",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_AddressId",
                schema: "Core",
                table: "PersonAddress",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_TypeId",
                schema: "Core",
                table: "PersonAddress",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCategory_Name",
                schema: "Core",
                table: "PersonCategory",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonLanguage_LanguageId",
                schema: "Core",
                table: "PersonLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonStatus_Name",
                schema: "Core",
                table: "PersonStatus",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonType_Name",
                schema: "Core",
                table: "PersonType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Title_Name",
                schema: "Core",
                table: "Title",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationRoleClaim",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "ApplicationUserClaim",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "ApplicationUserLogin",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "ApplicationUserRole",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "ApplicationUserToken",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Campaigns",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Mansik",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "PersonAddress",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "PersonLanguage",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "ApplicationRole",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "ApplicationUser",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "AddressType",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Language",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "BloodType",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "PersonCategory",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "DeathReason",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Doctrine",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Gender",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "MaritalStatus",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "PersonStatus",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Title",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "PersonType",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "BuildingType",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "City",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "BloodGroup",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "Core");
        }
    }
}
