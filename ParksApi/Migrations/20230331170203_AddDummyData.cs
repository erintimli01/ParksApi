using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksApi.Migrations
{
    public partial class AddDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "City", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Springdale", "Zion National Park", "Utah" },
                    { 2, "Sacramento", "Yosemite National Park", "California" },
                    { 3, "Tusayan", "Grand Canyon National Park", "Arizona" },
                    { 4, "Big Bend", "Big Bend National Park", "Texas" },
                    { 5, "Gardiner", "Yellowstone National Park", "Montana" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);
        }
    }
}
