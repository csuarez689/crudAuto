using Microsoft.EntityFrameworkCore.Migrations;

namespace crudAuto.Migrations
{
    public partial class fst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "auto",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patente = table.Column<string>(maxLength: 7, nullable: false),
                    marca = table.Column<string>(unicode: false, maxLength: 120, nullable: false),
                    modelo = table.Column<string>(unicode: false, maxLength: 120, nullable: false),
                    anio = table.Column<int>(nullable: false),
                    kms = table.Column<int>(nullable: false),
                    imagen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auto", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_auto_patente",
                table: "auto",
                column: "patente",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "auto");
        }
    }
}
