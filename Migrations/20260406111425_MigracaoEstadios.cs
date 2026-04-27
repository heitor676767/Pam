using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CopaHas.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoEstadios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ESTADIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ESTADIOS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_ESTADIOS",
                columns: new[] { "Id", "Capacidade", "Cidade", "Nome" },
                values: new object[,]
                {
                    { 1, 50000, "Sao Paulo", "Neo Quimica Arena" },
                    { 2, 80000, "Sao Paulo", "Morumbis" },
                    { 3, 40000, "Sao Paulo", "Chiqueiro" },
                    { 4, 67676, "Sao Paulo", "Siri boy Arena" },
                    { 5, 80000, "Paris", "Parque dos principes" },
                    { 6, 40000, "Salvador", "Fonte Nova" },
                    { 7, 77777, "Sao Paulo", "Aura Stadium" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ESTADIOS");
        }
    }
}
