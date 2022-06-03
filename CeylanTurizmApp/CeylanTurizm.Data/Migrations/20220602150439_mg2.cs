using Microsoft.EntityFrameworkCore.Migrations;

namespace CeylanTurizm.Data.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Expeditions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinish",
                table: "Expeditions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExpedition",
                table: "Buses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Expeditions");

            migrationBuilder.DropColumn(
                name: "IsFinish",
                table: "Expeditions");

            migrationBuilder.DropColumn(
                name: "IsExpedition",
                table: "Buses");
        }
    }
}
