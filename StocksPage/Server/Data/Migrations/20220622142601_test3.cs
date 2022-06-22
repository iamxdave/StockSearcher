using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksPage.Server.Data.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WatchlistTickerDetail",
                column: "IdWatchlistTickerDetail",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WatchlistTickerDetail",
                keyColumn: "IdWatchlistTickerDetail",
                keyValue: 1);
        }
    }
}
