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
                    { new Guid("72e7443d-a9ef-4c24-9685-950fbab975e7"), true, "Aspirador de Pó", 100.00m },
                    { new Guid("a04c11eb-6aa3-4d66-bf57-8e0888112be3"), true, "Casaco", 30.00m },
                    { new Guid("320efb40-e77f-4bb3-b4dc-8af179dc343a"), true, "Abajur", 20.00m },
                    { new Guid("f32f6047-02ee-44f7-94f9-c32e2191ff62"), true, "Comoda", 350.00m },
                    { new Guid("eabfffc1-5bca-437a-b7e8-cd8ded132358"), true, "Espelho", 80.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
