using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vessels.Data
{
    /// <inheritdoc />
    public partial class inti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vessels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vessels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Vessels",
                columns: new[] { "Id", "ArrivalDate", "DepartureDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 12, 16, 49, 22, 94, DateTimeKind.Local).AddTicks(9373), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ship 1", "Intransit" },
                    { 3, new DateTime(2024, 8, 12, 16, 49, 22, 94, DateTimeKind.Local).AddTicks(9417), new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ship 2", "Loading" },
                    { 5, new DateTime(2024, 8, 12, 16, 49, 22, 94, DateTimeKind.Local).AddTicks(9419), new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ship 3", "Docked" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vessels");
        }
    }
}
