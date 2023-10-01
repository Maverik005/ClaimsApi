using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClaimsApi.Migrations
{
    /// <inheritdoc />
    public partial class RestrictDeleteForFKs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClaimUserDetails_Countries_CountryId",
                table: "ClaimUserDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimUserDetails_States_StateId",
                table: "ClaimUserDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimUserDetails_Countries_CountryId",
                table: "ClaimUserDetails",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimUserDetails_States_StateId",
                table: "ClaimUserDetails",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClaimUserDetails_Countries_CountryId",
                table: "ClaimUserDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimUserDetails_States_StateId",
                table: "ClaimUserDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimUserDetails_Countries_CountryId",
                table: "ClaimUserDetails",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimUserDetails_States_StateId",
                table: "ClaimUserDetails",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");
        }
    }
}
