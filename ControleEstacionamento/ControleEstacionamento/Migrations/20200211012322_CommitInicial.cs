using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleEstacionamento.Migrations
{
    public partial class CommitInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manobristas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(nullable: true),
                    DtNascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manobristas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Placa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistroManobras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeiculoId = table.Column<int>(nullable: true),
                    ManobristaId = table.Column<int>(nullable: true),
                    DataManobra = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroManobras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroManobras_Manobristas_ManobristaId",
                        column: x => x.ManobristaId,
                        principalTable: "Manobristas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegistroManobras_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistroManobras_ManobristaId",
                table: "RegistroManobras",
                column: "ManobristaId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroManobras_VeiculoId",
                table: "RegistroManobras",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroManobras");

            migrationBuilder.DropTable(
                name: "Manobristas");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
