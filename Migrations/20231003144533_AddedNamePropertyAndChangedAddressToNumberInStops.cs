using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BussesRouteMiniProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedNamePropertyAndChangedAddressToNumberInStops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Stops",
                newName: "Number");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Stops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Stops");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Stops",
                newName: "Address");
        }
    }
}
