using Microsoft.EntityFrameworkCore.Migrations;

namespace FeedbackApp.Migrations
{
    public partial class addeduser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FBAnswers_User_UserID",
                table: "FBAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "KeyID");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "KeyID", "UserName" },
                values: new object[] { 1, "Prasad Bhalerao" });

            migrationBuilder.AddForeignKey(
                name: "FK_FBAnswers_Users_UserID",
                table: "FBAnswers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "KeyID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FBAnswers_Users_UserID",
                table: "FBAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "KeyID",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "KeyID");

            migrationBuilder.AddForeignKey(
                name: "FK_FBAnswers_User_UserID",
                table: "FBAnswers",
                column: "UserID",
                principalTable: "User",
                principalColumn: "KeyID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
