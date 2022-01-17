using Microsoft.EntityFrameworkCore.Migrations;

namespace Produto.Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    preco = table.Column<decimal>(type: "decimal", nullable: false),
                    tipo = table.Column<string>(type: "varchar(50)", nullable: true),
                    descricao = table.Column<string>(type: "varchar(100)", nullable: true),
                    marca = table.Column<string>(type: "varchar(200)", nullable: true),
                    quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
