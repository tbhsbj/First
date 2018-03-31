using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebAppIOT.Migrations
{
    public partial class seconde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Technicien_System",
                columns: table => new
                {
                    technicien_SystemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    systemID = table.Column<int>(nullable: true),
                    technicienID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicien_System", x => x.technicien_SystemID);
                    table.ForeignKey(
                        name: "FK_Technicien_System_system_systemID",
                        column: x => x.systemID,
                        principalTable: "system",
                        principalColumn: "systemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Technicien_System_technicien_technicienID",
                        column: x => x.technicienID,
                        principalTable: "technicien",
                        principalColumn: "technicienID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Technicien_System_systemID",
                table: "Technicien_System",
                column: "systemID");

            migrationBuilder.CreateIndex(
                name: "IX_Technicien_System_technicienID",
                table: "Technicien_System",
                column: "technicienID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Technicien_System");
        }
    }
}
