using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstLab.Migrations
{
    public partial class AddPetUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Users_OwnerUserId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_OwnerUserId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Pets");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Pets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UserId",
                table: "Pets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Users_UserId",
                table: "Pets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Users_UserId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_UserId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Pets");

            migrationBuilder.AddColumn<int>(
                name: "OwnerUserId",
                table: "Pets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerUserId",
                table: "Pets",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Users_OwnerUserId",
                table: "Pets",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
