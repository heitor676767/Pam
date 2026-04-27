using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CopaHas.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_JOGADORES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroCamisa = table.Column<int>(type: "int", nullable: false),
                    Posicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelecaoId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_JOGADORES", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_JOGADORES",
                columns: new[] { "Id", "Nome", "NumeroCamisa", "Posicao", "SelecaoId", "Status" },
                values: new object[,]
                {
                    { 1, "Hugo Souza", 1, "Goleiro", 0, 1 },
                    { 2, "Cássio", 12, "Goleiro", 0, 1 },
                    { 3, "Rafael", 23, "Goleiro", 0, 2 },
                    { 4, "Fábio", 1, "Goleiro", 0, 1 },
                    { 5, "Fagner", 23, "Lateral Direito", 0, 1 },
                    { 6, "Samuel Xavier", 2, "Lateral Direito", 0, 1 },
                    { 7, "Ayrton Lucas", 6, "Lateral Esquerdo", 0, 1 },
                    { 8, "Reinaldo", 6, "Lateral Esquerdo", 0, 1 },
                    { 9, "Geromel", 3, "Zagueiro", 0, 1 },
                    { 10, "Kannemann", 4, "Zagueiro", 0, 1 },
                    { 11, "Nino", 33, "Zagueiro", 0, 1 },
                    { 12, "Fabrício Bruno", 15, "Zagueiro", 0, 1 },
                    { 13, "André", 7, "Volante", 0, 1 },
                    { 14, "João Gomes", 35, "Volante", 0, 1 },
                    { 15, "Thiago Maia", 8, "Volante", 0, 2 },
                    { 16, "Arrascaeta", 14, "Meia", 0, 1 },
                    { 17, "Ganso", 10, "Meia", 0, 1 },
                    { 18, "Cristiano Ronaldo", 7, "Atacante", 0, 2 },
                    { 19, "Pedro", 9, "Atacante", 0, 1 },
                    { 20, "Gabriel Barbosa", 10, "Atacante", 0, 1 },
                    { 21, "Calleri", 9, "Atacante", 0, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_JOGADORES");
        }
    }
}
