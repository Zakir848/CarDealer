using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealer.Migrations
{
    /// <inheritdoc />
    public partial class Change_car : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Owners",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Cars",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Owners",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cars",
                newName: "CarId");
        }
    }
}
