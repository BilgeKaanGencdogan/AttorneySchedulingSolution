using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactNo",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "TypeOfLawyer",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "ContactNo",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AddressOfAppointment",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "DateOfAppointment",
                table: "Appointments",
                newName: "StartDateOfAppointment");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Lawyers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Lawyers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LawyerTypeId",
                table: "Lawyers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Lawyers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateOfAppointment",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyProperty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LawyerType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawyerType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lawyers_ContactId",
                table: "Lawyers",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Lawyers_LawyerTypeId",
                table: "Lawyers",
                column: "LawyerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ContactId",
                table: "Clients",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Contact_ContactId",
                table: "Clients",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyers_Contact_ContactId",
                table: "Lawyers",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyers_LawyerType_LawyerTypeId",
                table: "Lawyers",
                column: "LawyerTypeId",
                principalTable: "LawyerType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Contact_ContactId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Lawyers_Contact_ContactId",
                table: "Lawyers");

            migrationBuilder.DropForeignKey(
                name: "FK_Lawyers_LawyerType_LawyerTypeId",
                table: "Lawyers");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "LawyerType");

            migrationBuilder.DropIndex(
                name: "IX_Lawyers_ContactId",
                table: "Lawyers");

            migrationBuilder.DropIndex(
                name: "IX_Lawyers_LawyerTypeId",
                table: "Lawyers");

            migrationBuilder.DropIndex(
                name: "IX_Clients_ContactId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "LawyerTypeId",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "EndDateOfAppointment",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "StartDateOfAppointment",
                table: "Appointments",
                newName: "DateOfAppointment");

            migrationBuilder.AddColumn<string>(
                name: "ContactNo",
                table: "Lawyers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfLawyer",
                table: "Lawyers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactNo",
                table: "Clients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressOfAppointment",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Appointments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }
    }
}
