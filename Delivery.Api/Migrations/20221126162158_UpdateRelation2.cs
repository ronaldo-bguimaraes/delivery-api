using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delivery.Api.Migrations
{
    public partial class UpdateRelation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_Vendas_VendaId",
                table: "Pagamentos");

            migrationBuilder.AlterColumn<int>(
                name: "VendaId",
                table: "Pagamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "VendaId",
                table: "Pagamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_Vendas_VendaId",
                table: "Pagamentos",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
