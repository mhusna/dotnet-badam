using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_II.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "URUNDBHOCA");

            migrationBuilder.CreateTable(
                name: "KATEGORILER",
                schema: "URUNDBHOCA",
                columns: table => new
                {
                    KATEGORI_ID = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    KATEGORI_ADI = table.Column<string>(type: "CHAR(30)", unicode: false, fixedLength: true, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KATEGORILER", x => x.KATEGORI_ID);
                });

            migrationBuilder.CreateTable(
                name: "URUNLER",
                schema: "URUNDBHOCA",
                columns: table => new
                {
                    URUN_ID = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    URUN_ADI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    FIYAT = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    KATEGORI_ID = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URUNLER", x => x.URUN_ID);
                    table.ForeignKey(
                        name: "FK_URUNLER_KATEGORILER_KATEGORI_ID",
                        column: x => x.KATEGORI_ID,
                        principalSchema: "URUNDBHOCA",
                        principalTable: "KATEGORILER",
                        principalColumn: "KATEGORI_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "URUNDBHOCA",
                table: "KATEGORILER",
                columns: new[] { "KATEGORI_ID", "KATEGORI_ADI" },
                values: new object[,]
                {
                    { 11, "Oyuncak" },
                    { 12, "Kitap" },
                    { 13, "Hobi" },
                    { 14, "Bahçe" }
                });

            migrationBuilder.InsertData(
                schema: "URUNDBHOCA",
                table: "URUNLER",
                columns: new[] { "URUN_ID", "FIYAT", "KATEGORI_ID", "URUN_ADI" },
                values: new object[,]
                {
                    { 100, 780.0, 11, "Tren" },
                    { 101, 880.0, 11, "Uçak" },
                    { 102, 78.0, 12, "Empati" },
                    { 103, 55.0, 12, "Simyacı" },
                    { 104, 78.0, 12, "Da Vinci Sifresi" },
                    { 105, 550.0, 13, "Satranc Seti" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_URUNLER_KATEGORI_ID",
                schema: "URUNDBHOCA",
                table: "URUNLER",
                column: "KATEGORI_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "URUNLER",
                schema: "URUNDBHOCA");

            migrationBuilder.DropTable(
                name: "KATEGORILER",
                schema: "URUNDBHOCA");
        }
    }
}
