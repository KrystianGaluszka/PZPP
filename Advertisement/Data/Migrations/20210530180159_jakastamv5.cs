using Microsoft.EntityFrameworkCore.Migrations;

namespace Advertisement.Data.Migrations
{
    public partial class jakastamv5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Advertisements_Id",
                table: "Pictures");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pictures",
                newName: "PicturesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Advertisements_PicturesId",
                table: "Pictures",
                column: "PicturesId",
                principalTable: "Advertisements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Advertisements_PicturesId",
                table: "Pictures");

            migrationBuilder.RenameColumn(
                name: "PicturesId",
                table: "Pictures",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Advertisements_Id",
                table: "Pictures",
                column: "Id",
                principalTable: "Advertisements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
