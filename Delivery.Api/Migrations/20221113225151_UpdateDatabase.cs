using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delivery.Api.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Pagamentos_PagamentoId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_PagamentoId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "PagamentoId",
                table: "Vendas");

            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "Pagamentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_VendaId",
                table: "Pagamentos",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_Vendas_VendaId",
                table: "Pagamentos",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_Vendas_VendaId",
                table: "Pagamentos");

            migrationBuilder.DropIndex(
                name: "IX_Pagamentos_VendaId",
                table: "Pagamentos");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Pagamentos");

            migrationBuilder.AddColumn<int>(
                name: "PagamentoId",
                table: "Vendas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_PagamentoId",
                table: "Vendas",
                column: "PagamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Pagamentos_PagamentoId",
                table: "Vendas",
                column: "PagamentoId",
                principalTable: "Pagamentos",
                principalColumn: "PagamentoId");
        }
    }
}
