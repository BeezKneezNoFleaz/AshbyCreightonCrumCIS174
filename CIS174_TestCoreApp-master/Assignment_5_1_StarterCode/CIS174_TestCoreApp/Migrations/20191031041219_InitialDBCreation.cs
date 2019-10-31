using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CIS174_TestCoreApp.Migrations
{
    public partial class InitialDBCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accoplishments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FName = table.Column<string>(maxLength: 25, nullable: false),
                    LName = table.Column<string>(maxLength: 25, nullable: false),
                    DateOfAccomplishment = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accoplishments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FamousPeoples",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FName = table.Column<string>(maxLength: 25, nullable: false),
                    LName = table.Column<string>(maxLength: 25, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(maxLength: 25, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    ListOfAccoplishments = table.Column<string>(maxLength: 200, nullable: false),
                    AccoplishmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamousPeoples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamousPeoples_Accoplishments_AccoplishmentId",
                        column: x => x.AccoplishmentId,
                        principalTable: "Accoplishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FamousPeoples_AccoplishmentId",
                table: "FamousPeoples",
                column: "AccoplishmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FamousPeoples");

            migrationBuilder.DropTable(
                name: "Accoplishments");
        }
    }
}
