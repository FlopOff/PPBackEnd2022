using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AT1__PerfectPolicy_.Migrations
{
    public partial class addedQuizIDtoQuestionsandremovedquizTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Quizs_QuizID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuizTitle",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "QuizID",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Quizs_QuizID",
                table: "Questions",
                column: "QuizID",
                principalTable: "Quizs",
                principalColumn: "QuizID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Quizs_QuizID",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "QuizID",
                table: "Questions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "QuizTitle",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Quizs",
                keyColumn: "QuizID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 2, 13, 27, 59, 918, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Quizs",
                keyColumn: "QuizID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 2, 13, 27, 59, 919, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Quizs_QuizID",
                table: "Questions",
                column: "QuizID",
                principalTable: "Quizs",
                principalColumn: "QuizID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
