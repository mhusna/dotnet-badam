using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_I_Tekrar.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BOLUMLER",
                columns: table => new
                {
                    BolumID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    BolumAdi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLUMLER", x => x.BolumID);
                });

            migrationBuilder.CreateTable(
                name: "PROJELER",
                columns: table => new
                {
                    ProjeID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ProjeAdi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROJELER", x => x.ProjeID);
                });

            migrationBuilder.CreateTable(
                name: "PERSONELLER",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PersonelAd = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Soyad = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Maas = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    BolumID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONELLER", x => x.PersonelID);
                    table.ForeignKey(
                        name: "FK_PERSONELLER_BOLUMLER_BolumID",
                        column: x => x.BolumID,
                        principalTable: "BOLUMLER",
                        principalColumn: "BolumID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PERSONELPROJELERI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PersonelID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    BolumID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ProjeID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONELPROJELERI", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PERSONELPROJELERI_BOLUMLER_BolumID",
                        column: x => x.BolumID,
                        principalTable: "BOLUMLER",
                        principalColumn: "BolumID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PERSONELPROJELERI_PERSONELLER_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "PERSONELLER",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PERSONELPROJELERI_PROJELER_ProjeID",
                        column: x => x.ProjeID,
                        principalTable: "PROJELER",
                        principalColumn: "ProjeID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PERSONELLER_BolumID",
                table: "PERSONELLER",
                column: "BolumID");

            migrationBuilder.CreateIndex(
                name: "IX_PERSONELPROJELERI_BolumID",
                table: "PERSONELPROJELERI",
                column: "BolumID");

            migrationBuilder.CreateIndex(
                name: "IX_PERSONELPROJELERI_PersonelID",
                table: "PERSONELPROJELERI",
                column: "PersonelID");

            migrationBuilder.CreateIndex(
                name: "IX_PERSONELPROJELERI_ProjeID",
                table: "PERSONELPROJELERI",
                column: "ProjeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PERSONELPROJELERI");

            migrationBuilder.DropTable(
                name: "PERSONELLER");

            migrationBuilder.DropTable(
                name: "PROJELER");

            migrationBuilder.DropTable(
                name: "BOLUMLER");
        }
    }
}
