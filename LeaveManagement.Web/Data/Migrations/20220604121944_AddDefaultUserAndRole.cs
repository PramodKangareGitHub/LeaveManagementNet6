using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddDefaultUserAndRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5c72a9cb-58cd-4122-99a4-845a5db735pp", "fd665e6a-7540-4134-82de-b7796b0287f1", "Administrator", "ADMINISTRATOR" },
                    { "cc61a9cb-60cd-4198-85a4-845a5db735pp", "e0ac74aa-e91e-45da-8168-e2df52315464", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1c61a9cb-58cd-4098-85a4-845a5db735cc", 0, "91ba92c3-6694-4b5c-8155-e72a7479b8c4", null, null, "pramodkangare2@gmail.com", false, "Pramod", "Kangare", false, null, "PRAMODKANGARE2@gmail.com", null, "AQAAAAEAACcQAAAAEANEasRns5w+t+V/YHcIFrodNolJ4+9acSBz7X1qD09jQXzuLRlVk8aiM/cKP+qa5w==", null, false, "52271181-deed-4269-9a02-5e1c5d2dcb36", null, false, null },
                    { "9c61a9cb-58cd-4098-85a4-999a5db735cc", 0, "826d0610-966a-404d-817f-b2ce95be35cf", null, null, "pramodkangare3@gmail.com", false, "System", "User", false, null, "PRAMODKANGARE3@gmail.com", null, "AQAAAAEAACcQAAAAEIjAuecFR5i2pzi3sDkEyYSoUA5fuygaR88mKRwMuabgQkB7WusCrm6j9MlaBDJq2g==", null, false, "8f232ba4-cba3-42af-8afd-72ec0270766c", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5c72a9cb-58cd-4122-99a4-845a5db735pp", "1c61a9cb-58cd-4098-85a4-845a5db735cc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc61a9cb-60cd-4198-85a4-845a5db735pp", "9c61a9cb-58cd-4098-85a4-999a5db735cc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5c72a9cb-58cd-4122-99a4-845a5db735pp", "1c61a9cb-58cd-4098-85a4-845a5db735cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc61a9cb-60cd-4198-85a4-845a5db735pp", "9c61a9cb-58cd-4098-85a4-999a5db735cc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c72a9cb-58cd-4122-99a4-845a5db735pp");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc61a9cb-60cd-4198-85a4-845a5db735pp");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c61a9cb-58cd-4098-85a4-845a5db735cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c61a9cb-58cd-4098-85a4-999a5db735cc");
        }
    }
}
