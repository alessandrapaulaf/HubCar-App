using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Hubcar.Data.Migrations
{
    class M20200902175400 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false, maxLength: 11),
                    Cidade = table.Column<string>(nullable: false),
                    UF = table.Column<string>(nullable: false, maxLength: 2),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", p => p.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: true),
                    Ano = table.Column<string>(nullable: false, maxLength: 4),
                    Placa = table.Column<string>(nullable: false),
                    ValorDiaria = table.Column<decimal>(nullable: false),
                    ProprietarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", p => p.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Aluguel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: true),
                    DataRetirada = table.Column<DateTime>(nullable: false),
                    DataEntrega = table.Column<DateTime>(nullable: true),
                    LocalRetirada = table.Column<string>(nullable: false),
                    AvaliacaoId = table.Column<int>(nullable: true),
                    CarroId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluguel", p => p.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Carteira",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: true),
                    Saldo = table.Column<decimal>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carteira", p => p.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "UsuarioLogado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioLogado", p => p.Id);
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            base.Down(migrationBuilder);
        }
    }
}
