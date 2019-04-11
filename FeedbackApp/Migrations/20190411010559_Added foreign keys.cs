using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FeedbackApp.Migrations
{
    public partial class Addedforeignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FBQuestionID",
                table: "FBAnswers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "FBAnswers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    KeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.KeyID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FBAnswers_FBQuestionID",
                table: "FBAnswers",
                column: "FBQuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_FBAnswers_UserID",
                table: "FBAnswers",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_FBAnswers_FBQuestions_FBQuestionID",
                table: "FBAnswers",
                column: "FBQuestionID",
                principalTable: "FBQuestions",
                principalColumn: "KeyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FBAnswers_User_UserID",
                table: "FBAnswers",
                column: "UserID",
                principalTable: "User",
                principalColumn: "KeyID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FBAnswers_FBQuestions_FBQuestionID",
                table: "FBAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_FBAnswers_User_UserID",
                table: "FBAnswers");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_FBAnswers_FBQuestionID",
                table: "FBAnswers");

            migrationBuilder.DropIndex(
                name: "IX_FBAnswers_UserID",
                table: "FBAnswers");

            migrationBuilder.DropColumn(
                name: "FBQuestionID",
                table: "FBAnswers");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "FBAnswers");
        }
    }
}
