using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_LawyerType",
                table: "LawyerType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.RenameTable(
                name: "LawyerType",
                newName: "LawyerTypes");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LawyerTypes",
                table: "LawyerTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Contacts_ContactId",
                table: "Clients",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyers_Contacts_ContactId",
                table: "Lawyers",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyers_LawyerTypes_LawyerTypeId",
                table: "Lawyers",
                column: "LawyerTypeId",
                principalTable: "LawyerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Contacts_ContactId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Lawyers_Contacts_ContactId",
                table: "Lawyers");

            migrationBuilder.DropForeignKey(
                name: "FK_Lawyers_LawyerTypes_LawyerTypeId",
                table: "Lawyers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LawyerTypes",
                table: "LawyerTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "LawyerTypes",
                newName: "LawyerType");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LawyerType",
                table: "LawyerType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

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
    }
}
