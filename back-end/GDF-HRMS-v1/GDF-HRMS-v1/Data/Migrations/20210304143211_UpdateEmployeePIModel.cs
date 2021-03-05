using Microsoft.EntityFrameworkCore.Migrations;

namespace GDF_HRMS_v1.Migrations
{
    public partial class UpdateEmployeePIModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Addresses_AId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_ContactInfos_CId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Ethnicities_EId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_MaritalStatuses_MId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Nationalities_NId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Religions_RId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_AId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_CId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_EId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_MId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_NId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_RId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "AId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "CId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "EId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "MId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "NId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "RId",
                table: "EmployeePIs");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactInfoId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EthnicityId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaritalStatusId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReligionId",
                table: "EmployeePIs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_AddressId",
                table: "EmployeePIs",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_ContactInfoId",
                table: "EmployeePIs",
                column: "ContactInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_EthnicityId",
                table: "EmployeePIs",
                column: "EthnicityId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_MaritalStatusId",
                table: "EmployeePIs",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_NationalityId",
                table: "EmployeePIs",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_ReligionId",
                table: "EmployeePIs",
                column: "ReligionId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Addresses_AddressId",
                table: "EmployeePIs",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_ContactInfos_ContactInfoId",
                table: "EmployeePIs",
                column: "ContactInfoId",
                principalTable: "ContactInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Ethnicities_EthnicityId",
                table: "EmployeePIs",
                column: "EthnicityId",
                principalTable: "Ethnicities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_MaritalStatuses_MaritalStatusId",
                table: "EmployeePIs",
                column: "MaritalStatusId",
                principalTable: "MaritalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Nationalities_NationalityId",
                table: "EmployeePIs",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Religions_ReligionId",
                table: "EmployeePIs",
                column: "ReligionId",
                principalTable: "Religions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Addresses_AddressId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_ContactInfos_ContactInfoId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Ethnicities_EthnicityId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_MaritalStatuses_MaritalStatusId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Nationalities_NationalityId",
                table: "EmployeePIs");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePIs_Religions_ReligionId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_AddressId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_ContactInfoId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_EthnicityId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_MaritalStatusId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_NationalityId",
                table: "EmployeePIs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePIs_ReligionId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "EthnicityId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "MaritalStatusId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "EmployeePIs");

            migrationBuilder.DropColumn(
                name: "ReligionId",
                table: "EmployeePIs");

            migrationBuilder.AddColumn<int>(
                name: "AId",
                table: "EmployeePIs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CId",
                table: "EmployeePIs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EId",
                table: "EmployeePIs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MId",
                table: "EmployeePIs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NId",
                table: "EmployeePIs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RId",
                table: "EmployeePIs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_AId",
                table: "EmployeePIs",
                column: "AId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_CId",
                table: "EmployeePIs",
                column: "CId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_EId",
                table: "EmployeePIs",
                column: "EId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_MId",
                table: "EmployeePIs",
                column: "MId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_NId",
                table: "EmployeePIs",
                column: "NId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePIs_RId",
                table: "EmployeePIs",
                column: "RId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Addresses_AId",
                table: "EmployeePIs",
                column: "AId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_ContactInfos_CId",
                table: "EmployeePIs",
                column: "CId",
                principalTable: "ContactInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Ethnicities_EId",
                table: "EmployeePIs",
                column: "EId",
                principalTable: "Ethnicities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_MaritalStatuses_MId",
                table: "EmployeePIs",
                column: "MId",
                principalTable: "MaritalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Nationalities_NId",
                table: "EmployeePIs",
                column: "NId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePIs_Religions_RId",
                table: "EmployeePIs",
                column: "RId",
                principalTable: "Religions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
