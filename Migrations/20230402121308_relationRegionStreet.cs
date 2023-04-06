using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitizenManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class relationRegionStreet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "Streets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Streets_RegionId",
                table: "Streets",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Streets_Regions_RegionId",
                table: "Streets",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "RegionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Streets_Regions_RegionId",
                table: "Streets");

            migrationBuilder.DropIndex(
                name: "IX_Streets_RegionId",
                table: "Streets");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Streets");
        }
    }
}
