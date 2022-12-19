using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectC.Migrations
{
    public partial class sroi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "sroi",
                schema: "EF",
                table: "innovations",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sroi",
                schema: "EF",
                table: "innovations");
        }
    }
}
