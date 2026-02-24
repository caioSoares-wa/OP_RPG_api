using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ShinRoll.Migrations
{
    /// <inheritdoc />
    public partial class atualizarDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_characters_Attributes_SavingBonusId",
                table: "characters");

            migrationBuilder.DropForeignKey(
                name: "FK_characters_OriginStats_OriginId",
                table: "characters");

            migrationBuilder.DropForeignKey(
                name: "FK_characters_ProfessionStats_ProfessionId",
                table: "characters");

            migrationBuilder.DropForeignKey(
                name: "FK_characters_SkillsData_SkillsId",
                table: "characters");

            migrationBuilder.DropForeignKey(
                name: "FK_characters_SpeciesStats_SpeciesId",
                table: "characters");

            migrationBuilder.DropTable(
                name: "OriginStats");

            migrationBuilder.DropTable(
                name: "ProfessionStats");

            migrationBuilder.DropTable(
                name: "SkillsData");

            migrationBuilder.DropTable(
                name: "SpeciesStats");

            migrationBuilder.DropTable(
                name: "TechniqueStats");

            migrationBuilder.DropIndex(
                name: "IX_characters_OriginId",
                table: "characters");

            migrationBuilder.DropIndex(
                name: "IX_characters_ProfessionId",
                table: "characters");

            migrationBuilder.DropIndex(
                name: "IX_characters_SavingBonusId",
                table: "characters");

            migrationBuilder.DropIndex(
                name: "IX_characters_SkillsId",
                table: "characters");

            migrationBuilder.DropIndex(
                name: "IX_characters_SpeciesId",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "OriginId",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "ProfessionId",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "SavingBonusId",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "SkillsId",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "SpeciesId",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Attributes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OriginId",
                table: "characters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfessionId",
                table: "characters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "SavingBonusId",
                table: "characters",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "SkillsId",
                table: "characters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpeciesId",
                table: "characters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Attributes",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "OriginStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Origin = table.Column<int>(type: "integer", nullable: false),
                    OriginName = table.Column<string>(type: "text", nullable: false),
                    RecommendedAttribute = table.Column<int[]>(type: "integer[]", nullable: false),
                    SkillToChoose = table.Column<int>(type: "integer", nullable: false),
                    SkillsProficiency = table.Column<int[]>(type: "integer[]", nullable: false),
                    SpecialAbilityDescription = table.Column<string>(type: "text", nullable: false),
                    SpecialAbilityName = table.Column<string>(type: "text", nullable: false)
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
                    Details = table.Column<List<string>>(type: "text[]", nullable: false),
                    Profession = table.Column<int>(type: "integer", nullable: false),
                    SkillToChoose = table.Column<int>(type: "integer", nullable: false),
                    SkillsProficiency = table.Column<int[]>(type: "integer[]", nullable: false),
                    SpecialSkill = table.Column<string>(type: "text", nullable: false),
                    SpecialSkillName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillsData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Acrobatics = table.Column<int>(type: "integer", nullable: false),
                    Athletics = table.Column<int>(type: "integer", nullable: false),
                    Deception = table.Column<int>(type: "integer", nullable: false),
                    FightingStyleStatsId = table.Column<int>(type: "integer", nullable: true),
                    Haki = table.Column<int>(type: "integer", nullable: false),
                    History = table.Column<int>(type: "integer", nullable: false),
                    Insight = table.Column<int>(type: "integer", nullable: false),
                    Intimidation = table.Column<int>(type: "integer", nullable: false),
                    Investigation = table.Column<int>(type: "integer", nullable: false),
                    Luck = table.Column<int>(type: "integer", nullable: false),
                    Nature = table.Column<int>(type: "integer", nullable: false),
                    Perception = table.Column<int>(type: "integer", nullable: false),
                    Performance = table.Column<int>(type: "integer", nullable: false),
                    Persuasion = table.Column<int>(type: "integer", nullable: false),
                    Profession = table.Column<int>(type: "integer", nullable: false),
                    Provoke = table.Column<int>(type: "integer", nullable: false),
                    SleightOfHand = table.Column<int>(type: "integer", nullable: false),
                    Stealth = table.Column<int>(type: "integer", nullable: false),
                    Supernatural = table.Column<int>(type: "integer", nullable: false),
                    Survival = table.Column<int>(type: "integer", nullable: false)
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
                name: "SpeciesStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BaseLifePoints = table.Column<int>(type: "integer", nullable: false),
                    Beneficts = table.Column<string>(type: "text", nullable: false),
                    Harms = table.Column<string>(type: "text", nullable: false),
                    Moviment = table.Column<double>(type: "double precision", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Species = table.Column<int>(type: "integer", nullable: false),
                    SubSpecieName = table.Column<string>(type: "text", nullable: true),
                    SubSpecies = table.Column<int>(type: "integer", nullable: true),
                    Swimming = table.Column<double>(type: "double precision", nullable: false),
                    VariantDescription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeciesStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechniqueStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ActionRequirement = table.Column<string>(type: "text", nullable: false),
                    CanCombineAttack = table.Column<bool>(type: "boolean", nullable: false),
                    CharacterId = table.Column<long>(type: "bigint", nullable: true),
                    Damage = table.Column<string>(type: "text", nullable: false),
                    Degree = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Duration = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PowerPointCost = table.Column<int>(type: "integer", nullable: false),
                    Range = table.Column<string>(type: "text", nullable: false)
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

            migrationBuilder.AddForeignKey(
                name: "FK_characters_Attributes_SavingBonusId",
                table: "characters",
                column: "SavingBonusId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_characters_OriginStats_OriginId",
                table: "characters",
                column: "OriginId",
                principalTable: "OriginStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_characters_ProfessionStats_ProfessionId",
                table: "characters",
                column: "ProfessionId",
                principalTable: "ProfessionStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_characters_SkillsData_SkillsId",
                table: "characters",
                column: "SkillsId",
                principalTable: "SkillsData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_characters_SpeciesStats_SpeciesId",
                table: "characters",
                column: "SpeciesId",
                principalTable: "SpeciesStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
