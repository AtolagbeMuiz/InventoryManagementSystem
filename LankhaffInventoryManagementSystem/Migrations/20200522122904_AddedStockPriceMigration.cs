using Microsoft.EntityFrameworkCore.Migrations;

namespace LankhaffInventoryManagementSystem.Migrations
{
    public partial class AddedStockPriceMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockPrice",
                table: "Stocks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockPrice",
                table: "Stocks");
        }
    }
}
