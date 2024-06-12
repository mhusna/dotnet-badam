using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_III.Migrations
{
    public partial class InitWithValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DERSLER",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DersAdi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Kredi = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DERSLER", x => x.DersID);
                });

            migrationBuilder.CreateTable(
                name: "EGITMENLER",
                columns: table => new
                {
                    EgitmenID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Ad = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Soyad = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGITMENLER", x => x.EgitmenID);
                });

            migrationBuilder.CreateTable(
                name: "HARFNOTLARI",
                columns: table => new
                {
                    HarfNotID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Harf = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    MinDeger = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MaxDeger = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HARFNOTLARI", x => x.HarfNotID);
                });

            migrationBuilder.CreateTable(
                name: "OGRENCILER",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Ad = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Soyad = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OGRENCILER", x => x.OgrenciID);
                });

            migrationBuilder.CreateTable(
                name: "EGITMENDERS",
                columns: table => new
                {
                    EgitmenDersID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EgitmenID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DersID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGITMENDERS", x => x.EgitmenDersID);
                    table.ForeignKey(
                        name: "FK_EGITMENDERS_DERSLER_DersID",
                        column: x => x.DersID,
                        principalTable: "DERSLER",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EGITMENDERS_EGITMENLER_EgitmenID",
                        column: x => x.EgitmenID,
                        principalTable: "EGITMENLER",
                        principalColumn: "EgitmenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OGRENCIDERS",
                columns: table => new
                {
                    OgrenciDersID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Not = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    OgrenciID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DersID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    HarfNotID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OGRENCIDERS", x => x.OgrenciDersID);
                    table.ForeignKey(
                        name: "FK_OGRENCIDERS_DERSLER_DersID",
                        column: x => x.DersID,
                        principalTable: "DERSLER",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OGRENCIDERS_HARFNOTLARI_HarfNotID",
                        column: x => x.HarfNotID,
                        principalTable: "HARFNOTLARI",
                        principalColumn: "HarfNotID");
                    table.ForeignKey(
                        name: "FK_OGRENCIDERS_OGRENCILER_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "OGRENCILER",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DERSLER",
                columns: new[] { "DersID", "DersAdi", "Kredi" },
                values: new object[,]
                {
                    { 10, "Mat 101", 6 },
                    { 11, "Mat 102", 4 },
                    { 12, "Fizik 101", 3 },
                    { 13, "Polifoni", 2 },
                    { 14, "Kimya", 2 }
                });

            migrationBuilder.InsertData(
                table: "EGITMENLER",
                columns: new[] { "EgitmenID", "Ad", "Soyad" },
                values: new object[,]
                {
                    { 20, "Cevat", "Külyutmaz" },
                    { 21, "Cavit", "Sifirci" }
                });

            migrationBuilder.InsertData(
                table: "OGRENCILER",
                columns: new[] { "OgrenciID", "Ad", "Soyad" },
                values: new object[,]
                {
                    { 1, "Cevdet", "Durmaz" },
                    { 2, "Selami", "Dursun" },
                    { 3, "Dursun", "Durmasın" }
                });

            migrationBuilder.InsertData(
                table: "EGITMENDERS",
                columns: new[] { "EgitmenDersID", "DersID", "EgitmenID" },
                values: new object[,]
                {
                    { 1, 10, 20 },
                    { 2, 11, 20 },
                    { 3, 12, 20 },
                    { 4, 13, 21 },
                    { 5, 14, 21 }
                });

            migrationBuilder.InsertData(
                table: "OGRENCIDERS",
                columns: new[] { "OgrenciDersID", "DersID", "HarfNotID", "Not", "OgrenciID" },
                values: new object[,]
                {
                    { 1, 10, null, 78, 1 },
                    { 2, 13, null, 55, 1 },
                    { 3, 14, null, 66, 1 },
                    { 4, 10, null, 66, 2 },
                    { 5, 11, null, 50, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EGITMENDERS_DersID",
                table: "EGITMENDERS",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_EGITMENDERS_EgitmenID",
                table: "EGITMENDERS",
                column: "EgitmenID");

            migrationBuilder.CreateIndex(
                name: "IX_OGRENCIDERS_DersID",
                table: "OGRENCIDERS",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_OGRENCIDERS_HarfNotID",
                table: "OGRENCIDERS",
                column: "HarfNotID");

            migrationBuilder.CreateIndex(
                name: "IX_OGRENCIDERS_OgrenciID",
                table: "OGRENCIDERS",
                column: "OgrenciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EGITMENDERS");

            migrationBuilder.DropTable(
                name: "OGRENCIDERS");

            migrationBuilder.DropTable(
                name: "EGITMENLER");

            migrationBuilder.DropTable(
                name: "DERSLER");

            migrationBuilder.DropTable(
                name: "HARFNOTLARI");

            migrationBuilder.DropTable(
                name: "OGRENCILER");
        }
    }
}
