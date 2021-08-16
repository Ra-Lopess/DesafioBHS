using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToBuy.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.CreateTable(
                name: "PEDIDOS",
                columns: table => new
                {
                    CODIGO = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    DATAPEDIDO = table.Column<DateTime>(type: "datetime", nullable: false),
                    VALORPEDIDO = table.Column<decimal>(type: "numeric(13,2)", nullable: false),
                    STATUS = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDOS", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "ITENS",
                columns: table => new
                {
                    CODIGO = table.Column<int>(type: "int", nullable: false),
                    CODIGOPEDIDO = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    VALORITEM = table.Column<decimal>(type: "numeric(13,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITENS", x => x.CODIGO);
                    table.ForeignKey(
                        name: "FK_ITENS_PEDIDOS",
                        column: x => x.CODIGOPEDIDO,
                        principalTable: "PEDIDOS",
                        principalColumn: "CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ITENS_CODIGOPEDIDO",
                table: "ITENS",
                column: "CODIGOPEDIDO");
            */
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ITENS");

            migrationBuilder.DropTable(
                name: "PEDIDOS");
        }
    }
}
