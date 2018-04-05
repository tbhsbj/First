using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebAppIOT.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CapteurSenario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Link_num = table.Column<int>(nullable: false),
                    Link_type = table.Column<int>(nullable: false),
                    Seuil = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapteurSenario", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SuperUser",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lastlogin = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    login = table.Column<string>(nullable: true),
                    pwd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperUser", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Technicien",
                columns: table => new
                {
                    TechnicienId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cin = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicien", x => x.TechnicienId);
                });

            migrationBuilder.CreateTable(
                name: "Senario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<int>(nullable: false),
                    CapteurSenarioID = table.Column<int>(nullable: false),
                    temps = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Senario", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Senario_CapteurSenario_CapteurSenarioID",
                        column: x => x.CapteurSenarioID,
                        principalTable: "CapteurSenario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "System",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ip = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SuperUserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System", x => x.ID);
                    table.ForeignKey(
                        name: "FK_System_SuperUser_SuperUserID",
                        column: x => x.SuperUserID,
                        principalTable: "SuperUser",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Technicien_System",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReglageDate = table.Column<DateTime>(nullable: false),
                    ReglageType = table.Column<string>(nullable: true),
                    SystemID = table.Column<int>(nullable: false),
                    TechnicienID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicien_System", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Technicien_System_System_SystemID",
                        column: x => x.SystemID,
                        principalTable: "System",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Technicien_System_Technicien_TechnicienID",
                        column: x => x.TechnicienID,
                        principalTable: "Technicien",
                        principalColumn: "TechnicienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lastlogin = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SystemID = table.Column<int>(nullable: false),
                    login = table.Column<string>(nullable: true),
                    pwd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_System_SystemID",
                        column: x => x.SystemID,
                        principalTable: "System",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chambre",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lastlogin = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chambre", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chambre_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipement",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChambreID = table.Column<int>(nullable: false),
                    Gpio = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipement", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Equipement_Chambre_ChambreID",
                        column: x => x.ChambreID,
                        principalTable: "Chambre",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Senario_Equipement",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EquipementID = table.Column<int>(nullable: false),
                    SenarioID = table.Column<int>(nullable: false),
                    value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Senario_Equipement", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Senario_Equipement_Equipement_EquipementID",
                        column: x => x.EquipementID,
                        principalTable: "Equipement",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Senario_Equipement_Senario_SenarioID",
                        column: x => x.SenarioID,
                        principalTable: "Senario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chambre_UserID",
                table: "Chambre",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipement_ChambreID",
                table: "Equipement",
                column: "ChambreID");

            migrationBuilder.CreateIndex(
                name: "IX_Senario_CapteurSenarioID",
                table: "Senario",
                column: "CapteurSenarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Senario_Equipement_EquipementID",
                table: "Senario_Equipement",
                column: "EquipementID");

            migrationBuilder.CreateIndex(
                name: "IX_Senario_Equipement_SenarioID",
                table: "Senario_Equipement",
                column: "SenarioID");

            migrationBuilder.CreateIndex(
                name: "IX_System_SuperUserID",
                table: "System",
                column: "SuperUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Technicien_System_SystemID",
                table: "Technicien_System",
                column: "SystemID");

            migrationBuilder.CreateIndex(
                name: "IX_Technicien_System_TechnicienID",
                table: "Technicien_System",
                column: "TechnicienID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SystemID",
                table: "Users",
                column: "SystemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Senario_Equipement");

            migrationBuilder.DropTable(
                name: "Technicien_System");

            migrationBuilder.DropTable(
                name: "Equipement");

            migrationBuilder.DropTable(
                name: "Senario");

            migrationBuilder.DropTable(
                name: "Technicien");

            migrationBuilder.DropTable(
                name: "Chambre");

            migrationBuilder.DropTable(
                name: "CapteurSenario");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "System");

            migrationBuilder.DropTable(
                name: "SuperUser");
        }
    }
}
