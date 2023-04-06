using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitizenManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class relationStreetEntrance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StreetId",
                table: "Entrances",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_StreetId",
                table: "Entrances",
                column: "StreetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrances_Streets_StreetId",
                table: "Entrances",
                column: "StreetId",
                principalTable: "Streets",
                principalColumn: "StreetId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrances_Streets_StreetId",
                table: "Entrances");

            migrationBuilder.DropIndex(
                name: "IX_Entrances_StreetId",
                table: "Entrances");

            migrationBuilder.DropColumn(
                name: "StreetId",
                table: "Entrances");
        }
    }
}
