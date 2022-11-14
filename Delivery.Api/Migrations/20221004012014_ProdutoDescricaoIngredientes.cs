using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delivery.Api.Migrations
{
  public partial class ProdutoDescricaoIngredientes : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Entregador_Usuarios_UsuarioId",
          table: "Entregador");

      migrationBuilder.DropForeignKey(
          name: "FK_Vendas_Entregador_EntregadorId",
          table: "Vendas");

      migrationBuilder.DropForeignKey(
          name: "FK_Vendas_Pagamento_PagamentoId",
          table: "Vendas");

      migrationBuilder.DropPrimaryKey(
          name: "PK_Pagamento",
          table: "Pagamento");

      migrationBuilder.DropPrimaryKey(
          name: "PK_Entregador",
          table: "Entregador");

      migrationBuilder.RenameTable(
          name: "Pagamento",
          newName: "Pagamentos");

      migrationBuilder.RenameTable(
          name: "Entregador",
          newName: "Entregadores");

      migrationBuilder.RenameIndex(
          name: "IX_Entregador_UsuarioId",
          table: "Entregadores",
          newName: "IX_Entregadores_UsuarioId");

      migrationBuilder.AlterColumn<string>(
          name: "Ingredientes",
          table: "Produtos",
          type: "varchar(200)",
          nullable: true,
          oldClrType: typeof(string),
          oldType: "varchar(100)",
          oldNullable: true);

      migrationBuilder.AddPrimaryKey(
          name: "PK_Pagamentos",
          table: "Pagamentos",
          column: "PagamentoId");

      migrationBuilder.AddPrimaryKey(
          name: "PK_Entregadores",
          table: "Entregadores",
          column: "EntregadorId");

      migrationBuilder.AddForeignKey(
          name: "FK_Entregadores_Usuarios_UsuarioId",
          table: "Entregadores",
          column: "UsuarioId",
          principalTable: "Usuarios",
          principalColumn: "UsuarioId");

      migrationBuilder.AddForeignKey(
          name: "FK_Vendas_Entregadores_EntregadorId",
          table: "Vendas",
          column: "EntregadorId",
          principalTable: "Entregadores",
          principalColumn: "EntregadorId");

      migrationBuilder.AddForeignKey(
          name: "FK_Vendas_Pagamentos_PagamentoId",
          table: "Vendas",
          column: "PagamentoId",
          principalTable: "Pagamentos",
          principalColumn: "PagamentoId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Entregadores_Usuarios_UsuarioId",
          table: "Entregadores");

      migrationBuilder.DropForeignKey(
          name: "FK_Vendas_Entregadores_EntregadorId",
          table: "Vendas");

      migrationBuilder.DropForeignKey(
          name: "FK_Vendas_Pagamentos_PagamentoId",
          table: "Vendas");

      migrationBuilder.DropPrimaryKey(
          name: "PK_Pagamentos",
          table: "Pagamentos");

      migrationBuilder.DropPrimaryKey(
          name: "PK_Entregadores",
          table: "Entregadores");

      migrationBuilder.RenameTable(
          name: "Pagamentos",
          newName: "Pagamento");

      migrationBuilder.RenameTable(
          name: "Entregadores",
          newName: "Entregador");

      migrationBuilder.RenameIndex(
          name: "IX_Entregadores_UsuarioId",
          table: "Entregador",
          newName: "IX_Entregador_UsuarioId");

      migrationBuilder.AlterColumn<string>(
          name: "Ingredientes",
          table: "Produtos",
          type: "varchar(100)",
          nullable: true,
          oldClrType: typeof(string),
          oldType: "varchar(200)",
          oldNullable: true);

      migrationBuilder.AddPrimaryKey(
          name: "PK_Pagamento",
          table: "Pagamento",
          column: "PagamentoId");

      migrationBuilder.AddPrimaryKey(
          name: "PK_Entregador",
          table: "Entregador",
          column: "EntregadorId");

      migrationBuilder.AddForeignKey(
          name: "FK_Entregador_Usuarios_UsuarioId",
          table: "Entregador",
          column: "UsuarioId",
          principalTable: "Usuarios",
          principalColumn: "UsuarioId");

      migrationBuilder.AddForeignKey(
          name: "FK_Vendas_Entregador_EntregadorId",
          table: "Vendas",
          column: "EntregadorId",
          principalTable: "Entregador",
          principalColumn: "EntregadorId");

      migrationBuilder.AddForeignKey(
          name: "FK_Vendas_Pagamento_PagamentoId",
          table: "Vendas",
          column: "PagamentoId",
          principalTable: "Pagamento",
          principalColumn: "PagamentoId");
    }
  }
}
