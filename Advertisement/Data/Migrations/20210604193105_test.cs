using Microsoft.EntityFrameworkCore.Migrations;

namespace Advertisement.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Path",
                table: "Pictures",
                newName: "PicturePath");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PicturePath",
                table: "Pictures",
                newName: "Path");
        }
    }
}
