using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abhadhi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abhadhi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgeGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AverageMonthlyIncome",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AverageMonthlyIncome", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Caste",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caste", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChronicDisease",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChronicDisease", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisabilityCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisabilityCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisabilityReason",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisabilityReason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisabilityType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisabilityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Earthquake2072",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Earthquake2072", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationalLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodCondition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCondition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEng = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseFloor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseFloor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseMapDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseMapDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseOwnership",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwnership", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseRoof",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseRoof", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NaturalDisaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturalDisaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OccupationDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolLayer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolLayer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolTime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalSkill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalSkill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WhereAreTheyNow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderByData = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhereAreTheyNow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designation_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PopulationDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardNo = table.Column<int>(type: "int", nullable: true),
                    ReligionId = table.Column<int>(type: "int", nullable: false),
                    IsMarried = table.Column<bool>(type: "bit", nullable: false),
                    IsBusinessSkill = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    HouseOwnerDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopulationDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PopulationDetail_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PopulationDetail_Religion_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ministry",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovermentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinisterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinisterEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinisterPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ministry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ministry_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StateDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<long>(type: "bigint", nullable: false),
                    Capital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChiefMinister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdensity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Governer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalDist = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StateDetail_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PopulationDetailAgeGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeGroupId = table.Column<int>(type: "int", nullable: false),
                    PopulationDetailId = table.Column<int>(type: "int", nullable: false),
                    Male = table.Column<int>(type: "int", nullable: false),
                    Female = table.Column<int>(type: "int", nullable: false),
                    Other = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopulationDetailAgeGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PopulationDetailAgeGroup_AgeGroup_AgeGroupId",
                        column: x => x.AgeGroupId,
                        principalTable: "AgeGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PopulationDetailAgeGroup_PopulationDetail_PopulationDetailId",
                        column: x => x.PopulationDetailId,
                        principalTable: "PopulationDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PopulationDetailCasteGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CasteId = table.Column<int>(type: "int", nullable: false),
                    PopulationId = table.Column<int>(type: "int", nullable: false),
                    Male = table.Column<int>(type: "int", nullable: false),
                    Female = table.Column<int>(type: "int", nullable: false),
                    Other = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopulationDetailCasteGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PopulationDetailCasteGroup_Caste_CasteId",
                        column: x => x.CasteId,
                        principalTable: "Caste",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PopulationDetailCasteGroup_PopulationDetail_PopulationId",
                        column: x => x.PopulationId,
                        principalTable: "PopulationDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PopulationDetailOccupationGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PopulationDetailId = table.Column<int>(type: "int", nullable: false),
                    OccupationDetailId = table.Column<int>(type: "int", nullable: false),
                    Male = table.Column<int>(type: "int", nullable: false),
                    Female = table.Column<int>(type: "int", nullable: false),
                    Other = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopulationDetailOccupationGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PopulationDetailOccupationGroup_OccupationDetail_OccupationDetailId",
                        column: x => x.OccupationDetailId,
                        principalTable: "OccupationDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PopulationDetailOccupationGroup_PopulationDetail_PopulationDetailId",
                        column: x => x.PopulationDetailId,
                        principalTable: "PopulationDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DistrictDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistId = table.Column<long>(type: "bigint", nullable: false),
                    HeadQuater = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pdensity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistrictDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistrictDetail_District_DistId",
                        column: x => x.DistId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalLevel",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistId = table.Column<long>(type: "bigint", nullable: false),
                    MaxWardNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalLevel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalLevel_District_DistId",
                        column: x => x.DistId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoricPlace",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricPlace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricPlace_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseOwnerDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardNo = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalFamilyCount = table.Column<int>(type: "int", nullable: true),
                    MaleFamilyCount = table.Column<int>(type: "int", nullable: true),
                    FemaleFamilyCount = table.Column<int>(type: "int", nullable: true),
                    OtherFamilyCount = table.Column<int>(type: "int", nullable: true),
                    TogetherCount = table.Column<int>(type: "int", nullable: true),
                    TogetherMaleCount = table.Column<int>(type: "int", nullable: true),
                    TogetherFemaleCount = table.Column<int>(type: "int", nullable: true),
                    TogetherOtherCount = table.Column<int>(type: "int", nullable: true),
                    ResidingCount = table.Column<int>(type: "int", nullable: true),
                    ResidingMaleCount = table.Column<int>(type: "int", nullable: true),
                    ResidingFemaleCount = table.Column<int>(type: "int", nullable: true),
                    ResidingOtherCount = table.Column<int>(type: "int", nullable: true),
                    ResidingAbroadCount = table.Column<int>(type: "int", nullable: true),
                    ResidingAbroadMaleCount = table.Column<int>(type: "int", nullable: true),
                    ResidingAbroadFemaleCount = table.Column<int>(type: "int", nullable: true),
                    ResidingAbroadOtherCount = table.Column<int>(type: "int", nullable: true),
                    HouseTypeId = table.Column<int>(type: "int", nullable: true),
                    IsUnEmployedMember = table.Column<bool>(type: "bit", nullable: true),
                    SkillTypeId = table.Column<int>(type: "int", nullable: true),
                    IsAnyBusiness = table.Column<bool>(type: "bit", nullable: true),
                    BusinessTypeId = table.Column<int>(type: "int", nullable: true),
                    IsLandLalPurja = table.Column<bool>(type: "bit", nullable: true),
                    IsLandOutOfPalika = table.Column<bool>(type: "bit", nullable: true),
                    LandOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandAnna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandRopani = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildrenSchoolType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: true),
                    IsNaturalDisasterArea = table.Column<bool>(type: "bit", nullable: true),
                    NaturalDisasterId = table.Column<int>(type: "int", nullable: true),
                    Earthquake2072Id = table.Column<int>(type: "int", nullable: true),
                    IsEarthquakeAnudan = table.Column<bool>(type: "bit", nullable: true),
                    EarthquakeKista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IsVehicle = table.Column<bool>(type: "bit", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    OldWardNo = table.Column<int>(type: "int", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GharKoPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarriedMan = table.Column<int>(type: "int", nullable: true),
                    UnMarriedMan = table.Column<int>(type: "int", nullable: true),
                    MarriedWoman = table.Column<int>(type: "int", nullable: true),
                    UnMarriedWoman = table.Column<int>(type: "int", nullable: true),
                    AnyHasFamilyMemberMoved = table.Column<bool>(type: "bit", nullable: true),
                    SeniorCitizensTotal = table.Column<int>(type: "int", nullable: true),
                    SeniorCitizensMan = table.Column<int>(type: "int", nullable: true),
                    SeniorCitizensWoman = table.Column<int>(type: "int", nullable: true),
                    SeniorCitizensOthers = table.Column<int>(type: "int", nullable: true),
                    AnySingleWomen = table.Column<bool>(type: "bit", nullable: true),
                    SingleWomenCount = table.Column<int>(type: "int", nullable: true),
                    AnyJesthaNagarik = table.Column<bool>(type: "bit", nullable: true),
                    AnyDisablePerson = table.Column<bool>(type: "bit", nullable: true),
                    TotalDisablePerson = table.Column<int>(type: "int", nullable: true),
                    MaleDisablePerson = table.Column<int>(type: "int", nullable: true),
                    FemaleDisablePerson = table.Column<int>(type: "int", nullable: true),
                    OtherDisablePerson = table.Column<int>(type: "int", nullable: true),
                    CardLinuVayo = table.Column<bool>(type: "bit", nullable: true),
                    KunCardLinuVayo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwnerDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseOwnerDetails_BusinessType_BusinessTypeId",
                        column: x => x.BusinessTypeId,
                        principalTable: "BusinessType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HouseOwnerDetails_Earthquake2072_Earthquake2072Id",
                        column: x => x.Earthquake2072Id,
                        principalTable: "Earthquake2072",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HouseOwnerDetails_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HouseOwnerDetails_HouseType_HouseTypeId",
                        column: x => x.HouseTypeId,
                        principalTable: "HouseType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HouseOwnerDetails_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HouseOwnerDetails_NaturalDisaster_NaturalDisasterId",
                        column: x => x.NaturalDisasterId,
                        principalTable: "NaturalDisaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HouseOwnerDetails_SkillType_SkillTypeId",
                        column: x => x.SkillTypeId,
                        principalTable: "SkillType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HouseOwnerDetails_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KaryalayaSetup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    PalikaId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wardno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KaryalayaSetup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KaryalayaSetup_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KaryalayaSetup_LocalLevel_PalikaId",
                        column: x => x.PalikaId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KaryalayaSetup_State_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalLevelDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Density = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalLevelDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalLevelDetail_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NagarikWadaPatra",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    Charge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeRequired = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NagarikWadaPatra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NagarikWadaPatra_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notice",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notice_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardNo = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ward_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AgricultureDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAnyAnimal = table.Column<bool>(type: "bit", nullable: false),
                    WardNo = table.Column<int>(type: "int", nullable: true),
                    IsLandLalPurja = table.Column<bool>(type: "bit", nullable: false),
                    HouseOwnerDetailId = table.Column<int>(type: "int", nullable: false),
                    AgricultureLand = table.Column<bool>(type: "bit", nullable: true),
                    AgricultureLandDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KrishiTathaPasupalanLand = table.Column<bool>(type: "bit", nullable: true),
                    PokhariMachapalan = table.Column<bool>(type: "bit", nullable: true),
                    SichaiSubidha = table.Column<bool>(type: "bit", nullable: true),
                    AgricultureProduct = table.Column<bool>(type: "bit", nullable: true),
                    AnimalProduct = table.Column<bool>(type: "bit", nullable: true),
                    ModernAgriculture = table.Column<bool>(type: "bit", nullable: true),
                    ModernAgricultureType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModernAgricultureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionCentre = table.Column<bool>(type: "bit", nullable: true),
                    CoolingCenter = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgricultureDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgricultureDetail_HouseOwnerDetails_HouseOwnerDetailId",
                        column: x => x.HouseOwnerDetailId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BalBibaha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseOwnerDetailId = table.Column<int>(type: "int", nullable: false),
                    Bihe5years = table.Column<bool>(type: "bit", nullable: true),
                    Vayekovaye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BiheKasariVayeko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChoraBiheKatiBarsa = table.Column<int>(type: "int", nullable: true),
                    BuhariKoUmer = table.Column<int>(type: "int", nullable: true),
                    ChoriBiheKatiBarsa = table.Column<int>(type: "int", nullable: true),
                    JwaiKoUmer = table.Column<int>(type: "int", nullable: true),
                    Santan = table.Column<int>(type: "int", nullable: true),
                    KatiSamayeSankyukta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneBarsaBihe = table.Column<bool>(type: "bit", nullable: true),
                    YediVayeko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KastoPrakarBihe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BiheGardaUmer = table.Column<int>(type: "int", nullable: true),
                    Daijo = table.Column<bool>(type: "bit", nullable: true),
                    KpraptaGarnuVoo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BihePaxadiAdhyan = table.Column<bool>(type: "bit", nullable: true),
                    ChaVaneyKunTaha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChainaVaneyKaran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UmerNapugiSamasya = table.Column<bool>(type: "bit", nullable: true),
                    KsamasyaAayo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BihePaxadiPrajanna = table.Column<bool>(type: "bit", nullable: true),
                    YediAayo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YediSanoUmer = table.Column<bool>(type: "bit", nullable: true),
                    AayoVaney = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BalBibahaKoSamasya = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BalBibahaKoBareyThaxa = table.Column<bool>(type: "bit", nullable: true),
                    BalBibahaBareyBichar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BalBibahaBareyKehiVannu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalBibaha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BalBibaha_HouseOwnerDetails_HouseOwnerDetailId",
                        column: x => x.HouseOwnerDetailId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EconomicDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsHouseRanted = table.Column<bool>(type: "bit", nullable: false),
                    IsAnyDebt = table.Column<bool>(type: "bit", nullable: false),
                    AverageMonthlyIncomeId = table.Column<int>(type: "int", nullable: false),
                    FoodConditionId = table.Column<int>(type: "int", nullable: false),
                    TechnicalSkillId = table.Column<int>(type: "int", nullable: false),
                    WardNo = table.Column<int>(type: "int", nullable: true),
                    HouseOwnerDetailId = table.Column<int>(type: "int", nullable: false),
                    MukhyaPeshaKho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KatiJanaSanglagna = table.Column<int>(type: "int", nullable: true),
                    Male = table.Column<int>(type: "int", nullable: true),
                    Female = table.Column<int>(type: "int", nullable: true),
                    Other = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconomicDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EconomicDetail_AverageMonthlyIncome_AverageMonthlyIncomeId",
                        column: x => x.AverageMonthlyIncomeId,
                        principalTable: "AverageMonthlyIncome",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EconomicDetail_FoodCondition_FoodConditionId",
                        column: x => x.FoodConditionId,
                        principalTable: "FoodCondition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EconomicDetail_HouseOwnerDetails_HouseOwnerDetailId",
                        column: x => x.HouseOwnerDetailId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardNo = table.Column<int>(type: "int", nullable: true),
                    HouseOwnerDetailId = table.Column<int>(type: "int", nullable: false),
                    AnyChild5To14GoingtoSchool = table.Column<bool>(type: "bit", nullable: true),
                    StayAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyChild10To19 = table.Column<bool>(type: "bit", nullable: true),
                    Child10To19Male = table.Column<int>(type: "int", nullable: true),
                    Child10To19Female = table.Column<int>(type: "int", nullable: true),
                    HaveFeedIronPillsForFemale = table.Column<bool>(type: "bit", nullable: true),
                    HaveTenagersFemaleTranningAboutHealth = table.Column<bool>(type: "bit", nullable: true),
                    AnyTorturePhysicalAndMental = table.Column<bool>(type: "bit", nullable: true),
                    AnyChildHaveNotGoToCollage = table.Column<bool>(type: "bit", nullable: true),
                    WhereAreTheyNowId = table.Column<int>(type: "int", nullable: true),
                    AnyVocationalTraning = table.Column<bool>(type: "bit", nullable: true),
                    VocationalTraningName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyViolenceOccurredYourChild = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterCaseAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyKamalariFemale = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDetail_HouseOwnerDetails_HouseOwnerDetailId",
                        column: x => x.HouseOwnerDetailId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationDetail_WhereAreTheyNow_WhereAreTheyNowId",
                        column: x => x.WhereAreTheyNowId,
                        principalTable: "WhereAreTheyNow",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GharMuliChildDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GharMuliId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoysCount = table.Column<int>(type: "int", nullable: true),
                    GirlsCount = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IranChakkiEat = table.Column<bool>(type: "bit", nullable: true),
                    SexEducationKnown = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GharMuliChildDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GharMuliChildDetail_HouseOwnerDetails_GharMuliId",
                        column: x => x.GharMuliId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GharMuliFamilyMarrageDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GharMuliId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    MarrageDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarrageDateEng = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarrageTimeAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GharMuliFamilyMarrageDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GharMuliFamilyMarrageDetail_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GharMuliFamilyMarrageDetail_HouseOwnerDetails_GharMuliId",
                        column: x => x.GharMuliId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardNo = table.Column<int>(type: "int", nullable: true),
                    IsChronicDiseases = table.Column<bool>(type: "bit", nullable: false),
                    IsDisabilityFamily = table.Column<bool>(type: "bit", nullable: false),
                    HouseOwnerDetailId = table.Column<int>(type: "int", nullable: false),
                    SchoolC23 = table.Column<bool>(type: "bit", nullable: true),
                    UpacharWhere = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthDetail_HouseOwnerDetails_HouseOwnerDetailId",
                        column: x => x.HouseOwnerDetailId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardNo = table.Column<int>(type: "int", nullable: true),
                    HouseFloorId = table.Column<int>(type: "int", nullable: false),
                    HouseRoofId = table.Column<int>(type: "int", nullable: false),
                    HouseMapId = table.Column<int>(type: "int", nullable: false),
                    HouseOwnershipId = table.Column<int>(type: "int", nullable: false),
                    HouseOwnerDetailId = table.Column<int>(type: "int", nullable: false),
                    AnySuggestions1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseDetail_HouseFloor_HouseFloorId",
                        column: x => x.HouseFloorId,
                        principalTable: "HouseFloor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseDetail_HouseMapDetail_HouseMapId",
                        column: x => x.HouseMapId,
                        principalTable: "HouseMapDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseDetail_HouseOwnerDetails_HouseOwnerDetailId",
                        column: x => x.HouseOwnerDetailId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseDetail_HouseOwnership_HouseOwnershipId",
                        column: x => x.HouseOwnershipId,
                        principalTable: "HouseOwnership",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseDetail_HouseRoof_HouseRoofId",
                        column: x => x.HouseRoofId,
                        principalTable: "HouseRoof",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseOwnerAbdhiGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbhadhiId = table.Column<int>(type: "int", nullable: false),
                    HouseOwnerId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwnerAbdhiGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseOwnerAbdhiGroup_Abhadhi_AbhadhiId",
                        column: x => x.AbhadhiId,
                        principalTable: "Abhadhi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseOwnerAbdhiGroup_HouseOwnerDetails_HouseOwnerId",
                        column: x => x.HouseOwnerId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseOwnerCountryGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    HouseOwnerId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwnerCountryGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseOwnerCountryGroup_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseOwnerCountryGroup_HouseOwnerDetails_HouseOwnerId",
                        column: x => x.HouseOwnerId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseOwnerFamilyDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseOwnerDetailsId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dobeng = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDisability = table.Column<bool>(type: "bit", nullable: false),
                    EducationLevelId = table.Column<int>(type: "int", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsChildDarta = table.Column<bool>(type: "bit", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nata = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwnerFamilyDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseOwnerFamilyDetail_HouseOwnerDetails_HouseOwnerDetailsId",
                        column: x => x.HouseOwnerDetailsId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovedFamilyMemberDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseOwnerDetailsId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalMale = table.Column<int>(type: "int", nullable: true),
                    TotalFemale = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovedFamilyMemberDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovedFamilyMemberDetail_HouseOwnerDetails_HouseOwnerDetailsId",
                        column: x => x.HouseOwnerDetailsId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MultisectoralNutritionAndExtension",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseOwnerDetailId = table.Column<int>(type: "int", nullable: false),
                    AnyPregnancy = table.Column<bool>(type: "bit", nullable: true),
                    AnySleepMotherInYourHouse = table.Column<bool>(type: "bit", nullable: true),
                    AnyHivcase = table.Column<bool>(type: "bit", nullable: true),
                    ThapKhanaKhuwaunu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBornChildHivinfected = table.Column<bool>(type: "bit", nullable: true),
                    Arvprophylaxis = table.Column<bool>(type: "bit", nullable: true),
                    Is12YearChild = table.Column<bool>(type: "bit", nullable: true),
                    ChildKhopDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is16YearChild = table.Column<bool>(type: "bit", nullable: true),
                    IsKhopCard = table.Column<bool>(type: "bit", nullable: true),
                    SixMto5YbitminAkhopPatak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTo5YjukaKhopPatak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is24Mchaild = table.Column<bool>(type: "bit", nullable: true),
                    IsWeighted = table.Column<bool>(type: "bit", nullable: true),
                    HowManyTimes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightThau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyChildHealthIssue = table.Column<bool>(type: "bit", nullable: true),
                    HealthIssuColorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EatNunType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyDiarrheaIssue = table.Column<bool>(type: "bit", nullable: true),
                    DiarrheaTimeEatJinkChaki = table.Column<bool>(type: "bit", nullable: true),
                    DiarrheaTimeEatDays = table.Column<int>(type: "int", nullable: true),
                    DiarrheaTimeEatPunJaliyaJhol = table.Column<bool>(type: "bit", nullable: true),
                    IsNotGoToSchool5To14Child = table.Column<bool>(type: "bit", nullable: true),
                    CurrentAddeess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Child10To19Ypresent = table.Column<bool>(type: "bit", nullable: true),
                    BoysCount = table.Column<int>(type: "int", nullable: true),
                    GirlsCounts = table.Column<int>(type: "int", nullable: true),
                    SchoolC23 = table.Column<bool>(type: "bit", nullable: true),
                    IsChildAfter1To8EductionStop = table.Column<bool>(type: "bit", nullable: true),
                    ChildAddreee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildSipmulkTalim = table.Column<bool>(type: "bit", nullable: true),
                    TalimName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyViolenceInYourFamily = table.Column<bool>(type: "bit", nullable: true),
                    ViolenceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViolenceRegister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LadisRajashwala = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyLadisKamalari = table.Column<bool>(type: "bit", nullable: true),
                    AnyUpToThreeYearAnyMarrage = table.Column<bool>(type: "bit", nullable: true),
                    AnySunoloPresentDayAama = table.Column<bool>(type: "bit", nullable: true),
                    SunoloTimeKahneKuraChalFul = table.Column<bool>(type: "bit", nullable: true),
                    AnyCasualtiesDuringCovid = table.Column<bool>(type: "bit", nullable: true),
                    CasualtiesCount = table.Column<int>(type: "int", nullable: true),
                    AnyCovidDose = table.Column<bool>(type: "bit", nullable: true),
                    OuterMemberPresentInOurFamily = table.Column<bool>(type: "bit", nullable: true),
                    UpacharWhere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyDisaster = table.Column<bool>(type: "bit", nullable: true),
                    DisasterType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloodDisasterWaterJach = table.Column<bool>(type: "bit", nullable: true),
                    FloodDisasterjachDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDrinkingWaterAvilable = table.Column<bool>(type: "bit", nullable: true),
                    DrinkingWaterShrot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrinkingWaterQualityCheck = table.Column<bool>(type: "bit", nullable: true),
                    DrinkingWaterQualityCheckDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrinkingWaterQualityCheckTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToilatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToliteCleaningTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SabunPaniLeHandWashBani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GharayahiKhanePaniRealtedTraning = table.Column<bool>(type: "bit", nullable: true),
                    IsHouseRanted = table.Column<bool>(type: "bit", nullable: true),
                    HouseRentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsedWaterUseForOtherUse = table.Column<bool>(type: "bit", nullable: true),
                    UsedWaterUseForOtherUseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsKaresabariAvilable = table.Column<bool>(type: "bit", nullable: true),
                    KaresabariArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowToAvilableFreshVegitable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreYourFamilyEatProperly = table.Column<bool>(type: "bit", nullable: true),
                    MassuShrot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyCooperative = table.Column<bool>(type: "bit", nullable: true),
                    CooperativeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyRegionalTalim = table.Column<bool>(type: "bit", nullable: true),
                    AnyNaturalMedicialKnowlage = table.Column<bool>(type: "bit", nullable: true),
                    IsUseNaturalMedicial = table.Column<bool>(type: "bit", nullable: true),
                    AnyKnowlageOfOrganicMatter = table.Column<bool>(type: "bit", nullable: true),
                    AnyUseOfNaturalSewage = table.Column<bool>(type: "bit", nullable: true),
                    AnyUseOfChemicalFertilizer = table.Column<bool>(type: "bit", nullable: true),
                    ChemicalFertilizerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowToCookFood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBuyVegitableInMarket = table.Column<bool>(type: "bit", nullable: true),
                    IsBuyFruitsInMarket = table.Column<bool>(type: "bit", nullable: true),
                    AnyHouseForAminal = table.Column<bool>(type: "bit", nullable: true),
                    AnimalHouseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsumeMilkAndMilkProduct = table.Column<bool>(type: "bit", nullable: true),
                    MilkAndMilkProductMedium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilkAndMilkProductLiter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyAnimalForMilkProduce = table.Column<bool>(type: "bit", nullable: true),
                    MilkInLiter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellMillInLiter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MassuCossumeDays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MassuConsumeInKg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConssumeEggs = table.Column<bool>(type: "bit", nullable: true),
                    ConssumeEggsTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConssumeEggCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreYouVisitGovermentOffice = table.Column<bool>(type: "bit", nullable: true),
                    FeedBackForEmployee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitToHealthCare = table.Column<bool>(type: "bit", nullable: true),
                    FeedbackAboutHealthcareEmployee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthCareService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnySuggestions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnySuggestions1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncomeShrotAgriculture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncomeYearly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyOtherIncomeSource = table.Column<bool>(type: "bit", nullable: true),
                    OtherIncomeSourceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherIncomeYearly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyBusiness = table.Column<bool>(type: "bit", nullable: true),
                    FamilyBusinessNo = table.Column<int>(type: "int", nullable: true),
                    FamilyEmployment = table.Column<bool>(type: "bit", nullable: true),
                    FamilyEmploymentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyEmploymentDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyProductQuality = table.Column<bool>(type: "bit", nullable: true),
                    FamilyProductEnough = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultisectoralNutritionAndExtension", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultisectoralNutritionAndExtension_HouseOwnerDetails_HouseOwnerDetailId",
                        column: x => x.HouseOwnerDetailId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PregnancyDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmmaKoNam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GarvRaheKoPatak = table.Column<int>(type: "int", nullable: false),
                    GarvPrachianPatak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ttkhopa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhatDoUeat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GharMuliId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PregnancyDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PregnancyDetail_HouseOwnerDetails_GharMuliId",
                        column: x => x.GharMuliId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SleepMotherDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GharMuliId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrasutiAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrasutiJach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IranChakkiDays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSixMonthCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsSixMonthEatMotherMilk = table.Column<bool>(type: "bit", nullable: false),
                    AfterSixMonth = table.Column<bool>(type: "bit", nullable: false),
                    ThapKhanaKoNam = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepMotherDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SleepMotherDetail_HouseOwnerDetails_GharMuliId",
                        column: x => x.GharMuliId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WhereAreTheyNowDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseOwnerDetailsId = table.Column<int>(type: "int", nullable: false),
                    WhereAreTheyNowId = table.Column<int>(type: "int", nullable: false),
                    MaleCount = table.Column<int>(type: "int", nullable: true),
                    FemaleCount = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhereAreTheyNowDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhereAreTheyNowDetail_HouseOwnerDetails_HouseOwnerDetailsId",
                        column: x => x.HouseOwnerDetailsId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WhereAreTheyNowDetail_WhereAreTheyNow_WhereAreTheyNowId",
                        column: x => x.WhereAreTheyNowId,
                        principalTable: "WhereAreTheyNow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NagarikWadaPatraDoc",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NagarikWadaPatraId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NagarikWadaPatraDoc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NagarikWadaPatraDoc_NagarikWadaPatra_NagarikWadaPatraId",
                        column: x => x.NagarikWadaPatraId,
                        principalTable: "NagarikWadaPatra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Airport",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Airport_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Airport_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Atm",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atm_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atm_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BloodBank",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodBankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodBank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BloodBank_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BloodBank_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    DesignationId = table.Column<long>(type: "bigint", nullable: false),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Designation_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GharMuliDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    CasteId = table.Column<int>(type: "int", nullable: true),
                    ReligionId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    Village = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GharNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldWardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GharKoPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GharMuliDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GharMuliDetail_Caste_CasteId",
                        column: x => x.CasteId,
                        principalTable: "Caste",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GharMuliDetail_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GharMuliDetail_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GharMuliDetail_Religion_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GharMuliDetail_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HealthFacility",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthFacility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthFacility_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthFacility_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotel_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hotel_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HouseOwnerCode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalLavelId = table.Column<long>(type: "bigint", nullable: false),
                    WardId = table.Column<long>(type: "bigint", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    HouseOwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseOwnerCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseOwnerCode_HouseOwnerDetails_HouseOwnerId",
                        column: x => x.HouseOwnerId,
                        principalTable: "HouseOwnerDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseOwnerCode_LocalLevel_LocalLavelId",
                        column: x => x.LocalLavelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseOwnerCode_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HydroPower",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HydroStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydroPower", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HydroPower_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HydroPower_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Industry",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Industry_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Institution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    School = table.Column<int>(type: "int", nullable: true),
                    GovernmentOffice = table.Column<int>(type: "int", nullable: true),
                    Bank = table.Column<int>(type: "int", nullable: true),
                    HealthPost = table.Column<int>(type: "int", nullable: true),
                    Industry = table.Column<int>(type: "int", nullable: true),
                    CulturalHeritage = table.Column<int>(type: "int", nullable: true),
                    NaturalResource = table.Column<int>(type: "int", nullable: true),
                    TownWardOffice = table.Column<int>(type: "int", nullable: true),
                    WardNo = table.Column<long>(type: "bigint", nullable: false),
                    SecurityAgencies = table.Column<int>(type: "int", nullable: true),
                    WardNoNavigationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institution", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Institution_Ward_WardNoNavigationId",
                        column: x => x.WardNoNavigationId,
                        principalTable: "Ward",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JanPratinidhi",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desiganation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JanPratinidhi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JanPratinidhi_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JanPratinidhi_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lake",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lake", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lake_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lake_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Mountain",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mountain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mountain_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mountain_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PoliceStation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoliceStation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoliceStation_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PoliceStation_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcceptedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BenefitFamilyNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommitteeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommitteeHeadName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommitteeHeadPhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentageOfWorkDone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThekdarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThekdarPhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Project_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProtectedArea",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectedArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProtectedArea_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProtectedArea_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sikshya",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sikshya", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sikshya_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sikshya_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sikshya_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sikshya_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    LocalLevel = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LocalLevelNavigationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetail_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetail_LocalLevel_LocalLevelNavigationId",
                        column: x => x.LocalLevelNavigationId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetail_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetail_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WardDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Density = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Popullation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WardDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WardDetail_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WaterFall",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<long>(type: "bigint", nullable: true),
                    LocalLevelId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterFall", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterFall_LocalLevel_LocalLevelId",
                        column: x => x.LocalLevelId,
                        principalTable: "LocalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WaterFall_Ward_WardId",
                        column: x => x.WardId,
                        principalTable: "Ward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AgricultureDetailAnimalGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    AgricultureDetailId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgricultureDetailAnimalGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgricultureDetailAnimalGroup_AgricultureDetail_AgricultureDetailId",
                        column: x => x.AgricultureDetailId,
                        principalTable: "AgricultureDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgricultureDetailAnimalGroup_Animal_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgriculturePasuPanchiDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgricultureDetailId = table.Column<int>(type: "int", nullable: true),
                    PasuPanchi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pariman = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgriculturePasuPanchiDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgriculturePasuPanchiDetail_AgricultureDetail_AgricultureDetailId",
                        column: x => x.AgricultureDetailId,
                        principalTable: "AgricultureDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AgricultureProductDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgricultureDetailId = table.Column<int>(type: "int", nullable: true),
                    BaliKoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pariman = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgricultureProductDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgricultureProductDetail_AgricultureDetail_AgricultureDetailId",
                        column: x => x.AgricultureDetailId,
                        principalTable: "AgricultureDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AgricultureProductQuantity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgricultureDetailId = table.Column<int>(type: "int", nullable: true),
                    Milk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Egg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgricultureProductQuantity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgricultureProductQuantity_AgricultureDetail_AgricultureDetailId",
                        column: x => x.AgricultureDetailId,
                        principalTable: "AgricultureDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EconomicDetailTechnicalSkillGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EconomicDetailId = table.Column<int>(type: "int", nullable: false),
                    TechnicalSkillId = table.Column<int>(type: "int", nullable: false),
                    Male = table.Column<int>(type: "int", nullable: false),
                    Female = table.Column<int>(type: "int", nullable: false),
                    Other = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconomicDetailTechnicalSkillGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EconomicDetailTechnicalSkillGroup_EconomicDetail_EconomicDetailId",
                        column: x => x.EconomicDetailId,
                        principalTable: "EconomicDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EconomicDetailTechnicalSkillGroup_TechnicalSkill_TechnicalSkillId",
                        column: x => x.TechnicalSkillId,
                        principalTable: "TechnicalSkill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationDetailSchoolGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolLayerId = table.Column<int>(type: "int", nullable: false),
                    SchoolTimeId = table.Column<int>(type: "int", nullable: false),
                    EducationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDetailSchoolGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDetailSchoolGroup_EducationDetail_EducationId",
                        column: x => x.EducationId,
                        principalTable: "EducationDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationDetailSchoolGroup_SchoolLayer_SchoolLayerId",
                        column: x => x.SchoolLayerId,
                        principalTable: "SchoolLayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationDetailSchoolGroup_SchoolTime_SchoolTimeId",
                        column: x => x.SchoolTimeId,
                        principalTable: "SchoolTime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationEducationalLevelGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationId = table.Column<int>(type: "int", nullable: false),
                    EducationalLevelId = table.Column<int>(type: "int", nullable: false),
                    Male = table.Column<int>(type: "int", nullable: false),
                    Female = table.Column<int>(type: "int", nullable: false),
                    Other = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationEducationalLevelGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationEducationalLevelGroup_EducationDetail_EducationId",
                        column: x => x.EducationId,
                        principalTable: "EducationDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationEducationalLevelGroup_EducationalLevel_EducationalLevelId",
                        column: x => x.EducationalLevelId,
                        principalTable: "EducationalLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthDetailChronicDiseaseGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChronicDiseaseId = table.Column<int>(type: "int", nullable: false),
                    HealthDetailIid = table.Column<int>(type: "int", nullable: false),
                    Male = table.Column<int>(type: "int", nullable: false),
                    Female = table.Column<int>(type: "int", nullable: false),
                    Other = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthDetailChronicDiseaseGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthDetailChronicDiseaseGroup_ChronicDisease_ChronicDiseaseId",
                        column: x => x.ChronicDiseaseId,
                        principalTable: "ChronicDisease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthDetailChronicDiseaseGroup_HealthDetail_HealthDetailIid",
                        column: x => x.HealthDetailIid,
                        principalTable: "HealthDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthDetailDisabilityCardGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthDetailId = table.Column<int>(type: "int", nullable: false),
                    DisabilityCardId = table.Column<int>(type: "int", nullable: false),
                    Male = table.Column<int>(type: "int", nullable: false),
                    Female = table.Column<int>(type: "int", nullable: false),
                    Other = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthDetailDisabilityCardGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthDetailDisabilityCardGroup_DisabilityCard_DisabilityCardId",
                        column: x => x.DisabilityCardId,
                        principalTable: "DisabilityCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthDetailDisabilityCardGroup_HealthDetail_HealthDetailId",
                        column: x => x.HealthDetailId,
                        principalTable: "HealthDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthDetailDisabilityReasonGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisabilityReasonId = table.Column<int>(type: "int", nullable: false),
                    HealthDetailId = table.Column<int>(type: "int", nullable: false),
                    Male = table.Column<int>(type: "int", nullable: false),
                    Female = table.Column<int>(type: "int", nullable: false),
                    Other = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthDetailDisabilityReasonGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthDetailDisabilityReasonGroup_DisabilityReason_DisabilityReasonId",
                        column: x => x.DisabilityReasonId,
                        principalTable: "DisabilityReason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthDetailDisabilityReasonGroup_HealthDetail_HealthDetailId",
                        column: x => x.HealthDetailId,
                        principalTable: "HealthDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthDetailDisabilityTypeGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthDetailId = table.Column<int>(type: "int", nullable: false),
                    DisabilityTypeId = table.Column<int>(type: "int", nullable: false),
                    Male = table.Column<int>(type: "int", nullable: false),
                    Female = table.Column<int>(type: "int", nullable: false),
                    Other = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthDetailDisabilityTypeGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthDetailDisabilityTypeGroup_DisabilityType_DisabilityTypeId",
                        column: x => x.DisabilityTypeId,
                        principalTable: "DisabilityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthDetailDisabilityTypeGroup_HealthDetail_HealthDetailId",
                        column: x => x.HealthDetailId,
                        principalTable: "HealthDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GharMuliEconomicStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GharMuliId = table.Column<int>(type: "int", nullable: false),
                    IncomeShrotAgriculture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncomeYearly = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AnyOtherIncomeSource = table.Column<bool>(type: "bit", nullable: true),
                    OtherIncomeSourceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherIncomeYearly = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FamilyBusiness = table.Column<bool>(type: "bit", nullable: true),
                    FamilyBusinessNo = table.Column<int>(type: "int", nullable: true),
                    FamilyEmployment = table.Column<bool>(type: "bit", nullable: true),
                    FamilyEmploymentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyEmploymentDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyProductQuality = table.Column<bool>(type: "bit", nullable: true),
                    FamilyProductEnough = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GharMuliEconomicStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GharMuliEconomicStatus_GharMuliDetail_GharMuliId",
                        column: x => x.GharMuliId,
                        principalTable: "GharMuliDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GharMuliFamilyDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GharMuliId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dobeng = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDisability = table.Column<bool>(type: "bit", nullable: false),
                    EducationLevelId = table.Column<int>(type: "int", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsChildDarta = table.Column<bool>(type: "bit", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nata = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GharMuliFamilyDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GharMuliFamilyDetail_EducationalLevel_EducationLevelId",
                        column: x => x.EducationLevelId,
                        principalTable: "EducationalLevel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GharMuliFamilyDetail_GharMuliDetail_GharMuliId",
                        column: x => x.GharMuliId,
                        principalTable: "GharMuliDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GharMuliHealthDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GharMuliId = table.Column<int>(type: "int", nullable: false),
                    AnyPregnancy = table.Column<bool>(type: "bit", nullable: true),
                    AnySleepMotherInYourHouse = table.Column<bool>(type: "bit", nullable: true),
                    AnyHivcase = table.Column<bool>(type: "bit", nullable: false),
                    IsBornChildHivinfected = table.Column<bool>(type: "bit", nullable: true),
                    Arvprophylaxis = table.Column<bool>(type: "bit", nullable: true),
                    Is12YearChild = table.Column<bool>(type: "bit", nullable: false),
                    ChildKhopDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is16YearChild = table.Column<bool>(type: "bit", nullable: false),
                    IsKhopCard = table.Column<bool>(type: "bit", nullable: true),
                    SixMto5YbitminAkhopPatak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTo5YjukaKhopPatak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is24Mchaild = table.Column<bool>(type: "bit", nullable: false),
                    IsWeighted = table.Column<bool>(type: "bit", nullable: true),
                    HowManyTimes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightThau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyChildHealthIssue = table.Column<bool>(type: "bit", nullable: false),
                    HealthIssuColorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EatNunType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyDiarrheaIssue = table.Column<bool>(type: "bit", nullable: false),
                    DiarrheaTimeEatJinkChaki = table.Column<bool>(type: "bit", nullable: true),
                    DiarrheaTimeEatDays = table.Column<int>(type: "int", nullable: true),
                    DiarrheaTimeEatPunJaliyaJhol = table.Column<bool>(type: "bit", nullable: true),
                    IsNotGoToSchool5To14Child = table.Column<bool>(type: "bit", nullable: false),
                    CurrentAddeess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Child10To19Ypresent = table.Column<bool>(type: "bit", nullable: false),
                    BoysCount = table.Column<int>(type: "int", nullable: true),
                    GirlsCounts = table.Column<int>(type: "int", nullable: true),
                    SchoolC23 = table.Column<bool>(type: "bit", nullable: false),
                    IsChildAfter1To8EductionStop = table.Column<bool>(type: "bit", nullable: true),
                    ChildAddreee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildSipmulkTalim = table.Column<bool>(type: "bit", nullable: true),
                    TalimName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyViolenceInYourFamily = table.Column<bool>(type: "bit", nullable: true),
                    ViolenceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViolenceRegister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LadisRajashwala = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyLadisKamalari = table.Column<bool>(type: "bit", nullable: true),
                    AnyUpToThreeYearAnyMarrage = table.Column<bool>(type: "bit", nullable: false),
                    AnySunoloPresentDayAama = table.Column<bool>(type: "bit", nullable: false),
                    SunoloTimeKahneKuraChalFul = table.Column<bool>(type: "bit", nullable: true),
                    AnyCasualtiesDuringCovid = table.Column<bool>(type: "bit", nullable: false),
                    CasualtiesCount = table.Column<int>(type: "int", nullable: true),
                    AnyCovidDose = table.Column<bool>(type: "bit", nullable: false),
                    OuterMemberPresentInOurFamily = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GharMuliHealthDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GharMuliHealthDetail_GharMuliDetail_GharMuliId",
                        column: x => x.GharMuliId,
                        principalTable: "GharMuliDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GharMuliKhanePaniAndAawasDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GharMuliId = table.Column<int>(type: "int", nullable: false),
                    AnyDisaster = table.Column<bool>(type: "bit", nullable: false),
                    DisasterType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloodDisasterWaterJach = table.Column<bool>(type: "bit", nullable: true),
                    FloodDisasterjachDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDrinkingWaterAvilable = table.Column<bool>(type: "bit", nullable: true),
                    DrinkingWaterShrot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrinkingWaterQualityCheck = table.Column<bool>(type: "bit", nullable: true),
                    DrinkingWaterQualityCheckDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrinkingWaterQualityCheckTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToilatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToliteCleaningTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SabunPaniLeHandWashBani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GharayahiKhanePaniRealtedTraning = table.Column<bool>(type: "bit", nullable: true),
                    IsHouseRanted = table.Column<bool>(type: "bit", nullable: true),
                    HouseRentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsedWaterUseForOtherUse = table.Column<bool>(type: "bit", nullable: true),
                    UsedWaterUseForOtherUseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsKaresabariAvilable = table.Column<bool>(type: "bit", nullable: true),
                    KaresabariArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowToAvilableFreshVegitable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreYourFamilyEatProperly = table.Column<bool>(type: "bit", nullable: true),
                    MassuShrot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyCooperative = table.Column<bool>(type: "bit", nullable: true),
                    CooperativeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyRegionalTalim = table.Column<bool>(type: "bit", nullable: true),
                    AnyNaturalMedicialKnowlage = table.Column<bool>(type: "bit", nullable: true),
                    IsUseNaturalMedicial = table.Column<bool>(type: "bit", nullable: true),
                    AnyKnowlageOfOrganicMatter = table.Column<bool>(type: "bit", nullable: true),
                    AnyUseOfNaturalSewage = table.Column<bool>(type: "bit", nullable: true),
                    AnyUseOfChemicalFertilizer = table.Column<bool>(type: "bit", nullable: true),
                    ChemicalFertilizerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowToCookFood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBuyVegitableInMarket = table.Column<bool>(type: "bit", nullable: true),
                    IsBuyFruitsInMarket = table.Column<bool>(type: "bit", nullable: true),
                    AnyHouseForAminal = table.Column<bool>(type: "bit", nullable: true),
                    AnimalHouseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsumeMilkAndMilkProduct = table.Column<bool>(type: "bit", nullable: true),
                    MilkAndMilkProductMedium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilkAndMilkProductLiter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyAnimalForMilkProduce = table.Column<bool>(type: "bit", nullable: true),
                    MilkInLiter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellMillInLiter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MassuCossumeDays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MassuConsumeInKg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConssumeEggs = table.Column<bool>(type: "bit", nullable: true),
                    ConssumeEggsTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConssumeEggCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreYouVisitGovermentOffice = table.Column<bool>(type: "bit", nullable: true),
                    FeedBackForEmployee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitToHealthCare = table.Column<bool>(type: "bit", nullable: true),
                    FeedbackAboutHealthcareEmployee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthCareService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnySuggestions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnySuggestions1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GharMuliKhanePaniAndAawasDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GharMuliKhanePaniAndAawasDetail_GharMuliDetail_GharMuliId",
                        column: x => x.GharMuliId,
                        principalTable: "GharMuliDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgricultureDetail_HouseOwnerDetailId",
                table: "AgricultureDetail",
                column: "HouseOwnerDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AgricultureDetailAnimalGroup_AgricultureDetailId",
                table: "AgricultureDetailAnimalGroup",
                column: "AgricultureDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AgricultureDetailAnimalGroup_AnimalId",
                table: "AgricultureDetailAnimalGroup",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AgriculturePasuPanchiDetail_AgricultureDetailId",
                table: "AgriculturePasuPanchiDetail",
                column: "AgricultureDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AgricultureProductDetail_AgricultureDetailId",
                table: "AgricultureProductDetail",
                column: "AgricultureDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AgricultureProductQuantity_AgricultureDetailId",
                table: "AgricultureProductQuantity",
                column: "AgricultureDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Airport_LocalLevelId",
                table: "Airport",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Airport_WardId",
                table: "Airport",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Atm_LocalLevelId",
                table: "Atm",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Atm_WardId",
                table: "Atm",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_BalBibaha_HouseOwnerDetailId",
                table: "BalBibaha",
                column: "HouseOwnerDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodBank_LocalLevelId",
                table: "BloodBank",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodBank_WardId",
                table: "BloodBank",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Designation_DepartmentId",
                table: "Designation",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_District_StateId",
                table: "District",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_DistrictDetail_DistId",
                table: "DistrictDetail",
                column: "DistId");

            migrationBuilder.CreateIndex(
                name: "IX_EconomicDetail_AverageMonthlyIncomeId",
                table: "EconomicDetail",
                column: "AverageMonthlyIncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_EconomicDetail_FoodConditionId",
                table: "EconomicDetail",
                column: "FoodConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_EconomicDetail_HouseOwnerDetailId",
                table: "EconomicDetail",
                column: "HouseOwnerDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EconomicDetailTechnicalSkillGroup_EconomicDetailId",
                table: "EconomicDetailTechnicalSkillGroup",
                column: "EconomicDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EconomicDetailTechnicalSkillGroup_TechnicalSkillId",
                table: "EconomicDetailTechnicalSkillGroup",
                column: "TechnicalSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetail_HouseOwnerDetailId",
                table: "EducationDetail",
                column: "HouseOwnerDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetail_WhereAreTheyNowId",
                table: "EducationDetail",
                column: "WhereAreTheyNowId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetailSchoolGroup_EducationId",
                table: "EducationDetailSchoolGroup",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetailSchoolGroup_SchoolLayerId",
                table: "EducationDetailSchoolGroup",
                column: "SchoolLayerId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetailSchoolGroup_SchoolTimeId",
                table: "EducationDetailSchoolGroup",
                column: "SchoolTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationEducationalLevelGroup_EducationalLevelId",
                table: "EducationEducationalLevelGroup",
                column: "EducationalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationEducationalLevelGroup_EducationId",
                table: "EducationEducationalLevelGroup",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DesignationId",
                table: "Employee",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_LocalLevelId",
                table: "Employee",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_WardId",
                table: "Employee",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliChildDetail_GharMuliId",
                table: "GharMuliChildDetail",
                column: "GharMuliId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliDetail_CasteId",
                table: "GharMuliDetail",
                column: "CasteId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliDetail_GenderId",
                table: "GharMuliDetail",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliDetail_LanguageId",
                table: "GharMuliDetail",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliDetail_ReligionId",
                table: "GharMuliDetail",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliDetail_WardId",
                table: "GharMuliDetail",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliEconomicStatus_GharMuliId",
                table: "GharMuliEconomicStatus",
                column: "GharMuliId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliFamilyDetail_EducationLevelId",
                table: "GharMuliFamilyDetail",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliFamilyDetail_GharMuliId",
                table: "GharMuliFamilyDetail",
                column: "GharMuliId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliFamilyMarrageDetail_GenderId",
                table: "GharMuliFamilyMarrageDetail",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliFamilyMarrageDetail_GharMuliId",
                table: "GharMuliFamilyMarrageDetail",
                column: "GharMuliId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliHealthDetail_GharMuliId",
                table: "GharMuliHealthDetail",
                column: "GharMuliId");

            migrationBuilder.CreateIndex(
                name: "IX_GharMuliKhanePaniAndAawasDetail_GharMuliId",
                table: "GharMuliKhanePaniAndAawasDetail",
                column: "GharMuliId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthDetail_HouseOwnerDetailId",
                table: "HealthDetail",
                column: "HouseOwnerDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthDetailChronicDiseaseGroup_ChronicDiseaseId",
                table: "HealthDetailChronicDiseaseGroup",
                column: "ChronicDiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthDetailChronicDiseaseGroup_HealthDetailIid",
                table: "HealthDetailChronicDiseaseGroup",
                column: "HealthDetailIid");

            migrationBuilder.CreateIndex(
                name: "IX_HealthDetailDisabilityCardGroup_DisabilityCardId",
                table: "HealthDetailDisabilityCardGroup",
                column: "DisabilityCardId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthDetailDisabilityCardGroup_HealthDetailId",
                table: "HealthDetailDisabilityCardGroup",
                column: "HealthDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthDetailDisabilityReasonGroup_DisabilityReasonId",
                table: "HealthDetailDisabilityReasonGroup",
                column: "DisabilityReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthDetailDisabilityReasonGroup_HealthDetailId",
                table: "HealthDetailDisabilityReasonGroup",
                column: "HealthDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthDetailDisabilityTypeGroup_DisabilityTypeId",
                table: "HealthDetailDisabilityTypeGroup",
                column: "DisabilityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthDetailDisabilityTypeGroup_HealthDetailId",
                table: "HealthDetailDisabilityTypeGroup",
                column: "HealthDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacility_LocalLevelId",
                table: "HealthFacility",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacility_WardId",
                table: "HealthFacility",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricPlace_LocalLevelId",
                table: "HistoricPlace",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_LocalLevelId",
                table: "Hotel",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_WardId",
                table: "Hotel",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseDetail_HouseFloorId",
                table: "HouseDetail",
                column: "HouseFloorId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseDetail_HouseMapId",
                table: "HouseDetail",
                column: "HouseMapId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseDetail_HouseOwnerDetailId",
                table: "HouseDetail",
                column: "HouseOwnerDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseDetail_HouseOwnershipId",
                table: "HouseDetail",
                column: "HouseOwnershipId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseDetail_HouseRoofId",
                table: "HouseDetail",
                column: "HouseRoofId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerAbdhiGroup_AbhadhiId",
                table: "HouseOwnerAbdhiGroup",
                column: "AbhadhiId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerAbdhiGroup_HouseOwnerId",
                table: "HouseOwnerAbdhiGroup",
                column: "HouseOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerCode_HouseOwnerId",
                table: "HouseOwnerCode",
                column: "HouseOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerCode_LocalLavelId",
                table: "HouseOwnerCode",
                column: "LocalLavelId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerCode_WardId",
                table: "HouseOwnerCode",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerCountryGroup_CountryId",
                table: "HouseOwnerCountryGroup",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerCountryGroup_HouseOwnerId",
                table: "HouseOwnerCountryGroup",
                column: "HouseOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerDetails_BusinessTypeId",
                table: "HouseOwnerDetails",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerDetails_Earthquake2072Id",
                table: "HouseOwnerDetails",
                column: "Earthquake2072Id");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerDetails_GenderId",
                table: "HouseOwnerDetails",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerDetails_HouseTypeId",
                table: "HouseOwnerDetails",
                column: "HouseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerDetails_LocalLevelId",
                table: "HouseOwnerDetails",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerDetails_NaturalDisasterId",
                table: "HouseOwnerDetails",
                column: "NaturalDisasterId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerDetails_SkillTypeId",
                table: "HouseOwnerDetails",
                column: "SkillTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerDetails_VehicleId",
                table: "HouseOwnerDetails",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseOwnerFamilyDetail_HouseOwnerDetailsId",
                table: "HouseOwnerFamilyDetail",
                column: "HouseOwnerDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_HydroPower_LocalLevelId",
                table: "HydroPower",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_HydroPower_WardId",
                table: "HydroPower",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Industry_WardId",
                table: "Industry",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Institution_WardNoNavigationId",
                table: "Institution",
                column: "WardNoNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_JanPratinidhi_LocalLevelId",
                table: "JanPratinidhi",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JanPratinidhi_WardId",
                table: "JanPratinidhi",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_KaryalayaSetup_DistrictId",
                table: "KaryalayaSetup",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_KaryalayaSetup_PalikaId",
                table: "KaryalayaSetup",
                column: "PalikaId");

            migrationBuilder.CreateIndex(
                name: "IX_KaryalayaSetup_ProvinceId",
                table: "KaryalayaSetup",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Lake_LocalLevelId",
                table: "Lake",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Lake_WardId",
                table: "Lake",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalLevel_DistId",
                table: "LocalLevel",
                column: "DistId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalLevelDetail_LocalLevelId",
                table: "LocalLevelDetail",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Ministry_StateId",
                table: "Ministry",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Mountain_LocalLevelId",
                table: "Mountain",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Mountain_WardId",
                table: "Mountain",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_MovedFamilyMemberDetail_HouseOwnerDetailsId",
                table: "MovedFamilyMemberDetail",
                column: "HouseOwnerDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_MultisectoralNutritionAndExtension_HouseOwnerDetailId",
                table: "MultisectoralNutritionAndExtension",
                column: "HouseOwnerDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_NagarikWadaPatra_LocalLevelId",
                table: "NagarikWadaPatra",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_NagarikWadaPatraDoc_NagarikWadaPatraId",
                table: "NagarikWadaPatraDoc",
                column: "NagarikWadaPatraId");

            migrationBuilder.CreateIndex(
                name: "IX_Notice_LocalLevelId",
                table: "Notice",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_PoliceStation_LocalLevelId",
                table: "PoliceStation",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_PoliceStation_WardId",
                table: "PoliceStation",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_PopulationDetail_LanguageId",
                table: "PopulationDetail",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PopulationDetail_ReligionId",
                table: "PopulationDetail",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_PopulationDetailAgeGroup_AgeGroupId",
                table: "PopulationDetailAgeGroup",
                column: "AgeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PopulationDetailAgeGroup_PopulationDetailId",
                table: "PopulationDetailAgeGroup",
                column: "PopulationDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PopulationDetailCasteGroup_CasteId",
                table: "PopulationDetailCasteGroup",
                column: "CasteId");

            migrationBuilder.CreateIndex(
                name: "IX_PopulationDetailCasteGroup_PopulationId",
                table: "PopulationDetailCasteGroup",
                column: "PopulationId");

            migrationBuilder.CreateIndex(
                name: "IX_PopulationDetailOccupationGroup_OccupationDetailId",
                table: "PopulationDetailOccupationGroup",
                column: "OccupationDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PopulationDetailOccupationGroup_PopulationDetailId",
                table: "PopulationDetailOccupationGroup",
                column: "PopulationDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PregnancyDetail_GharMuliId",
                table: "PregnancyDetail",
                column: "GharMuliId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_LocalLevelId",
                table: "Project",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_WardId",
                table: "Project",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtectedArea_LocalLevelId",
                table: "ProtectedArea",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtectedArea_WardId",
                table: "ProtectedArea",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Sikshya_DistrictId",
                table: "Sikshya",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Sikshya_LocalLevelId",
                table: "Sikshya",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Sikshya_StateId",
                table: "Sikshya",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Sikshya_WardId",
                table: "Sikshya",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_SleepMotherDetail_GharMuliId",
                table: "SleepMotherDetail",
                column: "GharMuliId");

            migrationBuilder.CreateIndex(
                name: "IX_StateDetail_StateId",
                table: "StateDetail",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_DistrictId",
                table: "UserDetail",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_LocalLevelNavigationId",
                table: "UserDetail",
                column: "LocalLevelNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_StateId",
                table: "UserDetail",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_WardId",
                table: "UserDetail",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Ward_LocalLevelId",
                table: "Ward",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_WardDetail_WardId",
                table: "WardDetail",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterFall_LocalLevelId",
                table: "WaterFall",
                column: "LocalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterFall_WardId",
                table: "WaterFall",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_WhereAreTheyNowDetail_HouseOwnerDetailsId",
                table: "WhereAreTheyNowDetail",
                column: "HouseOwnerDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_WhereAreTheyNowDetail_WhereAreTheyNowId",
                table: "WhereAreTheyNowDetail",
                column: "WhereAreTheyNowId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgricultureDetailAnimalGroup");

            migrationBuilder.DropTable(
                name: "AgriculturePasuPanchiDetail");

            migrationBuilder.DropTable(
                name: "AgricultureProductDetail");

            migrationBuilder.DropTable(
                name: "AgricultureProductQuantity");

            migrationBuilder.DropTable(
                name: "Airport");

            migrationBuilder.DropTable(
                name: "Atm");

            migrationBuilder.DropTable(
                name: "BalBibaha");

            migrationBuilder.DropTable(
                name: "BloodBank");

            migrationBuilder.DropTable(
                name: "DistrictDetail");

            migrationBuilder.DropTable(
                name: "EconomicDetailTechnicalSkillGroup");

            migrationBuilder.DropTable(
                name: "EducationDetailSchoolGroup");

            migrationBuilder.DropTable(
                name: "EducationEducationalLevelGroup");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "GharMuliChildDetail");

            migrationBuilder.DropTable(
                name: "GharMuliEconomicStatus");

            migrationBuilder.DropTable(
                name: "GharMuliFamilyDetail");

            migrationBuilder.DropTable(
                name: "GharMuliFamilyMarrageDetail");

            migrationBuilder.DropTable(
                name: "GharMuliHealthDetail");

            migrationBuilder.DropTable(
                name: "GharMuliKhanePaniAndAawasDetail");

            migrationBuilder.DropTable(
                name: "HealthDetailChronicDiseaseGroup");

            migrationBuilder.DropTable(
                name: "HealthDetailDisabilityCardGroup");

            migrationBuilder.DropTable(
                name: "HealthDetailDisabilityReasonGroup");

            migrationBuilder.DropTable(
                name: "HealthDetailDisabilityTypeGroup");

            migrationBuilder.DropTable(
                name: "HealthFacility");

            migrationBuilder.DropTable(
                name: "HistoricPlace");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "HouseDetail");

            migrationBuilder.DropTable(
                name: "HouseOwnerAbdhiGroup");

            migrationBuilder.DropTable(
                name: "HouseOwnerCode");

            migrationBuilder.DropTable(
                name: "HouseOwnerCountryGroup");

            migrationBuilder.DropTable(
                name: "HouseOwnerFamilyDetail");

            migrationBuilder.DropTable(
                name: "HydroPower");

            migrationBuilder.DropTable(
                name: "Industry");

            migrationBuilder.DropTable(
                name: "Institution");

            migrationBuilder.DropTable(
                name: "JanPratinidhi");

            migrationBuilder.DropTable(
                name: "KaryalayaSetup");

            migrationBuilder.DropTable(
                name: "Lake");

            migrationBuilder.DropTable(
                name: "LocalLevelDetail");

            migrationBuilder.DropTable(
                name: "Ministry");

            migrationBuilder.DropTable(
                name: "Mountain");

            migrationBuilder.DropTable(
                name: "MovedFamilyMemberDetail");

            migrationBuilder.DropTable(
                name: "MultisectoralNutritionAndExtension");

            migrationBuilder.DropTable(
                name: "NagarikWadaPatraDoc");

            migrationBuilder.DropTable(
                name: "Notice");

            migrationBuilder.DropTable(
                name: "PoliceStation");

            migrationBuilder.DropTable(
                name: "PopulationDetailAgeGroup");

            migrationBuilder.DropTable(
                name: "PopulationDetailCasteGroup");

            migrationBuilder.DropTable(
                name: "PopulationDetailOccupationGroup");

            migrationBuilder.DropTable(
                name: "PregnancyDetail");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "ProtectedArea");

            migrationBuilder.DropTable(
                name: "Sikshya");

            migrationBuilder.DropTable(
                name: "SleepMotherDetail");

            migrationBuilder.DropTable(
                name: "StateDetail");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "WardDetail");

            migrationBuilder.DropTable(
                name: "WaterFall");

            migrationBuilder.DropTable(
                name: "WhereAreTheyNowDetail");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "AgricultureDetail");

            migrationBuilder.DropTable(
                name: "EconomicDetail");

            migrationBuilder.DropTable(
                name: "TechnicalSkill");

            migrationBuilder.DropTable(
                name: "SchoolLayer");

            migrationBuilder.DropTable(
                name: "SchoolTime");

            migrationBuilder.DropTable(
                name: "EducationDetail");

            migrationBuilder.DropTable(
                name: "Designation");

            migrationBuilder.DropTable(
                name: "EducationalLevel");

            migrationBuilder.DropTable(
                name: "GharMuliDetail");

            migrationBuilder.DropTable(
                name: "ChronicDisease");

            migrationBuilder.DropTable(
                name: "DisabilityCard");

            migrationBuilder.DropTable(
                name: "DisabilityReason");

            migrationBuilder.DropTable(
                name: "DisabilityType");

            migrationBuilder.DropTable(
                name: "HealthDetail");

            migrationBuilder.DropTable(
                name: "HouseFloor");

            migrationBuilder.DropTable(
                name: "HouseMapDetail");

            migrationBuilder.DropTable(
                name: "HouseOwnership");

            migrationBuilder.DropTable(
                name: "HouseRoof");

            migrationBuilder.DropTable(
                name: "Abhadhi");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "NagarikWadaPatra");

            migrationBuilder.DropTable(
                name: "AgeGroup");

            migrationBuilder.DropTable(
                name: "OccupationDetail");

            migrationBuilder.DropTable(
                name: "PopulationDetail");

            migrationBuilder.DropTable(
                name: "AverageMonthlyIncome");

            migrationBuilder.DropTable(
                name: "FoodCondition");

            migrationBuilder.DropTable(
                name: "WhereAreTheyNow");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Caste");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DropTable(
                name: "HouseOwnerDetails");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Religion");

            migrationBuilder.DropTable(
                name: "BusinessType");

            migrationBuilder.DropTable(
                name: "Earthquake2072");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "HouseType");

            migrationBuilder.DropTable(
                name: "LocalLevel");

            migrationBuilder.DropTable(
                name: "NaturalDisaster");

            migrationBuilder.DropTable(
                name: "SkillType");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
