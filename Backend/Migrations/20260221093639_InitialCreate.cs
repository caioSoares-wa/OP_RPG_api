using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ShinRoll.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    ModStrenght = table.Column<int>(type: "integer", nullable: false),
                    Dexterity = table.Column<int>(type: "integer", nullable: false),
                    ModDexterity = table.Column<int>(type: "integer", nullable: false),
                    Constitution = table.Column<int>(type: "integer", nullable: false),
                    ModConstituition = table.Column<int>(type: "integer", nullable: false),
                    Wisdom = table.Column<int>(type: "integer", nullable: false),
                    ModWisdom = table.Column<int>(type: "integer", nullable: false),
                    Presence = table.Column<int>(type: "integer", nullable: false),
                    ModPresence = table.Column<int>(type: "integer", nullable: false),
                    Will = table.Column<int>(type: "integer", nullable: false),
                    ModWill = table.Column<int>(type: "integer", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FightingStyleStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FightingStyle = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LifeDice = table.Column<int>(type: "integer", nullable: false),
                    WeaponProficiency = table.Column<string>(type: "text", nullable: false),
                    FavoriteWeapon = table.Column<string>(type: "text", nullable: false),
                    SkillToChoose = table.Column<int>(type: "integer", nullable: false),
                    PrimaryAttribute = table.Column<int[]>(type: "integer[]", nullable: false),
                    SavingBonus = table.Column<int[]>(type: "integer[]", nullable: false),
                    SkillsProficiency = table.Column<int[]>(type: "integer[]", nullable: false),
                    CDAttributes = table.Column<int[]>(type: "integer[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FightingStyleStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OriginStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Origin = table.Column<int>(type: "integer", nullable: false),
                    OriginName = table.Column<string>(type: "text", nullable: false),
                    SpecialAbilityName = table.Column<string>(type: "text", nullable: false),
                    SpecialAbilityDescription = table.Column<string>(type: "text", nullable: false),
                    RecommendedAttribute = table.Column<int[]>(type: "integer[]", nullable: false),
                    SkillsProficiency = table.Column<int[]>(type: "integer[]", nullable: false),
                    SkillToChoose = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OriginStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Profession = table.Column<int>(type: "integer", nullable: false),
                    SkillToChoose = table.Column<int>(type: "integer", nullable: false),
                    SkillsProficiency = table.Column<int[]>(type: "integer[]", nullable: false),
                    SpecialSkillName = table.Column<string>(type: "text", nullable: false),
                    SpecialSkill = table.Column<string>(type: "text", nullable: false),
                    Details = table.Column<List<string>>(type: "text[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpeciesStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Species = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SubSpecieName = table.Column<string>(type: "text", nullable: true),
                    BaseLifePoints = table.Column<int>(type: "integer", nullable: false),
                    Moviment = table.Column<double>(type: "double precision", nullable: false),
                    Swimming = table.Column<double>(type: "double precision", nullable: false),
                    SubSpecies = table.Column<int>(type: "integer", nullable: true),
                    VariantDescription = table.Column<string>(type: "text", nullable: true),
                    Beneficts = table.Column<string>(type: "text", nullable: false),
                    Harms = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeciesStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillsData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Athletics = table.Column<int>(type: "integer", nullable: false),
                    Acrobatics = table.Column<int>(type: "integer", nullable: false),
                    Stealth = table.Column<int>(type: "integer", nullable: false),
                    SleightOfHand = table.Column<int>(type: "integer", nullable: false),
                    History = table.Column<int>(type: "integer", nullable: false),
                    Investigation = table.Column<int>(type: "integer", nullable: false),
                    Survival = table.Column<int>(type: "integer", nullable: false),
                    Nature = table.Column<int>(type: "integer", nullable: false),
                    Profession = table.Column<int>(type: "integer", nullable: false),
                    Performance = table.Column<int>(type: "integer", nullable: false),
                    Deception = table.Column<int>(type: "integer", nullable: false),
                    Intimidation = table.Column<int>(type: "integer", nullable: false),
                    Persuasion = table.Column<int>(type: "integer", nullable: false),
                    Provoke = table.Column<int>(type: "integer", nullable: false),
                    Haki = table.Column<int>(type: "integer", nullable: false),
                    Insight = table.Column<int>(type: "integer", nullable: false),
                    Perception = table.Column<int>(type: "integer", nullable: false),
                    Supernatural = table.Column<int>(type: "integer", nullable: false),
                    Luck = table.Column<int>(type: "integer", nullable: false),
                    FightingStyleStatsId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillsData_FightingStyleStats_FightingStyleStatsId",
                        column: x => x.FightingStyleStatsId,
                        principalTable: "FightingStyleStats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "characters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    AttributesId = table.Column<long>(type: "bigint", nullable: false),
                    SkillsId = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    FightingStyleId = table.Column<int>(type: "integer", nullable: false),
                    SavingBonusId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<int>(type: "integer", nullable: false),
                    ProfessionId = table.Column<int>(type: "integer", nullable: false),
                    SpeciesId = table.Column<int>(type: "integer", nullable: false),
                    SubSpecie = table.Column<int>(type: "integer", nullable: true),
                    AllowedSkills = table.Column<int[]>(type: "integer[]", nullable: false),
                    PointsOfLife = table.Column<int>(type: "integer", nullable: false),
                    PointsOfEnergy = table.Column<int>(type: "integer", nullable: false),
                    ArmorClass = table.Column<int>(type: "integer", nullable: false),
                    DifficultyClass = table.Column<int>(type: "integer", nullable: false),
                    Proficiency = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_characters_Attributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characters_Attributes_SavingBonusId",
                        column: x => x.SavingBonusId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characters_FightingStyleStats_FightingStyleId",
                        column: x => x.FightingStyleId,
                        principalTable: "FightingStyleStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characters_OriginStats_OriginId",
                        column: x => x.OriginId,
                        principalTable: "OriginStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characters_ProfessionStats_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "ProfessionStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characters_SkillsData_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "SkillsData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characters_SpeciesStats_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "SpeciesStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechniqueStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Degree = table.Column<int>(type: "integer", nullable: false),
                    PowerPointCost = table.Column<int>(type: "integer", nullable: false),
                    Damage = table.Column<string>(type: "text", nullable: false),
                    Duration = table.Column<string>(type: "text", nullable: false),
                    Range = table.Column<string>(type: "text", nullable: false),
                    CanCombineAttack = table.Column<bool>(type: "boolean", nullable: false),
                    ActionRequirement = table.Column<string>(type: "text", nullable: false),
                    CharacterId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechniqueStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechniqueStats_characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_characters_AttributesId",
                table: "characters",
                column: "AttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_characters_FightingStyleId",
                table: "characters",
                column: "FightingStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_characters_OriginId",
                table: "characters",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_characters_ProfessionId",
                table: "characters",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_characters_SavingBonusId",
                table: "characters",
                column: "SavingBonusId");

            migrationBuilder.CreateIndex(
                name: "IX_characters_SkillsId",
                table: "characters",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_characters_SpeciesId",
                table: "characters",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsData_FightingStyleStatsId",
                table: "SkillsData",
                column: "FightingStyleStatsId");

            migrationBuilder.CreateIndex(
                name: "IX_TechniqueStats_CharacterId",
                table: "TechniqueStats",
                column: "CharacterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TechniqueStats");

            migrationBuilder.DropTable(
                name: "characters");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "OriginStats");

            migrationBuilder.DropTable(
                name: "ProfessionStats");

            migrationBuilder.DropTable(
                name: "SkillsData");

            migrationBuilder.DropTable(
                name: "SpeciesStats");

            migrationBuilder.DropTable(
                name: "FightingStyleStats");
        }
    }
}
