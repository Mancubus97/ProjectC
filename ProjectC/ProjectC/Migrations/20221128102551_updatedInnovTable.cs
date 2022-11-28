using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectC.Migrations
{
    public partial class updatedInnovTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "amount",
                schema: "EF",
                table: "innovations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "description",
                schema: "EF",
                table: "innovations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "hoursSavings",
                schema: "EF",
                table: "innovations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "implementCosts",
                schema: "EF",
                table: "innovations",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "implementHours",
                schema: "EF",
                table: "innovations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "personelSavings",
                schema: "EF",
                table: "innovations",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "price",
                schema: "EF",
                table: "innovations",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amount",
                schema: "EF",
                table: "innovations");

            migrationBuilder.DropColumn(
                name: "description",
                schema: "EF",
                table: "innovations");

            migrationBuilder.DropColumn(
                name: "hoursSavings",
                schema: "EF",
                table: "innovations");

            migrationBuilder.DropColumn(
                name: "implementCosts",
                schema: "EF",
                table: "innovations");

            migrationBuilder.DropColumn(
                name: "implementHours",
                schema: "EF",
                table: "innovations");

            migrationBuilder.DropColumn(
                name: "personelSavings",
                schema: "EF",
                table: "innovations");

            migrationBuilder.DropColumn(
                name: "price",
                schema: "EF",
                table: "innovations");
        }
    }
}
