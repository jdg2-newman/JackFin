using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88042ca0-fff2-41bc-9cd0-c5b4e501818a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa64ad10-63ef-4d70-86c1-8c7814a09f67");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "63965919-26e0-411e-b3c7-7ceb45200446", null, "User", "USER" },
                    { "8e5dfb1c-35a2-4a5b-bf22-dd5e84e4a6bf", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63965919-26e0-411e-b3c7-7ceb45200446");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e5dfb1c-35a2-4a5b-bf22-dd5e84e4a6bf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "88042ca0-fff2-41bc-9cd0-c5b4e501818a", null, "User", "USER" },
                    { "aa64ad10-63ef-4d70-86c1-8c7814a09f67", null, "Admin", "ADMIN" }
                });
        }
    }
}
