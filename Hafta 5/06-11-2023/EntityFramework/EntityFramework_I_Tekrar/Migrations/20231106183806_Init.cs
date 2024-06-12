using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_I_Tekrar.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIES",
                columns: table => new
                {
                    CATEGORY_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 4 INCREMENT BY 1"),
                    CATEGORY_NAME = table.Column<string>(type: "CHAR(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIES", x => x.CATEGORY_ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTS",
                columns: table => new
                {
                    PRODUCT_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PRODUCT_NAME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    PRODUCT_PRICE = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    CATEGORY_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS", x => x.PRODUCT_ID);
                    table.ForeignKey(
                        name: "FK_PRODUCTS_CATEGORIES_CATEGORY_ID",
                        column: x => x.CATEGORY_ID,
                        principalTable: "CATEGORIES",
                        principalColumn: "CATEGORY_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CATEGORIES",
                columns: new[] { "CATEGORY_ID", "CATEGORY_NAME" },
                values: new object[] { 1, "Kırtasiye" });

            migrationBuilder.InsertData(
                table: "CATEGORIES",
                columns: new[] { "CATEGORY_ID", "CATEGORY_NAME" },
                values: new object[] { 2, "Elektronik" });

            migrationBuilder.InsertData(
                table: "CATEGORIES",
                columns: new[] { "CATEGORY_ID", "CATEGORY_NAME" },
                values: new object[] { 3, "Tekstil" });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_CATEGORY_ID",
                table: "PRODUCTS",
                column: "CATEGORY_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUCTS");

            migrationBuilder.DropTable(
                name: "CATEGORIES");
        }
    }
}
