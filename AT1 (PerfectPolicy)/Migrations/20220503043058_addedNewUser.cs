using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AT1__PerfectPolicy_.Migrations
{
    public partial class addedNewUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Quizs",
                keyColumn: "QuizID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 3, 14, 30, 58, 118, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Quizs",
                keyColumn: "QuizID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 3, 14, 30, 58, 119, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserInfoID", "Password", "Username" },
                values: new object[] { 2, "secret12!", "ben" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserInfoID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Quizs",
                keyColumn: "QuizID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 3, 14, 19, 27, 37, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Quizs",
                keyColumn: "QuizID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 3, 14, 19, 27, 38, DateTimeKind.Local).AddTicks(2337));
        }
    }
}
