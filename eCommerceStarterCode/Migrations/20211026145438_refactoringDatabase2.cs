using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class refactoringDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03781591-c003-44b1-b9fe-e20b6085e994");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cadb3cb-4ef6-4fc9-be4b-ec3b16f9a79c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60ee413b-d884-49bd-bfc0-f222c4eca2bf", "4f81b8cd-8e63-443a-a7fc-3b15ac8d63bb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b53c9d36-b6d4-4dc7-b844-98182bb8af74", "60a03914-4787-4c03-a6a3-df39266352b3", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60ee413b-d884-49bd-bfc0-f222c4eca2bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b53c9d36-b6d4-4dc7-b844-98182bb8af74");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cadb3cb-4ef6-4fc9-be4b-ec3b16f9a79c", "df677605-a224-4d87-81d0-8cba19b6fbea", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03781591-c003-44b1-b9fe-e20b6085e994", "6f5e7dcc-8f9c-49da-8732-82c933ac146d", "Admin", "ADMIN" });
        }
    }
}
