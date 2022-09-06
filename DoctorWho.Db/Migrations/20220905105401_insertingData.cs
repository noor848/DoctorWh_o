using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class insertingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnemyFunctions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnemyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnemyFunctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblEnemytblEpisods",
                columns: table => new
                {
                    TblEpisodId = table.Column<int>(type: "int", nullable: false),
                    TblEnemyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEnemytblEpisods", x => new { x.TblEpisodId, x.TblEnemyId });
                });

            migrationBuilder.CreateTable(
                name: "viewPrintDoctorsNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viewPrintDoctorsNames", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "FirstEpisodDate", "LastEpisodDate" },
                values: new object[] { new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3161), new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3200), new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstEpisodDate", "LastEpisodDate" },
                values: new object[] { new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3209), new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3212), new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstEpisodDate", "LastEpisodDate" },
                values: new object[] { new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3217), new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3220), new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "FirstEpisodDate", "LastEpisodDate" },
                values: new object[] { new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3225), new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3227), new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "FirstEpisodDate", "LastEpisodDate" },
                values: new object[] { new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3232), new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3234), new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.InsertData(
                table: "tblEpisods",
                columns: new[] { "Id", "EpisodDate", "EpisodNumber", "EpisodType", "Notes", "SeriesNumber", "Title", "tblAuthorId", "tblDoctorId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3277), 1, "q1", "Note1", 132, "Ep", null, null },
                    { 2, new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3282), 2, "q2", "Note2", 13244, "notitle", null, null },
                    { 3, new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3286), 3, "q3", "Note3", 1454, "noe", null, null },
                    { 4, new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3289), 4, "q4", "Note4", 1374, "-", null, null },
                    { 5, new DateTime(2022, 9, 5, 13, 54, 1, 291, DateTimeKind.Local).AddTicks(3292), 5, "q5", "Note5", 15899, "-", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnemyFunctions");

            migrationBuilder.DropTable(
                name: "tblEnemytblEpisods");

            migrationBuilder.DropTable(
                name: "viewPrintDoctorsNames");

            migrationBuilder.DeleteData(
                table: "tblEpisods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblEpisods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblEpisods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblEpisods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tblEpisods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "FirstEpisodDate", "LastEpisodDate" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4919), new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4951), new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstEpisodDate", "LastEpisodDate" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4956), new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4958), new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "FirstEpisodDate", "LastEpisodDate" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4963), new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4965), new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "FirstEpisodDate", "LastEpisodDate" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4969), new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4971), new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "FirstEpisodDate", "LastEpisodDate" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4975), new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4977), new DateTime(2022, 9, 4, 21, 36, 19, 924, DateTimeKind.Local).AddTicks(4979) });
        }
    }
}
