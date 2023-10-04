using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClaimsApi.Migrations
{
    /// <inheritdoc />
    public partial class IsDeletedandClaimTitleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClaimTitle",
                table: "Claims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Claims",
                type: "bit",
                nullable: false,
                defaultValueSql: "1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClaimTitle",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Claims");
        }
    }
}
