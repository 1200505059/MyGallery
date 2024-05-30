using Microsoft.EntityFrameworkCore.Migrations;

namespace GallerySiteProject.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblGirises",
                columns: table => new
                {
                    GirisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GirisAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GirisAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GirisFacebookURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GirisLinkedinURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GirisMailURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GirisInstagramURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGirises", x => x.GirisID);
                });

            migrationBuilder.CreateTable(
                name: "tblHakkimdas",
                columns: table => new
                {
                    HakkimdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkimdaBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaGiris = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblHakkimdas", x => x.HakkimdaID);
                });

            migrationBuilder.CreateTable(
                name: "tblResimlers",
                columns: table => new
                {
                    ResimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResimlerTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResimURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblResimlers", x => x.ResimID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblGirises");

            migrationBuilder.DropTable(
                name: "tblHakkimdas");

            migrationBuilder.DropTable(
                name: "tblResimlers");
        }
    }
}
