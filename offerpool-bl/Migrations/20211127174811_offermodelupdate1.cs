using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace offerpool_bl.Migrations
{
    public partial class offermodelupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "offer_list_header",
                table: "Offer",
                newName: "offer_header");

            migrationBuilder.RenameColumn(
                name: "offer_list_id",
                table: "Offer",
                newName: "offer_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "offer_header",
                table: "Offer",
                newName: "offer_list_header");

            migrationBuilder.RenameColumn(
                name: "offer_id",
                table: "Offer",
                newName: "offer_list_id");
        }
    }
}
