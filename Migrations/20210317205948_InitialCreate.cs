using Microsoft.EntityFrameworkCore.Migrations;

namespace CharacterManager.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    RolledHP = table.Column<int>(type: "int", nullable: false),
                    Str = table.Column<int>(type: "int", nullable: false),
                    Con = table.Column<int>(type: "int", nullable: false),
                    Dex = table.Column<int>(type: "int", nullable: false),
                    Int = table.Column<int>(type: "int", nullable: false),
                    Wis = table.Column<int>(type: "int", nullable: false),
                    Cha = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Character");
        }
    }
}
