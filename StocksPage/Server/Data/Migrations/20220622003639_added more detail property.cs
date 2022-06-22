using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksPage.Server.Data.Migrations
{
    public partial class addedmoredetailproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TickerDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Homepage",
                table: "TickerDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TotalEmployees",
                table: "TickerDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TickerDetail");

            migrationBuilder.DropColumn(
                name: "Homepage",
                table: "TickerDetail");

            migrationBuilder.DropColumn(
                name: "TotalEmployees",
                table: "TickerDetail");
        }
    }
}
