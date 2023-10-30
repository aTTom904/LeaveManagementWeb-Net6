using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "689b27c6-6f69-464b-b0d9-62db8e40e12f", "9dbb23b9-0917-4a70-a5a2-7080c0fe0460", "Administrator", "ADMINISTRATOR" },
                    { "6a75b7c6-69ac-464b-8de9-62db8e40c55f", "dc68b924-376e-48fc-9c90-e1e7f403fd29", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2472464e-ec93-4402-b4e8-223818d7ffd1", 0, "84f61e58-a20a-42b2-b355-3234db24b3cd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "System", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAELGkvjl9mFDD75okOS9QwufdzUtjvvnCh7K3j3j5EBe443t7noiSKA+WFhmqI+/qlA==", null, false, "b5e48e22-e2ca-4e58-8fed-340c075b3d47", null, false, null },
                    { "3788a3dc-1307-49de-b5e0-c7a5a053a8f5", 0, "095dea14-3fd8-4a5a-a459-a273c5a79df6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@test.com", false, "System", "User", false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEIi6rSaCYJ/b/CWmIfU/0YcGblNkIr4wFQYjO4jFUb/LQRWQYa2EnuZdAzlwNV08QA==", null, false, "75cb5281-1f55-4ae3-8160-933d0dd9a3c1", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "689b27c6-6f69-464b-b0d9-62db8e40e12f", "2472464e-ec93-4402-b4e8-223818d7ffd1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6a75b7c6-69ac-464b-8de9-62db8e40c55f", "3788a3dc-1307-49de-b5e0-c7a5a053a8f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "689b27c6-6f69-464b-b0d9-62db8e40e12f", "2472464e-ec93-4402-b4e8-223818d7ffd1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6a75b7c6-69ac-464b-8de9-62db8e40c55f", "3788a3dc-1307-49de-b5e0-c7a5a053a8f5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "689b27c6-6f69-464b-b0d9-62db8e40e12f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a75b7c6-69ac-464b-8de9-62db8e40c55f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2472464e-ec93-4402-b4e8-223818d7ffd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3788a3dc-1307-49de-b5e0-c7a5a053a8f5");
        }
    }
}
