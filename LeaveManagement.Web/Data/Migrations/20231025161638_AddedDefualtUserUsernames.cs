using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefualtUserUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "689b27c6-6f69-464b-b0d9-62db8e40e12f",
                column: "ConcurrencyStamp",
                value: "1556cc21-88e3-4274-9377-63405c34127f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a75b7c6-69ac-464b-8de9-62db8e40c55f",
                column: "ConcurrencyStamp",
                value: "912cab90-0767-4be5-b55a-f4de74b8ac37");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2472464e-ec93-4402-b4e8-223818d7ffd1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "87589ee5-51d3-4177-9967-6cbba4910b6b", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEPSYD/5c+yZrYSoJfZCngPifm8kSLCOQSCXUbpBFdacq7Rw17We0vjp4tNHyQ//LvA==", "61f6eae3-4dc3-4b6e-a946-b7d82e11ebf1", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3788a3dc-1307-49de-b5e0-c7a5a053a8f5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fd96f205-5b8e-4d23-a060-30af14b13d9a", true, "USER@TEST.COM", "AQAAAAEAACcQAAAAEMkjMSC5WCNpwcJlwTm0TA9Bfm3/4yC7kFTLWhk/WLgqyE41fWj7zR9MJKvxoZYEyQ==", "fef78221-90dd-44d1-8b05-7c30ae9eea82", "user@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "689b27c6-6f69-464b-b0d9-62db8e40e12f",
                column: "ConcurrencyStamp",
                value: "9dbb23b9-0917-4a70-a5a2-7080c0fe0460");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a75b7c6-69ac-464b-8de9-62db8e40c55f",
                column: "ConcurrencyStamp",
                value: "dc68b924-376e-48fc-9c90-e1e7f403fd29");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2472464e-ec93-4402-b4e8-223818d7ffd1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "84f61e58-a20a-42b2-b355-3234db24b3cd", false, null, "AQAAAAEAACcQAAAAELGkvjl9mFDD75okOS9QwufdzUtjvvnCh7K3j3j5EBe443t7noiSKA+WFhmqI+/qlA==", "b5e48e22-e2ca-4e58-8fed-340c075b3d47", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3788a3dc-1307-49de-b5e0-c7a5a053a8f5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "095dea14-3fd8-4a5a-a459-a273c5a79df6", false, null, "AQAAAAEAACcQAAAAEIi6rSaCYJ/b/CWmIfU/0YcGblNkIr4wFQYjO4jFUb/LQRWQYa2EnuZdAzlwNV08QA==", "75cb5281-1f55-4ae3-8160-933d0dd9a3c1", null });
        }
    }
}
