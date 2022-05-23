using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicTahp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Music",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCaKhuc = table.Column<string>(nullable: true),
                    CaSi = table.Column<string>(nullable: true),
                    TheLoai = table.Column<string>(nullable: true),
                    NgayBan = table.Column<DateTime>(nullable: false),
                    Gia = table.Column<decimal>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Music", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Music");
        }
    }
}
