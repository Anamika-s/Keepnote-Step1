using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Keepnote_Step1.Migrations
{
    /// <inheritdoc />
    public partial class fapi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Courses_CourseId",
                table: "Batches");

            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Trainers_TrainerId",
                table: "Batches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Batches",
                table: "Batches");

            migrationBuilder.RenameTable(
                name: "Batches",
                newName: "tblBatch");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "tblUsers",
                newName: "SecondName");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "tblBatch",
                newName: "BatchStartDate");

            migrationBuilder.RenameIndex(
                name: "IX_Batches_TrainerId",
                table: "tblBatch",
                newName: "IX_tblBatch_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_Batches_CourseId",
                table: "tblBatch",
                newName: "IX_tblBatch_CourseId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BatchStartDate",
                table: "tblBatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 24, 11, 17, 37, 553, DateTimeKind.Local).AddTicks(8076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblBatch",
                table: "tblBatch",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblBatch_Courses_CourseId",
                table: "tblBatch",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblBatch_Trainers_TrainerId",
                table: "tblBatch",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblBatch_Courses_CourseId",
                table: "tblBatch");

            migrationBuilder.DropForeignKey(
                name: "FK_tblBatch_Trainers_TrainerId",
                table: "tblBatch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblBatch",
                table: "tblBatch");

            migrationBuilder.RenameTable(
                name: "tblBatch",
                newName: "Batches");

            migrationBuilder.RenameColumn(
                name: "SecondName",
                table: "tblUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "BatchStartDate",
                table: "Batches",
                newName: "StartDate");

            migrationBuilder.RenameIndex(
                name: "IX_tblBatch_TrainerId",
                table: "Batches",
                newName: "IX_Batches_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_tblBatch_CourseId",
                table: "Batches",
                newName: "IX_Batches_CourseId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Batches",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 24, 11, 17, 37, 553, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Batches",
                table: "Batches",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Courses_CourseId",
                table: "Batches",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Trainers_TrainerId",
                table: "Batches",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
