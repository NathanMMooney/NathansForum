using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NathansForum.Migrations
{
    /// <inheritdoc />
    public partial class contentLimit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Discussion");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Discussion",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Discussion",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Discussion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
