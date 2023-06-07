using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCProjem.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    ogrno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dtarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sinif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    puan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.ogrno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrenciler");
        }
    }
}
