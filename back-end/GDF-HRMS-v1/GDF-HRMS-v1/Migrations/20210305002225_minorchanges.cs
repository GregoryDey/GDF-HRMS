using Microsoft.EntityFrameworkCore.Migrations;

namespace GDF_HRMS_v1.Migrations
{
    public partial class minorchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CCId",
                table: "EmployeePIs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CareerHistoryId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_CareerHistoryId",
                table: "EmployeePIs",
                column: "CareerHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_CCId",
                table: "EmployeePIs",
                column: "CCId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_DepartmentId",
                table: "EmployeePIs",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_PositionId",
                table: "EmployeePIs",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_RegionId",
                table: "EmployeePIs",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_CareerHistories_CareerHistoryId",
                table: "EmployeePIs",
                column: "CareerHistoryId",
                principalTable: "CareerHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Countries_CCId",
                table: "EmployeePIs",
                column: "CCId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Departments_DepartmentId",
                table: "EmployeePIs",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Positions_PositionId",
                table: "EmployeePIs",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Regions_RegionId",
                table: "EmployeePIs",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_CareerHistories_CareerHistoryId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Countries_CCId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Departments_DepartmentId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Positions_PositionId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Regions_RegionId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_CareerHistoryId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_CCId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_DepartmentId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_PositionId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_RegionId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "CCId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "CareerHistoryId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "EmployeePIs");
        }
    }
}
