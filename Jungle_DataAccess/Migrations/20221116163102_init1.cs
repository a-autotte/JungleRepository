using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jungle_DataAccess.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HistoriqueTravel_Id",
                table: "Travel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HistoriqueTravel",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NbParticipant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriqueTravel", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 1,
                column: "DepartureDate",
                value: new DateTime(2022, 12, 7, 11, 31, 1, 682, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 2,
                column: "DepartureDate",
                value: new DateTime(2022, 11, 25, 11, 31, 1, 682, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 3,
                column: "DepartureDate",
                value: new DateTime(2022, 11, 30, 11, 31, 1, 682, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.CreateIndex(
                name: "IX_Travel_HistoriqueTravel_Id",
                table: "Travel",
                column: "HistoriqueTravel_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Travel_HistoriqueTravel_HistoriqueTravel_Id",
                table: "Travel",
                column: "HistoriqueTravel_Id",
                principalTable: "HistoriqueTravel",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travel_HistoriqueTravel_HistoriqueTravel_Id",
                table: "Travel");

            migrationBuilder.DropTable(
                name: "HistoriqueTravel");

            migrationBuilder.DropIndex(
                name: "IX_Travel_HistoriqueTravel_Id",
                table: "Travel");

            migrationBuilder.DropColumn(
                name: "HistoriqueTravel_Id",
                table: "Travel");

            migrationBuilder.UpdateData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 1,
                column: "DepartureDate",
                value: new DateTime(2022, 12, 7, 10, 54, 22, 269, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 2,
                column: "DepartureDate",
                value: new DateTime(2022, 11, 25, 10, 54, 22, 269, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 3,
                column: "DepartureDate",
                value: new DateTime(2022, 11, 30, 10, 54, 22, 269, DateTimeKind.Local).AddTicks(8446));
        }
    }
}
