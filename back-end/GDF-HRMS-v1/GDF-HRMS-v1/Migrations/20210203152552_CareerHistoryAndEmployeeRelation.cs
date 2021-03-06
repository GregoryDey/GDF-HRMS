using Microsoft.EntityFrameworkCore.Migrations;

namespace GDF_HRMS_v1.Migrations
{
    public partial class CareerHistoryAndEmployeeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CareerHistories_EId",
                table: "CareerHistories",
                column: "EId");

            migrationBuilder.AddForeignKey(
                name: "FK_CareerHistories_EmployeePIs_EId",
                table: "CareerHistories",
                column: "EId",
                principalTable: "EmployeePIs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CareerHistories_EmployeePIs_EId",
                table: "CareerHistories");

            migrationBuilder.DropIndex(
                name: "IX_CareerHistories_EId",
                table: "CareerHistories");
        }
    }
}
