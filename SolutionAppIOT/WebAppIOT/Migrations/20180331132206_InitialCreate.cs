using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebAppIOT.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "system",
                columns: table => new
                {
                    systemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    adressIP = table.Column<string>(nullable: true),
                    latitude = table.Column<double>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_system", x => x.systemID);
                });

            migrationBuilder.CreateTable(
                name: "technicien",
                columns: table => new
                {
                    technicienID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cin = table.Column<string>(nullable: true),
                    nom = table.Column<string>(nullable: true),
                    prenom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_technicien", x => x.technicienID);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    login = table.Column<string>(nullable: true),
                    nom = table.Column<string>(nullable: true),
                    prenom = table.Column<string>(nullable: true),
                    pwd = table.Column<string>(nullable: true),
                    systemID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.userID);
                    table.ForeignKey(
                        name: "FK_user_system_systemID",
                        column: x => x.systemID,
                        principalTable: "system",
                        principalColumn: "systemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_user_systemID",
                table: "user",
                column: "systemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "technicien");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "system");
        }
    }
}
