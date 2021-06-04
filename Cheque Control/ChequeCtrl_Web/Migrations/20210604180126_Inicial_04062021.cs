using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ChequeCtrl_Web.Migrations
{
    public partial class Inicial_04062021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "chq");

            migrationBuilder.CreateTable(
                name: "BANCOS",
                schema: "chq",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Codigo = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "varchar", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PESSOAS",
                schema: "chq",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(type: "varchar", maxLength: 100, nullable: true),
                    CPF = table.Column<string>(type: "varchar", maxLength: 11, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar", maxLength: 14, nullable: true),
                    Telefone = table.Column<string>(type: "varchar", maxLength: 25, nullable: true),
                    Endereco = table.Column<string>(type: "varchar", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CHEQUES",
                schema: "chq",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Banco = table.Column<int>(type: "integer", nullable: true),
                    Dono = table.Column<int>(type: "integer", nullable: true),
                    Numero = table.Column<int>(type: "integer", nullable: true),
                    Folha = table.Column<int>(type: "integer", nullable: true),
                    Valor = table.Column<decimal>(type: "money", nullable: true),
                    Emissao = table.Column<DateTime>(type: "date", nullable: true),
                    Vencimento = table.Column<DateTime>(type: "date", nullable: true),
                    Tipo = table.Column<string>(type: "char(1)", nullable: true),
                    Situacao = table.Column<string>(type: "char(1)", nullable: true),
                    Passou_Pra_Quem = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CHEQUES_BANCOS_Banco",
                        column: x => x.Banco,
                        principalSchema: "chq",
                        principalTable: "BANCOS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CHEQUES_PESSOAS_Dono",
                        column: x => x.Dono,
                        principalSchema: "chq",
                        principalTable: "PESSOAS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CHEQUES_PESSOAS_Passou_Pra_Quem",
                        column: x => x.Passou_Pra_Quem,
                        principalSchema: "chq",
                        principalTable: "PESSOAS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHEQUES_Banco",
                schema: "chq",
                table: "CHEQUES",
                column: "Banco");

            migrationBuilder.CreateIndex(
                name: "IX_CHEQUES_Dono",
                schema: "chq",
                table: "CHEQUES",
                column: "Dono");

            migrationBuilder.CreateIndex(
                name: "IX_CHEQUES_Passou_Pra_Quem",
                schema: "chq",
                table: "CHEQUES",
                column: "Passou_Pra_Quem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHEQUES",
                schema: "chq");

            migrationBuilder.DropTable(
                name: "BANCOS",
                schema: "chq");

            migrationBuilder.DropTable(
                name: "PESSOAS",
                schema: "chq");
        }
    }
}
