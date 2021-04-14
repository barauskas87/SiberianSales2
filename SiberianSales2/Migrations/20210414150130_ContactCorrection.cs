using Microsoft.EntityFrameworkCore.Migrations;

namespace SiberianSales2.Migrations
{
    public partial class ContactCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Whatsapp",
                table: "Contact",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Whatsapp",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
