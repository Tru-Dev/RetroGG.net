using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RetroGG.net.Data.Migrations
{
    public partial class ProductsAndImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoredImages",
                columns: table => new
                {
                    ImageID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: true),
                    ImageData = table.Column<byte[]>(maxLength: 1048576, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoredImages", x => x.ImageID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: true),
                    Description = table.Column<string>(maxLength: 512, nullable: true),
                    ImageID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_StoredImages_ImageID",
                        column: x => x.ImageID,
                        principalTable: "StoredImages",
                        principalColumn: "ImageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageID",
                table: "Products",
                column: "ImageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "StoredImages");
        }
    }
}
