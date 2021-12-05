using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace offerpool_bl.Migrations
{
    public partial class addContactName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "offer_contact",
                table: "OfferData",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "offer_contanct",
                table: "OfferData");
        }
    }
}
