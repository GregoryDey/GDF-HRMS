using Microsoft.EntityFrameworkCore.Migrations;

namespace GDF_HRMS_v1.Migrations
{
    public partial class removedTheContactInfoModelAndMadeAddressACHildOfEmployeePi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Addresses_AId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_ContactInfos_CId",
                table: "EmployeePIs");

            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_AId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_CId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "AId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "CId",
                table: "EmployeePIs");

            migrationBuilder.AddColumn<int>(
                name: "CNumber",
                table: "EmployeePIs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "EmployeePIs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HNumber",
                table: "EmployeePIs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WNumber",
                table: "EmployeePIs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Lot",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_EId",
                table: "Addresses",
                column: "EId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_EmployeePIs_EId",
                table: "Addresses",
                column: "EId",
                principalTable: "EmployeePIs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_EmployeePIs_EId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_EId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CNumber",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "HNumber",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "WNumber",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "EId",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "AId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lot",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HNumber = table.Column<int>(type: "int", nullable: false),
                    WNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_AId",
                table: "EmployeePIs",
                column: "AId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_CId",
                table: "EmployeePIs",
                column: "CId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Addresses_AId",
                table: "EmployeePIs",
                column: "AId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_ContactInfos_CId",
                table: "EmployeePIs",
                column: "CId",
                principalTable: "ContactInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
