using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delivery.Api.Migrations
{
    public partial class UpdateRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Usuarios_UsuarioId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensProdutos_Fornecedores_FornecedorId",
                table: "ItensProdutos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_Vendas_VendaId",
                table: "Pagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Fornecedores_FornecedorId",
                table: "Vendas");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VendaId",
                table: "Pagamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "ItensProdutos",
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
                name: "FK_ItensProdutos_Fornecedores_FornecedorId",
                table: "ItensProdutos",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "FornecedorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_Vendas_VendaId",
                table: "Pagamentos",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Fornecedores_FornecedorId",
                table: "Vendas",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "FornecedorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Usuarios_UsuarioId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensProdutos_Fornecedores_FornecedorId",
                table: "ItensProdutos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_Vendas_VendaId",
                table: "Pagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Fornecedores_FornecedorId",
                table: "Vendas");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Vendas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VendaId",
                table: "Pagamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "ItensProdutos",
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
                name: "FK_ItensProdutos_Fornecedores_FornecedorId",
                table: "ItensProdutos",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_Vendas_VendaId",
                table: "Pagamentos",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Fornecedores_FornecedorId",
                table: "Vendas",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "FornecedorId");
        }
    }
}
