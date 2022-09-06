using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class CreateModelesEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAuthors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuthors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblCompanions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComapnionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhoPlayed = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompanions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblDoctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorNumber = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstEpisodDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEpisodDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDoctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblEnemys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnemyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEnemys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblEpisods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesNumber = table.Column<int>(type: "int", nullable: false),
                    EpisodNumber = table.Column<int>(type: "int", nullable: false),
                    EpisodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EpisodDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tblAuthorId = table.Column<int>(type: "int", nullable: true),
                    tblDoctorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEpisods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEpisods_tblAuthors_tblAuthorId",
                        column: x => x.tblAuthorId,
                        principalTable: "tblAuthors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tblEpisods_tblDoctors_tblDoctorId",
                        column: x => x.tblDoctorId,
                        principalTable: "tblDoctors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tblCompaniontblEpisod",
                columns: table => new
                {
                    TblCompanionId = table.Column<int>(type: "int", nullable: false),
                    TblEpisodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompaniontblEpisod", x => new { x.TblCompanionId, x.TblEpisodId });
                    table.ForeignKey(
                        name: "FK_tblCompaniontblEpisod_tblCompanions_TblCompanionId",
                        column: x => x.TblCompanionId,
                        principalTable: "tblCompanions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblCompaniontblEpisod_tblEpisods_TblEpisodId",
                        column: x => x.TblEpisodId,
                        principalTable: "tblEpisods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEnemytblEpisod",
                columns: table => new
                {
                    TblEnemyId = table.Column<int>(type: "int", nullable: false),
                    TblEpisodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEnemytblEpisod", x => new { x.TblEnemyId, x.TblEpisodId });
                    table.ForeignKey(
                        name: "FK_tblEnemytblEpisod_tblEnemys_TblEnemyId",
                        column: x => x.TblEnemyId,
                        principalTable: "tblEnemys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEnemytblEpisod_tblEpisods_TblEpisodId",
                        column: x => x.TblEpisodId,
                        principalTable: "tblEpisods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

   

            migrationBuilder.CreateIndex(
                name: "IX_tblCompaniontblEpisod_TblEpisodId",
                table: "tblCompaniontblEpisod",
                column: "TblEpisodId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEnemytblEpisod_TblEpisodId",
                table: "tblEnemytblEpisod",
                column: "TblEpisodId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEpisods_tblAuthorId",
                table: "tblEpisods",
                column: "tblAuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEpisods_tblDoctorId",
                table: "tblEpisods",
                column: "tblDoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCompaniontblEpisod");

            migrationBuilder.DropTable(
                name: "tblEnemytblEpisod");

            migrationBuilder.DropTable(
                name: "tblCompanions");

            migrationBuilder.DropTable(
                name: "tblEnemys");

            migrationBuilder.DropTable(
                name: "tblEpisods");

            migrationBuilder.DropTable(
                name: "tblAuthors");

            migrationBuilder.DropTable(
                name: "tblDoctors");
        }
    }
}
