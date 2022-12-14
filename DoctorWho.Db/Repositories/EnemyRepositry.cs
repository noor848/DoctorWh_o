using EFCore;
using EfDoctorWho;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepositry
    {
        private readonly DoctorWhoContext _context;
        public EnemyRepositry(DoctorWhoContext context)
        {
            _context = context;
        }
        public void CreateEnemy(string description, string EnemyName)
        {
            _context.Enemys.Add(new EfDoctorWho.Enemy
            {
                Description = description,
                EnemyName = EnemyName,
            });
            _context.SaveChanges();
        }
 
        public void DeleteEnemy(int id)
        {
            var Enemy = GetEnemyById(id);
            if (Enemy != null)
            {
                _context.Remove(Enemy);
                _context.SaveChanges();
            }
        }

        public void updateEnemyData(Enemy enemy)
        {
            var Enemy = GetEnemyById(enemy.Id);

            Enemy.Description = enemy.Description;
            Enemy.EnemyName=enemy.EnemyName;

            _context.SaveChanges();
        }

        public Enemy GetEnemyById(int id)
        {
            return _context.Enemys.Find(id);
        }
        public void GetEnemyProcedure()
        {
            var EnemyNameList = _context.Enemys.FromSqlRaw("EXECUTE GetEnemiesName").ToList();
            foreach (var enemy in EnemyNameList)
            {
                Console.Write($"Enemy's Name {enemy.Id}: {enemy.EnemyName}, ");
            }
            Console.WriteLine("");
        }
    }
}
