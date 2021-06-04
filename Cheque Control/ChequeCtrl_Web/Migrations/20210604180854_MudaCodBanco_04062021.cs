using Microsoft.EntityFrameworkCore.Migrations;

namespace ChequeCtrl_Web.Migrations
{
    public partial class MudaCodBanco_04062021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                schema: "chq",
                table: "BANCOS",
                type: "varchar",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                schema: "chq",
                table: "BANCOS",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 3,
                oldNullable: true);
        }
    }
}
