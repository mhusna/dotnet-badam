using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_I.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BOLUMLER",
                columns: table => new
                {
                    BOLUM_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    BOLUMADI = table.Column<string>(type: "CHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLUMLER", x => x.BOLUM_ID);
                });

            migrationBuilder.CreateTable(
                name: "PROJELER",
                columns: table => new
                {
                    ProjeID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PROJEADI = table.Column<string>(type: "CHAR(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROJELER", x => x.ProjeID);
                });

            migrationBuilder.CreateTable(
                name: "PERSONELLER",
                columns: table => new
                {
                    PERSONEL_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Ad = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Soyad = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    BolumID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ProjeID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONELLER", x => x.PERSONEL_ID);
                    table.ForeignKey(
                        name: "FK_PERSONELLER_BOLUMLER_BolumID",
                        column: x => x.BolumID,
                        principalTable: "BOLUMLER",
                        principalColumn: "BOLUM_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PERSONELLER_PROJELER_ProjeID",
                        column: x => x.ProjeID,
                        principalTable: "PROJELER",
                        principalColumn: "ProjeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PERSONELLER_BolumID",
                table: "PERSONELLER",
                column: "BolumID");

            migrationBuilder.CreateIndex(
                name: "IX_PERSONELLER_ProjeID",
                table: "PERSONELLER",
                column: "ProjeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PERSONELLER");

            migrationBuilder.DropTable(
                name: "BOLUMLER");

            migrationBuilder.DropTable(
                name: "PROJELER");
        }
    }
}
