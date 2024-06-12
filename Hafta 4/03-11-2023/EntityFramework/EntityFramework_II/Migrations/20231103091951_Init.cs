using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_II.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DERSLER",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DersAdi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
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
                name: "DERSEGITMENLER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EgitmenID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DersID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DERSEGITMENLER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DERSEGITMENLER_DERSLER_DersID",
                        column: x => x.DersID,
                        principalTable: "DERSLER",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DERSEGITMENLER_EGITMENLER_EgitmenID",
                        column: x => x.EgitmenID,
                        principalTable: "EGITMENLER",
                        principalColumn: "EgitmenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DERSOGRENCILER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DersNotu = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    HarfNotu = table.Column<string>(type: "NVARCHAR2(1)", nullable: false),
                    DersID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    OgrenciID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DERSOGRENCILER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DERSOGRENCILER_DERSLER_DersID",
                        column: x => x.DersID,
                        principalTable: "DERSLER",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DERSOGRENCILER_OGRENCILER_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "OGRENCILER",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DERSEGITMENLER_DersID",
                table: "DERSEGITMENLER",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_DERSEGITMENLER_EgitmenID",
                table: "DERSEGITMENLER",
                column: "EgitmenID");

            migrationBuilder.CreateIndex(
                name: "IX_DERSOGRENCILER_DersID",
                table: "DERSOGRENCILER",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_DERSOGRENCILER_OgrenciID",
                table: "DERSOGRENCILER",
                column: "OgrenciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DERSEGITMENLER");

            migrationBuilder.DropTable(
                name: "DERSOGRENCILER");

            migrationBuilder.DropTable(
                name: "EGITMENLER");

            migrationBuilder.DropTable(
                name: "DERSLER");

            migrationBuilder.DropTable(
                name: "OGRENCILER");
        }
    }
}
