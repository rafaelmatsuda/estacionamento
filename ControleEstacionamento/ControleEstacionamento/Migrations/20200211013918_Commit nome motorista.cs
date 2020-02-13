using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleEstacionamento.Migrations
{
    public partial class Commitnomemotorista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Manobristas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Manobristas");
        }
    }
}
