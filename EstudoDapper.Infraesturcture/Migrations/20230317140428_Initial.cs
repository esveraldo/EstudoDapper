using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudoDapper.Infraesturcture.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    Renda = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conjuge",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", nullable: false),
                    CodCliente = table.Column<string>(type: "varchar(30)", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conjuge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conjuge_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Imovels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(20)", nullable: false),
                    Area = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imovels_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFisicas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(20)", nullable: false),
                    Sexo = table.Column<string>(type: "char(1)", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFisicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaFisicas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoaJuridicas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ramo = table.Column<string>(type: "char(1)", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaJuridicas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conjuge_ClienteId",
                table: "Conjuge",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Imovels_ClienteId",
                table: "Imovels",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaFisicas_ClienteId",
                table: "PessoaFisicas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaJuridicas_ClienteId",
                table: "PessoaJuridicas",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conjuge");

            migrationBuilder.DropTable(
                name: "Imovels");

            migrationBuilder.DropTable(
                name: "PessoaFisicas");

            migrationBuilder.DropTable(
                name: "PessoaJuridicas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
