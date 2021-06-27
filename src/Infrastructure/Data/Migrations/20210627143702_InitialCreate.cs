using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Monbsoft.IHalles.Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Halles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address_City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address_Region = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address_Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location_Latitude = table.Column<double>(type: "float", nullable: false),
                    Location_Longitude = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Halles");
        }
    }
}
