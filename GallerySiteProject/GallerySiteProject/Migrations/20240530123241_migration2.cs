using Microsoft.EntityFrameworkCore.Migrations;

namespace GallerySiteProject.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HakkimdaImageURL",
                table: "tblHakkimdas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HakkimdaImageURL",
                table: "tblHakkimdas");
        }
    }
}
