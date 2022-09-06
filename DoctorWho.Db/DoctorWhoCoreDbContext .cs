using DoctorWho.Db;
using EfDoctorWho;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-IUL55L7\SQLEXPRESS;Initial Catalog=DoctorWhoCore;Integrated Security=True");
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblEnemytblEpisod>().HasKey(s => new { s.TblEpisodId,s.TblEnemyId });
        }

        public DbSet<tblEnemy> tblEnemys { get; set; }
        public DbSet<tblAuthor> tblAuthors { get; set; }
        public DbSet<tblCompanion> tblCompanions { get; set; }
        public DbSet<tblDoctor> tblDoctors { get; set; }
        public DbSet<tblEpisod> tblEpisods { get; set; }
        public DbSet<viewPrintDoctorsName> viewPrintDoctorsNames { get; set; }
        public DbSet<tblEnemytblEpisod> tblEnemytblEpisods { get; set; }
        public DbSet<EnemyFunction> EnemyFunctions { get; set; }

    }
}
