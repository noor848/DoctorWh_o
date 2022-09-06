using EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class tblEnemyRepositry
    {
        public static void CreateEnemy(ApplicationContext context, string description, string EnemyName)
        {
            context.tblEnemys.Add(new EfDoctorWho.tblEnemy
            {
                Description = description,
                EnemyName = EnemyName,
            });
            context.SaveChanges();
        }
        public static void GetEnemyNameFunction(ApplicationContext context, int id)
        {
            var response = context.EnemyFunctions.FromSqlRaw($"select* from  GetEnemyname({id})").ToList().FirstOrDefault();
            Console.WriteLine($"Enemy Name has Id ={id} is {response.EnemyName}");
        }
        public static void GetEnemiesNameProcedure(ApplicationContext context)
        {
            var EnemyNameList = context.tblEnemys.FromSqlRaw("EXECUTE GetEnemiesName").ToList();
            foreach (var enemy in EnemyNameList)
            {
                Console.Write($"Enemy's Name {enemy.Id}: {enemy.EnemyName}, ");
            }
            Console.WriteLine("");
        }
        public static void updateEnemyName(ApplicationContext context, int id)
        {
            var Enemy = context.tblEnemys.FirstOrDefault(s => s.Id == id);
            Enemy.EnemyName = "Edited";
            context.SaveChanges();
        }
        public static void DeleteEnemy(ApplicationContext context, int id)
        {
            var Enemy = context.tblEnemys.Find(id);
            if (Enemy != null)
            {
                context.Remove(Enemy);
                context.SaveChanges();
            }
        }
        public static void GetEnemyById(ApplicationContext context, int id)
        {
            var Enemey = context.tblEnemys.Find(id);
            Console.WriteLine($"Enemy Name {Enemey.EnemyName} and its Description {Enemey.Description}");
        }

    }
}
