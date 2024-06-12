using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MehmetHusnaKisla.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMINS",
                columns: table => new
                {
                    ADMIN_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 2 INCREMENT BY 1"),
                    USER_NAME = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    PASSWORD = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false),
                    PASSWORD_CONFIRM = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMINS", x => x.ADMIN_ID);
                });

            migrationBuilder.CreateTable(
                name: "ARTISTS",
                columns: table => new
                {
                    ARTIST_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ARTIST_NAME = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    IS_DELETED = table.Column<int>(type: "NUMBER(10)", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTISTS", x => x.ARTIST_ID);
                });

            migrationBuilder.CreateTable(
                name: "ALBUMS",
                columns: table => new
                {
                    ALBUM_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ALBUM_NAME = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    PUBLISH_TIME = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    PRICE = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    DISCOUNT = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    IS_ON_SALE = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    INSERT_TIME = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ARTIST_ID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALBUMS", x => x.ALBUM_ID);
                    table.ForeignKey(
                        name: "FK_ALBUMS_ARTISTS_ARTIST_ID",
                        column: x => x.ARTIST_ID,
                        principalTable: "ARTISTS",
                        principalColumn: "ARTIST_ID");
                });

            migrationBuilder.InsertData(
                table: "ADMINS",
                columns: new[] { "ADMIN_ID", "PASSWORD", "PASSWORD_CONFIRM", "USER_NAME" },
                values: new object[] { 1, "123", "123", "mhusna" });

            migrationBuilder.CreateIndex(
                name: "IX_ADMINS_USER_NAME",
                table: "ADMINS",
                column: "USER_NAME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ALBUMS_ARTIST_ID",
                table: "ALBUMS",
                column: "ARTIST_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMINS");

            migrationBuilder.DropTable(
                name: "ALBUMS");

            migrationBuilder.DropTable(
                name: "ARTISTS");
        }
    }
}
