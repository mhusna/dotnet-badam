using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_I_Tekrar.Migrations
{
    public partial class PersonelDetayOneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PERSONELDETAYLAR",
                columns: table => new
                {
                    PersonelDetayID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SicilNotu = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Aciklama = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONELDETAYLAR", x => x.PersonelDetayID);
                    table.ForeignKey(
                        name: "FK_PERSONELDETAYLAR_PERSONELLER_PersonelDetayID",
                        column: x => x.PersonelDetayID,
                        principalTable: "PERSONELLER",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PERSONELDETAYLAR");
        }
    }
}
