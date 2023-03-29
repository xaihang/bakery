using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetBakery.Migrations
{
    /// <inheritdoc />
    public partial class CreateBreadTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "Breads",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "Breads");
        }
    }
}
