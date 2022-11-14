using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delivery.Api.Migrations
{
  public partial class Test3 : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Clientes_Usuarios_UsuarioId",
          table: "Clientes");

      migrationBuilder.DropForeignKey(
          name: "FK_Enderecos_Usuarios_UsuarioId",
          table: "Enderecos");

      migrationBuilder.DropForeignKey(
          name: "FK_Entregador_Usuarios_UsuarioId",
          table: "Entregador");

      migrationBuilder.DropForeignKey(
          name: "FK_Fornecedores_Usuarios_UsuarioId",
          table: "Fornecedores");

      migrationBuilder.DropForeignKey(
          name: "FK_ItensProdutos_Produtos_ProdutoId",
          table: "ItensProdutos");

      migrationBuilder.DropForeignKey(
          name: "FK_ItensProdutos_Vendas_VendaId",
          table: "ItensProdutos");

      migrationBuilder.DropForeignKey(
          name: "FK_Produtos_Fornecedores_FornecedorId",
          table: "Produtos");

      migrationBuilder.AlterColumn<int>(
          name: "FornecedorId",
          table: "Produtos",
          type: "int",
          nullable: true,
          oldClrType: typeof(int),
          oldType: "int");

      migrationBuilder.AlterColumn<int>(
          name: "VendaId",
          table: "ItensProdutos",
          type: "int",
          nullable: true,
          oldClrType: typeof(int),
          oldType: "int");

      migrationBuilder.AlterColumn<int>(
          name: "ProdutoId",
          table: "ItensProdutos",
          type: "int",
          nullable: true,
          oldClrType: typeof(int),
          oldType: "int");

      migrationBuilder.AlterColumn<int>(
          name: "UsuarioId",
          table: "Fornecedores",
          type: "int",
          nullable: true,
          oldClrType: typeof(int),
          oldType: "int");

      migrationBuilder.AlterColumn<int>(
          name: "UsuarioId",
          table: "Entregador",
          type: "int",
          nullable: true,
          oldClrType: typeof(int),
          oldType: "int");

      migrationBuilder.AlterColumn<int>(
          name: "UsuarioId",
          table: "Enderecos",
          type: "int",
          nullable: true,
          oldClrType: typeof(int),
          oldType: "int");

      migrationBuilder.AlterColumn<int>(
          name: "UsuarioId",
          table: "Clientes",
          type: "int",
          nullable: true,
          oldClrType: typeof(int),
          oldType: "int");

      migrationBuilder.AddForeignKey(
          name: "FK_Clientes_Usuarios_UsuarioId",
          table: "Clientes",
          column: "UsuarioId",
          principalTable: "Usuarios",
          principalColumn: "UsuarioId");

      migrationBuilder.AddForeignKey(
          name: "FK_Enderecos_Usuarios_UsuarioId",
          table: "Enderecos",
          column: "UsuarioId",
          principalTable: "Usuarios",
          principalColumn: "UsuarioId");

      migrationBuilder.AddForeignKey(
          name: "FK_Entregador_Usuarios_UsuarioId",
          table: "Entregador",
          column: "UsuarioId",
          principalTable: "Usuarios",
          principalColumn: "UsuarioId");

      migrationBuilder.AddForeignKey(
          name: "FK_Fornecedores_Usuarios_UsuarioId",
          table: "Fornecedores",
          column: "UsuarioId",
          principalTable: "Usuarios",
          principalColumn: "UsuarioId");

      migrationBuilder.AddForeignKey(
          name: "FK_ItensProdutos_Produtos_ProdutoId",
          table: "ItensProdutos",
          column: "ProdutoId",
          principalTable: "Produtos",
          principalColumn: "ProdutoId");

      migrationBuilder.AddForeignKey(
          name: "FK_ItensProdutos_Vendas_VendaId",
          table: "ItensProdutos",
          column: "VendaId",
          principalTable: "Vendas",
          principalColumn: "VendaId");

      migrationBuilder.AddForeignKey(
          name: "FK_Produtos_Fornecedores_FornecedorId",
          table: "Produtos",
          column: "FornecedorId",
          principalTable: "Fornecedores",
          principalColumn: "FornecedorId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropForeignKey(
          name: "FK_Clientes_Usuarios_UsuarioId",
          table: "Clientes");

      migrationBuilder.DropForeignKey(
          name: "FK_Enderecos_Usuarios_UsuarioId",
          table: "Enderecos");

      migrationBuilder.DropForeignKey(
          name: "FK_Entregador_Usuarios_UsuarioId",
          table: "Entregador");

      migrationBuilder.DropForeignKey(
          name: "FK_Fornecedores_Usuarios_UsuarioId",
          table: "Fornecedores");

      migrationBuilder.DropForeignKey(
          name: "FK_ItensProdutos_Produtos_ProdutoId",
          table: "ItensProdutos");

      migrationBuilder.DropForeignKey(
          name: "FK_ItensProdutos_Vendas_VendaId",
          table: "ItensProdutos");

      migrationBuilder.DropForeignKey(
          name: "FK_Produtos_Fornecedores_FornecedorId",
          table: "Produtos");

      migrationBuilder.AlterColumn<int>(
          name: "FornecedorId",
          table: "Produtos",
          type: "int",
          nullable: false,
          defaultValue: 0,
          oldClrType: typeof(int),
          oldType: "int",
          oldNullable: true);

      migrationBuilder.AlterColumn<int>(
          name: "VendaId",
          table: "ItensProdutos",
          type: "int",
          nullable: false,
          defaultValue: 0,
          oldClrType: typeof(int),
          oldType: "int",
          oldNullable: true);

      migrationBuilder.AlterColumn<int>(
          name: "ProdutoId",
          table: "ItensProdutos",
          type: "int",
          nullable: false,
          defaultValue: 0,
          oldClrType: typeof(int),
          oldType: "int",
          oldNullable: true);

      migrationBuilder.AlterColumn<int>(
          name: "UsuarioId",
          table: "Fornecedores",
          type: "int",
          nullable: false,
          defaultValue: 0,
          oldClrType: typeof(int),
          oldType: "int",
          oldNullable: true);

      migrationBuilder.AlterColumn<int>(
          name: "UsuarioId",
          table: "Entregador",
          type: "int",
          nullable: false,
          defaultValue: 0,
          oldClrType: typeof(int),
          oldType: "int",
          oldNullable: true);

      migrationBuilder.AlterColumn<int>(
          name: "UsuarioId",
          table: "Enderecos",
          type: "int",
          nullable: false,
          defaultValue: 0,
          oldClrType: typeof(int),
          oldType: "int",
          oldNullable: true);

      migrationBuilder.AlterColumn<int>(
          name: "UsuarioId",
          table: "Clientes",
          type: "int",
          nullable: false,
          defaultValue: 0,
          oldClrType: typeof(int),
          oldType: "int",
          oldNullable: true);

      migrationBuilder.AddForeignKey(
          name: "FK_Clientes_Usuarios_UsuarioId",
          table: "Clientes",
          column: "UsuarioId",
          principalTable: "Usuarios",
          principalColumn: "UsuarioId",
          onDelete: ReferentialAction.Cascade);

      migrationBuilder.AddForeignKey(
          name: "FK_Enderecos_Usuarios_UsuarioId",
          table: "Enderecos",
          column: "UsuarioId",
          principalTable: "Usuarios",
          principalColumn: "UsuarioId",
          onDelete: ReferentialAction.Cascade);

      migrationBuilder.AddForeignKey(
          name: "FK_Entregador_Usuarios_UsuarioId",
          table: "Entregador",
          column: "UsuarioId",
          principalTable: "Usuarios",
          principalColumn: "UsuarioId",
          onDelete: ReferentialAction.Cascade);

      migrationBuilder.AddForeignKey(
          name: "FK_Fornecedores_Usuarios_UsuarioId",
          table: "Fornecedores",
          column: "UsuarioId",
          principalTable: "Usuarios",
          principalColumn: "UsuarioId",
          onDelete: ReferentialAction.Cascade);

      migrationBuilder.AddForeignKey(
          name: "FK_ItensProdutos_Produtos_ProdutoId",
          table: "ItensProdutos",
          column: "ProdutoId",
          principalTable: "Produtos",
          principalColumn: "ProdutoId",
          onDelete: ReferentialAction.Cascade);

      migrationBuilder.AddForeignKey(
          name: "FK_ItensProdutos_Vendas_VendaId",
          table: "ItensProdutos",
          column: "VendaId",
          principalTable: "Vendas",
          principalColumn: "VendaId",
          onDelete: ReferentialAction.Cascade);

      migrationBuilder.AddForeignKey(
          name: "FK_Produtos_Fornecedores_FornecedorId",
          table: "Produtos",
          column: "FornecedorId",
          principalTable: "Fornecedores",
          principalColumn: "FornecedorId",
          onDelete: ReferentialAction.Cascade);
    }
  }
}
