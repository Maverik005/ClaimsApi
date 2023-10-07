using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClaimsApi.Migrations
{
    /// <inheritdoc />
    public partial class PincodeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pincode",
                table: "ClaimUserDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "ClaimUserDetails");
        }
    }
}
