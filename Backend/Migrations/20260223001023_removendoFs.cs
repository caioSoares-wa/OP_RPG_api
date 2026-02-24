using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ShinRoll.Migrations
{
    /// <inheritdoc />
    public partial class removendoFs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_characters_FightingStyleStats_FightingStyleId",
                table: "characters");

            migrationBuilder.DropTable(
                name: "FightingStyleStats");

            migrationBuilder.DropIndex(
                name: "IX_characters_FightingStyleId",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "FightingStyleId",
                table: "characters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FightingStyleId",
                table: "characters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FightingStyleStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CDAttributes = table.Column<int[]>(type: "integer[]", nullable: false),
                    FavoriteWeapon = table.Column<string>(type: "text", nullable: false),
                    FightingStyle = table.Column<int>(type: "integer", nullable: false),
                    LifeDice = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PrimaryAttribute = table.Column<int[]>(type: "integer[]", nullable: false),
                    SavingBonus = table.Column<int[]>(type: "integer[]", nullable: false),
                    SkillToChoose = table.Column<int>(type: "integer", nullable: false),
                    SkillsProficiency = table.Column<int[]>(type: "integer[]", nullable: false),
                    WeaponProficiency = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FightingStyleStats", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_characters_FightingStyleId",
                table: "characters",
                column: "FightingStyleId");

            migrationBuilder.AddForeignKey(
                name: "FK_characters_FightingStyleStats_FightingStyleId",
                table: "characters",
                column: "FightingStyleId",
                principalTable: "FightingStyleStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
