using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tatiana.Migrations
{
    /// <inheritdoc />
    public partial class paquetito2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "apellido",
                table: "Sapas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "apellido",
                table: "Sapas");
        }
    }
}
