using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitizenManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class relationsForCitizen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BirthPlaceId",
                table: "Citizens",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentPlaceId",
                table: "Citizens",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FatherId",
                table: "Citizens",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Citizens",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MotherId",
                table: "Citizens",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_BirthPlaceId",
                table: "Citizens",
                column: "BirthPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_CurrentPlaceId",
                table: "Citizens",
                column: "CurrentPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_FatherId",
                table: "Citizens",
                column: "FatherId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_GenderId",
                table: "Citizens",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_MotherId",
                table: "Citizens",
                column: "MotherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citizens_Citizens_FatherId",
                table: "Citizens",
                column: "FatherId",
                principalTable: "Citizens",
                principalColumn: "CitizenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citizens_Citizens_MotherId",
                table: "Citizens",
                column: "MotherId",
                principalTable: "Citizens",
                principalColumn: "CitizenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citizens_CurrentPlaces_CurrentPlaceId",
                table: "Citizens",
                column: "CurrentPlaceId",
                principalTable: "CurrentPlaces",
                principalColumn: "CurrentPlaceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citizens_EnumValues_GenderId",
                table: "Citizens",
                column: "GenderId",
                principalTable: "EnumValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citizens_Regions_BirthPlaceId",
                table: "Citizens",
                column: "BirthPlaceId",
                principalTable: "Regions",
                principalColumn: "RegionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citizens_Citizens_FatherId",
                table: "Citizens");

            migrationBuilder.DropForeignKey(
                name: "FK_Citizens_Citizens_MotherId",
                table: "Citizens");

            migrationBuilder.DropForeignKey(
                name: "FK_Citizens_CurrentPlaces_CurrentPlaceId",
                table: "Citizens");

            migrationBuilder.DropForeignKey(
                name: "FK_Citizens_EnumValues_GenderId",
                table: "Citizens");

            migrationBuilder.DropForeignKey(
                name: "FK_Citizens_Regions_BirthPlaceId",
                table: "Citizens");

            migrationBuilder.DropIndex(
                name: "IX_Citizens_BirthPlaceId",
                table: "Citizens");

            migrationBuilder.DropIndex(
                name: "IX_Citizens_CurrentPlaceId",
                table: "Citizens");

            migrationBuilder.DropIndex(
                name: "IX_Citizens_FatherId",
                table: "Citizens");

            migrationBuilder.DropIndex(
                name: "IX_Citizens_GenderId",
                table: "Citizens");

            migrationBuilder.DropIndex(
                name: "IX_Citizens_MotherId",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "BirthPlaceId",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "CurrentPlaceId",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "FatherId",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "MotherId",
                table: "Citizens");
        }
    }
}
