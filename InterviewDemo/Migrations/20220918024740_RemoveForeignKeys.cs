using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewDemo.Migrations
{
    public partial class RemoveForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Warehouses_LocationId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Addresses");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_LocationId",
                table: "Warehouses",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Warehouses_LocationId",
                table: "Warehouses");

            migrationBuilder.AddColumn<int>(
                name: "WarehouseId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_LocationId",
                table: "Warehouses",
                column: "LocationId",
                unique: true,
                filter: "[LocationId] IS NOT NULL");
        }
    }
}
