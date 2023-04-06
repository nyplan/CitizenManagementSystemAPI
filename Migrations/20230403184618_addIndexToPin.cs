using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitizenManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class addIndexToPin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Citizens_Pin",
                table: "Citizens",
                column: "Pin",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Citizens_Pin",
                table: "Citizens");
        }
    }
}
