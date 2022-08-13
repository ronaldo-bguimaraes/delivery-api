using Microsoft.EntityFrameworkCore.Migrations;

namespace Delivery.Api.Migrations
{
    public partial class Teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnpj = table.Column<string>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.FornecedorId);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_UsuarioId",
                table: "Fornecedores",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
