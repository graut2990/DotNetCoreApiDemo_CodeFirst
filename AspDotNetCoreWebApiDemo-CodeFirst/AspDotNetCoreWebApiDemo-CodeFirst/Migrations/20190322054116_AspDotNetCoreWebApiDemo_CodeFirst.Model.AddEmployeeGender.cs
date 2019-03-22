using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspDotNetCoreWebApiDemo_CodeFirst.Migrations
{
    public partial class AspDotNetCoreWebApiDemo_CodeFirstModelAddEmployeeGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 3L, new DateTime(1981, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "mary.kirsten@gmail.com", "mary", "Kirsten", "333-222-3333" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3L);
        }
    }
}
