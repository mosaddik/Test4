using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class UserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserRole_User_Role",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_User_Role",
                table: "User");

            migrationBuilder.DropColumn(
                name: "User_Role",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserRole_RoleId",
                table: "User",
                column: "RoleId",
                principalTable: "UserRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserRole_RoleId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RoleId",
                table: "User");

            migrationBuilder.AlterColumn<long>(
                name: "RoleId",
                table: "User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "User_Role",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_User_Role",
                table: "User",
                column: "User_Role");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserRole_User_Role",
                table: "User",
                column: "User_Role",
                principalTable: "UserRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
