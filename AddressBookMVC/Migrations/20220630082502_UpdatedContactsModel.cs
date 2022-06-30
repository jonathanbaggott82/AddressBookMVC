using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddressBookMVC.Migrations
{
    public partial class UpdatedContactsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Contacts",
                newName: "PostCode");

            migrationBuilder.AddColumn<string>(
                name: "County",
                table: "Contacts",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "County",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "PostCode",
                table: "Contacts",
                newName: "State");

            migrationBuilder.AddColumn<int>(
                name: "Zip",
                table: "Contacts",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
