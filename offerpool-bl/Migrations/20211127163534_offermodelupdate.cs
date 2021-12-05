using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace offerpool_bl.Migrations
{
    public partial class offermodelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfferData");

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    offer_list_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    offer_list_header = table.Column<string>(type: "text", nullable: false),
                    offer_contact = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.offer_list_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offer");

            migrationBuilder.CreateTable(
                name: "OfferData",
                columns: table => new
                {
                    offer_list_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    offer_contanct = table.Column<string>(type: "text", nullable: true),
                    offer_list_header = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferData", x => x.offer_list_id);
                });
        }
    }
}
