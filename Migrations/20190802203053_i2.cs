using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportApp.Migrations
{
    public partial class i2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Razred",
                columns: table => new
                {
                    RazredId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojRazred = table.Column<int>(nullable: true),
                    Opis = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Razred", x => x.RazredId);
                });

            migrationBuilder.CreateTable(
                name: "Spol",
                columns: table => new
                {
                    SpolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivSpola = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spol", x => x.SpolId);
                });

            migrationBuilder.CreateTable(
                name: "Sportovi",
                columns: table => new
                {
                    SportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SportIme = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sportovi", x => x.SportId);
                });

            migrationBuilder.CreateTable(
                name: "VrstaTesta",
                columns: table => new
                {
                    VrstaTestaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivTesta = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaTesta", x => x.VrstaTestaId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpolId = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    SifraStudent = table.Column<int>(nullable: true),
                    StudentDatum = table.Column<DateTime>(type: "date", nullable: true),
                    StudentMjesto = table.Column<string>(nullable: true),
                    GodinaMajka = table.Column<DateTime>(type: "date", nullable: true),
                    GodinaOtac = table.Column<DateTime>(type: "date", nullable: true),
                    SportMajka = table.Column<string>(nullable: true),
                    SportOtac = table.Column<string>(nullable: true),
                    KojiSportMajka = table.Column<string>(nullable: true),
                    KojiSportOtac = table.Column<string>(nullable: true),
                    SportStudent = table.Column<bool>(nullable: true),
                    KojiSportStudent = table.Column<string>(nullable: true),
                    Trajanje = table.Column<int>(nullable: true),
                    Istovremeno = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Spol_SpolId",
                        column: x => x.SpolId,
                        principalTable: "Spol",
                        principalColumn: "SpolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Norma",
                columns: table => new
                {
                    NormaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VrstaTestaId = table.Column<int>(nullable: false),
                    SpolId = table.Column<int>(nullable: false),
                    RazredId = table.Column<int>(nullable: false),
                    Ocjena1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ocjena2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ocjena3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ocjena4 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ocjena5 = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Norma", x => x.NormaId);
                    table.ForeignKey(
                        name: "FK_Norme_Razred_RazredId",
                        column: x => x.RazredId,
                        principalTable: "Razred",
                        principalColumn: "RazredId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Norme_Spol_SpolId",
                        column: x => x.SpolId,
                        principalTable: "Spol",
                        principalColumn: "SpolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Norme_VrstaTesta_VrstaTestaId",
                        column: x => x.VrstaTestaId,
                        principalTable: "VrstaTesta",
                        principalColumn: "VrstaTestaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Testiranje",
                columns: table => new
                {
                    TestiranjeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    RazredId = table.Column<int>(nullable: false),
                    DatumTest = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testiranje", x => x.TestiranjeId);
                    table.ForeignKey(
                        name: "FK_Testiranje_Razred_RazredId",
                        column: x => x.RazredId,
                        principalTable: "Razred",
                        principalColumn: "RazredId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Testiranje_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OcjeneSporta",
                columns: table => new
                {
                    OcjenaSportaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TestiranjeId = table.Column<int>(nullable: false),
                    SportId = table.Column<int>(nullable: false),
                    Ocjena = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcjeneSporta", x => x.OcjenaSportaId);
                    table.ForeignKey(
                        name: "FK_OcjeneSporta_Sportovi_SportId",
                        column: x => x.SportId,
                        principalTable: "Sportovi",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OcjeneSporta_Testiranje_TestiranjeId",
                        column: x => x.TestiranjeId,
                        principalTable: "Testiranje",
                        principalColumn: "TestiranjeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    TestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VrstaTestaId = table.Column<int>(nullable: false),
                    NormaId = table.Column<int>(nullable: false),
                    TestiranjeId = table.Column<int>(nullable: false),
                    TestRezultat = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Ocjena = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.TestId);
                    table.ForeignKey(
                        name: "FK_Test_Norma",
                        column: x => x.NormaId,
                        principalTable: "Norma",
                        principalColumn: "NormaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Test_Testiranje_TestiranjeId",
                        column: x => x.TestiranjeId,
                        principalTable: "Testiranje",
                        principalColumn: "TestiranjeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Test_VrstaTesta_VrstaTestaId",
                        column: x => x.VrstaTestaId,
                        principalTable: "VrstaTesta",
                        principalColumn: "VrstaTestaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Norma_RazredId",
                table: "Norma",
                column: "RazredId");

            migrationBuilder.CreateIndex(
                name: "IX_Norma_SpolId",
                table: "Norma",
                column: "SpolId");

            migrationBuilder.CreateIndex(
                name: "IX_Norma_VrstaTestaId",
                table: "Norma",
                column: "VrstaTestaId");

            migrationBuilder.CreateIndex(
                name: "IX_OcjeneSporta_SportId",
                table: "OcjeneSporta",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_OcjeneSporta_TestiranjeId",
                table: "OcjeneSporta",
                column: "TestiranjeId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_SpolId",
                table: "Student",
                column: "SpolId");

            migrationBuilder.CreateIndex(
                name: "IX_Test_NormaId",
                table: "Test",
                column: "NormaId");

            migrationBuilder.CreateIndex(
                name: "IX_Test_TestiranjeId",
                table: "Test",
                column: "TestiranjeId");

            migrationBuilder.CreateIndex(
                name: "IX_Test_VrstaTestaId",
                table: "Test",
                column: "VrstaTestaId");

            migrationBuilder.CreateIndex(
                name: "IX_Testiranje_RazredId",
                table: "Testiranje",
                column: "RazredId");

            migrationBuilder.CreateIndex(
                name: "IX_Testiranje_StudentId",
                table: "Testiranje",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OcjeneSporta");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "Sportovi");

            migrationBuilder.DropTable(
                name: "Norma");

            migrationBuilder.DropTable(
                name: "Testiranje");

            migrationBuilder.DropTable(
                name: "VrstaTesta");

            migrationBuilder.DropTable(
                name: "Razred");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Spol");
        }
    }
}
