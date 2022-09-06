using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Migrations
{
    public partial class Function_GetNameOfEnemey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE FUNCTION  GetEnemyname
            (@id int)
              RETURNS TABLE AS
               RETURN
           select * from tblEnemys where tblEnemys.Id = @id;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION IF EXISTS GetEnemyname");
        }
    }
}
