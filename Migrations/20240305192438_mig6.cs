using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCProjem.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "puan",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "sayfasayisi",
                table: "Kitaplar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "puan",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sayfasayisi",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
