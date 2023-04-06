using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitizenManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class dataSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EnumKeys",
                columns: new[] { "Id", "Key" },
                values: new object[] { 1, "gender" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "RegionName" },
                values: new object[] { 1, "Baku" });

            migrationBuilder.InsertData(
                table: "EnumValues",
                columns: new[] { "Id", "KeyId", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Male" },
                    { 2, 1, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Streets",
                columns: new[] { "StreetId", "RegionId", "StreetName" },
                values: new object[] { 1, 1, "Ehmed Recebli" });

            migrationBuilder.InsertData(
                table: "Entrances",
                columns: new[] { "EntranceId", "EntranceName", "StreetId" },
                values: new object[] { 1, "44A", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entrances",
                keyColumn: "EntranceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 1);
        }
    }
}
