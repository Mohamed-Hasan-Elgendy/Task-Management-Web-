using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMC.Migrations
{
    public partial class mymi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Myprojects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enddate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Myprojects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Myteammembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Myteammembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mytasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Propirty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    projectID = table.Column<int>(type: "int", nullable: false),
                    teamMemberID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mytasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mytasks_Myprojects_projectID",
                        column: x => x.projectID,
                        principalTable: "Myprojects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mytasks_Myteammembers_teamMemberID",
                        column: x => x.teamMemberID,
                        principalTable: "Myteammembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mytasks_projectID",
                table: "Mytasks",
                column: "projectID");

            migrationBuilder.CreateIndex(
                name: "IX_Mytasks_teamMemberID",
                table: "Mytasks",
                column: "teamMemberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mytasks");

            migrationBuilder.DropTable(
                name: "Myprojects");

            migrationBuilder.DropTable(
                name: "Myteammembers");
        }
    }
}
