using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddDefaultUserAndRole1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c72a9cb-58cd-4122-99a4-845a5db735pp",
                column: "ConcurrencyStamp",
                value: "3bd058c9-23f9-4a21-89ae-7172191f9a82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc61a9cb-60cd-4198-85a4-845a5db735pp",
                column: "ConcurrencyStamp",
                value: "f44c6f89-c2c5-4531-8a59-59a789a3c34b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c61a9cb-58cd-4098-85a4-845a5db735cc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "FirstName", "LastName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3c2cfe06-903b-4d32-9538-3593b53c87f9", true, "System", "Admin", "PRAMODKANGARE2@gmail.com", "AQAAAAEAACcQAAAAEKyFGIRtoQH+WU8M6cr40gh4ZDAYjhedin7nhKqULBc1O69EMbOfcAwseFg1O39U7w==", "3cbfc8f6-0519-4db0-836e-4a4a24ff8a55", "pramodkangare2@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c61a9cb-58cd-4098-85a4-999a5db735cc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6260f027-cad4-4928-a235-556fc4e62d43", true, "PRAMODKANGARE3@gmail.com", "AQAAAAEAACcQAAAAEEZ5tj5P7K/gN2tEtnSyPr5Sul3yw4jOISTyYUmJzZKY4z7ojpT4BW0b/WH9jd3u9w==", "db856afa-9a1a-419c-a116-3f72bcac6d80", "pramodkangare3@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c72a9cb-58cd-4122-99a4-845a5db735pp",
                column: "ConcurrencyStamp",
                value: "fd665e6a-7540-4134-82de-b7796b0287f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc61a9cb-60cd-4198-85a4-845a5db735pp",
                column: "ConcurrencyStamp",
                value: "e0ac74aa-e91e-45da-8168-e2df52315464");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c61a9cb-58cd-4098-85a4-845a5db735cc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "FirstName", "LastName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "91ba92c3-6694-4b5c-8155-e72a7479b8c4", false, "Pramod", "Kangare", null, "AQAAAAEAACcQAAAAEANEasRns5w+t+V/YHcIFrodNolJ4+9acSBz7X1qD09jQXzuLRlVk8aiM/cKP+qa5w==", "52271181-deed-4269-9a02-5e1c5d2dcb36", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c61a9cb-58cd-4098-85a4-999a5db735cc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "826d0610-966a-404d-817f-b2ce95be35cf", false, null, "AQAAAAEAACcQAAAAEIjAuecFR5i2pzi3sDkEyYSoUA5fuygaR88mKRwMuabgQkB7WusCrm6j9MlaBDJq2g==", "8f232ba4-cba3-42af-8afd-72ec0270766c", null });
        }
    }
}
