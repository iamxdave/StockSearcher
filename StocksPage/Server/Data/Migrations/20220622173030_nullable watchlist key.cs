using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksPage.Server.Data.Migrations
{
    public partial class nullablewatchlistkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdWatchlistTickerDetail",
                table: "TickerDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdWatchlistTickerDetail",
                table: "TickerDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
