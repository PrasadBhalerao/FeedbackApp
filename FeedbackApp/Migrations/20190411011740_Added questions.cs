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
                    { 1, "How was your exp1?" },
                    { 2, "How was your exp2?" },
                    { 3, "How was your exp3?" },
                    { 4, "How was your exp4?" },
                    { 5, "How was your exp5?" },
                    { 6, "How was your exp6?" },
                    { 7, "How was your exp7?" }
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
