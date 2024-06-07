using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCOgrenciCRUD.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "soyad",
                table: "Ogrenciler",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "ad",
                table: "Ogrenciler",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Ogrenciler",
                newName: "soyad");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Ogrenciler",
                newName: "ad");
        }
    }
}
