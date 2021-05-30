using Microsoft.EntityFrameworkCore.Migrations;

namespace Advertisement.Data.Migrations
{
    public partial class jakastamv8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Advertisements_PicturesId",
                table: "Pictures");

            migrationBuilder.RenameColumn(
                name: "PicturesId",
                table: "Pictures",
                newName: "AdvertisementId");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_PicturesId",
                table: "Pictures",
                newName: "IX_Pictures_AdvertisementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Advertisements_AdvertisementId",
                table: "Pictures",
                column: "AdvertisementId",
                principalTable: "Advertisements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Advertisements_AdvertisementId",
                table: "Pictures");

            migrationBuilder.RenameColumn(
                name: "AdvertisementId",
                table: "Pictures",
                newName: "PicturesId");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_AdvertisementId",
                table: "Pictures",
                newName: "IX_Pictures_PicturesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Advertisements_PicturesId",
                table: "Pictures",
                column: "PicturesId",
                principalTable: "Advertisements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
