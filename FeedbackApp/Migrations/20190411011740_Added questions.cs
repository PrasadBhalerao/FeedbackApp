using Microsoft.EntityFrameworkCore.Migrations;

namespace FeedbackApp.Migrations
{
    public partial class Addedquestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FBQuestions",
                columns: new[] { "KeyID", "Question" },
                values: new object[,]
                {
                    { 1, "How do you rate your experience with C#?" },
                    { 2, "How do you rate your experience with Java?" },
                    { 3, "How do you rate your experience with Javascript?" },
                    { 4, "How do you rate your experience with AngularJS?" },
                    { 5, "How do you rate your experience with Angular?" },
                    { 6, "How do you rate your experience with SQL?" },
                    { 7, "How do you rate your experience with MongoDB?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FBQuestions",
                keyColumn: "KeyID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FBQuestions",
                keyColumn: "KeyID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FBQuestions",
                keyColumn: "KeyID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FBQuestions",
                keyColumn: "KeyID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FBQuestions",
                keyColumn: "KeyID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FBQuestions",
                keyColumn: "KeyID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FBQuestions",
                keyColumn: "KeyID",
                keyValue: 7);
        }
    }
}
