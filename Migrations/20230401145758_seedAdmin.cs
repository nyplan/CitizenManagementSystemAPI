using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitizenManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "ManagerId", "Name", "Password", "Surname", "Username" },
                values: new object[] { 1, "Nurlan", "password", "Khankishiyev", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: 1);
        }
    }
}
