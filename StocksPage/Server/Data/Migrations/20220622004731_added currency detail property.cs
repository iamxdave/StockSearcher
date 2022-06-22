using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksPage.Server.Data.Migrations
{
    public partial class addedcurrencydetailproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "TickerDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "TickerDetail");
        }
    }
}
