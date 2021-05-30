using Microsoft.EntityFrameworkCore.Migrations;

namespace Advertisement.Data.Migrations
{
    public partial class jakastamv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_AspNetUsers_ApplicationUserId",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Advertisements",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisements_ApplicationUserId",
                table: "Advertisements",
                newName: "IX_Advertisements_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_AspNetUsers_UserId",
                table: "Advertisements",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_AspNetUsers_UserId",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Advertisements",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisements_UserId",
                table: "Advertisements",
                newName: "IX_Advertisements_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_AspNetUsers_ApplicationUserId",
                table: "Advertisements",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
