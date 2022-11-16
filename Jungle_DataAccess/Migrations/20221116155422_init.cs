using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jungle_DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "France" });

            migrationBuilder.InsertData(
                table: "Guide",
                columns: new[] { "Id", "FirstName", "LastName", "Speciality" },
                values: new object[] { 1, "Jean", "Pierre", "Avec les parisien" });

            migrationBuilder.InsertData(
                table: "TravelRecommendation",
                columns: new[] { "Id", "DangerLevel", "Description", "Type" },
                values: new object[] { 1, "5", "Les parisien peuvent être impatient", "Social" });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "Country_Id", "Name", "Region" },
                values: new object[] { 1, 1, "Tour Effiel", "Paris" });

            migrationBuilder.InsertData(
                table: "Travel",
                columns: new[] { "Id", "DepartureDate", "Description", "Destination_Id", "Duration", "Guide_Id", "Name", "Price", "TravelRecommendation_Id" },
                values: new object[] { 1, new DateTime(2022, 12, 7, 10, 54, 22, 269, DateTimeKind.Local).AddTicks(8358), "Voyage en france", 1, 3200, 1, "France", 1200.99m, 1 });

            migrationBuilder.InsertData(
                table: "Travel",
                columns: new[] { "Id", "DepartureDate", "Description", "Destination_Id", "Duration", "Guide_Id", "Name", "Price", "TravelRecommendation_Id" },
                values: new object[] { 2, new DateTime(2022, 11, 25, 10, 54, 22, 269, DateTimeKind.Local).AddTicks(8432), "Voyage en égypte", 1, 3200, 1, "Égypte", 1528.99m, 1 });

            migrationBuilder.InsertData(
                table: "Travel",
                columns: new[] { "Id", "DepartureDate", "Description", "Destination_Id", "Duration", "Guide_Id", "Name", "Price", "TravelRecommendation_Id" },
                values: new object[] { 3, new DateTime(2022, 11, 30, 10, 54, 22, 269, DateTimeKind.Local).AddTicks(8446), "Voyage en Afrique", 1, 3200, 1, "Afrique", 999.99m, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guide",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TravelRecommendation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
