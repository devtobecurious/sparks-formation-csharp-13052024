using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecouverteEfCore.Migrations
{
    /// <inheritdoc />
    public partial class AddHeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Orc",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "Orc");
        }
    }
}
