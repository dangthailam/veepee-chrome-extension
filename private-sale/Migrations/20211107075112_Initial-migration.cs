using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace private_sale.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sale_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductLine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductLine_ProductInformation_ProductInformationId",
                        column: x => x.ProductInformationId,
                        principalTable: "ProductInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductLine_Sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSelection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OnStock = table.Column<bool>(type: "bit", nullable: false),
                    ProductLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSelection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSelection_ProductLine_ProductLineId",
                        column: x => x.ProductLineId,
                        principalTable: "ProductLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductLine_ProductInformationId",
                table: "ProductLine",
                column: "ProductInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLine_SaleId",
                table: "ProductLine",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSelection_ProductLineId",
                table: "ProductSelection",
                column: "ProductLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_BrandId",
                table: "Sale",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSelection");

            migrationBuilder.DropTable(
                name: "ProductLine");

            migrationBuilder.DropTable(
                name: "ProductInformation");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
