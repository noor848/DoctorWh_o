using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Migrations
{
    public partial class Procedure_GetNameOfEnemies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE GetEnemiesName
            AS
            select tblEnemys.EnemyName,tblEnemys.Id,tblEnemys.Description from tblEnemys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP  PROCEDURE GetEnemiesName");
        }
    }
}
