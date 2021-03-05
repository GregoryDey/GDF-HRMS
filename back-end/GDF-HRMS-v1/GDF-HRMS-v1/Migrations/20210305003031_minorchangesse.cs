using Microsoft.EntityFrameworkCore.Migrations;

namespace GDF_HRMS_v1.Migrations
{
    public partial class minorchangesse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Countries_CCId",
                table: "EmployeePIs");

            migrationBuilder.RenameColumn(
                name: "CCId",
                table: "EmployeePIs",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeePIs_CCId",
                table: "EmployeePIs",
                newName: "IX_EmployeePIs_CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Countries_CountryId",
                table: "EmployeePIs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Countries_CountryId",
                table: "EmployeePIs");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "EmployeePIs",
                newName: "CCId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeePIs_CountryId",
                table: "EmployeePIs",
                newName: "IX_EmployeePIs_CCId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Countries_CCId",
                table: "EmployeePIs",
                column: "CCId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
