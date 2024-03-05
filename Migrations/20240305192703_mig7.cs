using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCProjem.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "turno",
                table: "Kitaplar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ogrno",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "verildimi",
                table: "Kitaplar",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ogrno",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "verildimi",
                table: "Kitaplar");

            migrationBuilder.AlterColumn<int>(
                name: "turno",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
