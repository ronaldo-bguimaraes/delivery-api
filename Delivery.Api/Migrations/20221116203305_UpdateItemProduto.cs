using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delivery.Api.Migrations
{
    public partial class UpdateItemProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Vendas");

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "ItensProdutos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItensProdutos_FornecedorId",
                table: "ItensProdutos",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensProdutos_Fornecedores_FornecedorId",
                table: "ItensProdutos",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "FornecedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensProdutos_Fornecedores_FornecedorId",
                table: "ItensProdutos");

            migrationBuilder.DropIndex(
                name: "IX_ItensProdutos_FornecedorId",
                table: "ItensProdutos");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "ItensProdutos");

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Vendas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
