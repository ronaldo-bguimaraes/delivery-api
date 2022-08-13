using Microsoft.EntityFrameworkCore.Migrations;

namespace Delivery.Api.Migrations
{
    public partial class Teste1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Usuarios_UsuarioId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Usuarios_UsuarioId",
                table: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Enderecos",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Clientes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "ClienteId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Usuarios_UsuarioId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Usuarios_UsuarioId",
                table: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Enderecos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Usuarios_UsuarioId",
                table: "Clientes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Usuarios_UsuarioId",
                table: "Enderecos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
