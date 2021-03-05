using Microsoft.EntityFrameworkCore.Migrations;

namespace GDF_HRMS_v1.Migrations
{
    public partial class secondtry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Positions_PositionId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_PositionId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "EmployeePIs");

            migrationBuilder.AddColumn<int>(
                name: "PId",
                table: "EmployeePIs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_PId",
                table: "EmployeePIs",
                column: "PId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Positions_PId",
                table: "EmployeePIs",
                column: "PId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Positions_PId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_PId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "PId",
                table: "EmployeePIs");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_PositionId",
                table: "EmployeePIs",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Positions_PositionId",
                table: "EmployeePIs",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
