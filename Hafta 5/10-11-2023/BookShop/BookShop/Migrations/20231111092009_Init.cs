using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMINLER",
                columns: table => new
                {
                    ADMIN_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 2 INCREMENT BY 1"),
                    ADMIN_AD = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    ADMIN_SOYAD = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    MAIL_ADRESI = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    SIFRE = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMINLER", x => x.ADMIN_ID);
                });

            migrationBuilder.CreateTable(
                name: "YAYINEVLERI",
                columns: table => new
                {
                    YAYINEVI_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 3 INCREMENT BY 1"),
                    YAYINEVI_ADI = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YAYINEVLERI", x => x.YAYINEVI_ID);
                });

            migrationBuilder.CreateTable(
                name: "KITAPLAR",
                columns: table => new
                {
                    KITAP_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    KITAP_ADI = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: false),
                    SATIS_DURUM = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    FIYAT = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    YAYINEVI_ID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KITAPLAR", x => x.KITAP_ID);
                    table.ForeignKey(
                        name: "FK_KITAPLAR_YAYINEVLERI_YAYINEVI_ID",
                        column: x => x.YAYINEVI_ID,
                        principalTable: "YAYINEVLERI",
                        principalColumn: "YAYINEVI_ID");
                });

            migrationBuilder.InsertData(
                table: "ADMINLER",
                columns: new[] { "ADMIN_ID", "ADMIN_AD", "MAIL_ADRESI", "SIFRE", "ADMIN_SOYAD" },
                values: new object[] { 1, "Mehmet", "admin@gmail.com", "admin", "Kisla" });

            migrationBuilder.InsertData(
                table: "YAYINEVLERI",
                columns: new[] { "YAYINEVI_ID", "YAYINEVI_ADI" },
                values: new object[] { 1, "Kültür Yayınevi" });

            migrationBuilder.InsertData(
                table: "YAYINEVLERI",
                columns: new[] { "YAYINEVI_ID", "YAYINEVI_ADI" },
                values: new object[] { 2, "Zambak Yayınevi" });

            migrationBuilder.CreateIndex(
                name: "IX_KITAPLAR_YAYINEVI_ID",
                table: "KITAPLAR",
                column: "YAYINEVI_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMINLER");

            migrationBuilder.DropTable(
                name: "KITAPLAR");

            migrationBuilder.DropTable(
                name: "YAYINEVLERI");
        }
    }
}
