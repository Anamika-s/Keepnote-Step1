using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Keepnote_Step1.Migrations
{
    /// <inheritdoc />
    public partial class AddedUpdatesDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Notes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Notes");
        }
    }
}
