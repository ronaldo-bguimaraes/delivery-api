using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Delivery.Infrastructure.Migrations
{
  public partial class Initial : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Cliente",
          columns: table => new
          {
            cliente_id = table.Column<int>(nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            cpf = table.Column<string>(nullable: true),
            dt_nascimento = table.Column<DateTime>(nullable: false),
            usuario_id = table.Column<int>(nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Cliente", x => x.cliente_id);
          });

      migrationBuilder.CreateTable(
          name: "Endereco",
          columns: table => new
          {
            endereco_id = table.Column<int>(nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            nome = table.Column<string>(nullable: true),
            apelido = table.Column<string>(nullable: true),
            complemento = table.Column<string>(nullable: true),
            descricao = table.Column<string>(nullable: true),
            latitude = table.Column<double>(nullable: false),
            longitude = table.Column<double>(nullable: false),
            usuario_id = table.Column<int>(nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Endereco", x => x.endereco_id);
          });

      migrationBuilder.CreateTable(
          name: "Usuario",
          columns: table => new
          {
            usuario_id = table.Column<int>(nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            nome = table.Column<string>(nullable: true),
            telefone = table.Column<string>(nullable: true),
            email = table.Column<string>(nullable: true),
            senha = table.Column<string>(nullable: true),
            dt_cadastro = table.Column<DateTime>(nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Usuario", x => x.usuario_id);
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Cliente");

      migrationBuilder.DropTable(
          name: "Endereco");

      migrationBuilder.DropTable(
          name: "Usuario");
    }
  }
}
