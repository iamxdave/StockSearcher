using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksPage.Server.Data.Migrations
{
    public partial class addedwatchlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdWatchlistTickerDetail",
                table: "TickerDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WatchlistTickerDetail",
                columns: table => new
                {
                    IdWatchlistTickerDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchlistTickerDetail", x => x.IdWatchlistTickerDetail);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TickerDetail_IdWatchlistTickerDetail",
                table: "TickerDetail",
                column: "IdWatchlistTickerDetail");

            migrationBuilder.AddForeignKey(
                name: "FK_TickerDetail_WatchlistTickerDetail_IdWatchlistTickerDetail",
                table: "TickerDetail",
                column: "IdWatchlistTickerDetail",
                principalTable: "WatchlistTickerDetail",
                principalColumn: "IdWatchlistTickerDetail",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TickerDetail_WatchlistTickerDetail_IdWatchlistTickerDetail",
                table: "TickerDetail");

            migrationBuilder.DropTable(
                name: "WatchlistTickerDetail");

            migrationBuilder.DropIndex(
                name: "IX_TickerDetail_IdWatchlistTickerDetail",
                table: "TickerDetail");

            migrationBuilder.DropColumn(
                name: "IdWatchlistTickerDetail",
                table: "TickerDetail");
        }
    }
}
