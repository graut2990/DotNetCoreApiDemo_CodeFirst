using Microsoft.EntityFrameworkCore.Migrations;

namespace AspDotNetCoreWebApiDemo_CodeFirst.Migrations
{
    public partial class AspDotNetCoreWebApiDemo_CodeFirstModelAddEmployeeGenderAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");
        }
    }
}
