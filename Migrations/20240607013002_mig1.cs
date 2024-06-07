using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCOgrenciCRUD.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ogrno",
                table: "Ogrenciler",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ogrenciler",
                newName: "ogrno");
        }
    }
}
