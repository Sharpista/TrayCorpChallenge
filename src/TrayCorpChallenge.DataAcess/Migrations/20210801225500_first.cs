using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrayCorpChallenge.DataAcess.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Inventory = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Inventory", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("89e27947-d1c4-4aab-bf03-b0adf8bfcb19"), true, "Aspirador de Pó", 100.00m },
                    { new Guid("847716f1-c6c8-4d02-9b05-01b686a0b248"), true, "Casaco", 30.00m },
                    { new Guid("1fde9e37-dc03-4966-a1cd-edceccfbe597"), true, "Abajur", 20.00m },
                    { new Guid("6430b90c-8f05-49b7-8ee1-0cd10d6404e7"), true, "Comoda", 350.00m },
                    { new Guid("54db09d6-2daa-4d53-b3f9-8c524cb08f46"), true, "Espelho", 80.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
