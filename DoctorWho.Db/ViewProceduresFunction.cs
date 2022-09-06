using EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public static  class ViewProceduresFunction
    {
        public static void GetEnemiesNameProcedure(ApplicationContext context)
        {
            var EnemyNameList = context.tblEnemys.FromSqlRaw("EXECUTE GetEnemiesName").ToList();
            foreach (var enemy in EnemyNameList)
            {
                Console.Write($"Enemy's Name {enemy.Id}: {enemy.EnemyName}, ");
            }
            Console.WriteLine("");
        }
        public static void PrintDoctorsNamesView(ApplicationContext context)
        {
            var NameList = context.viewPrintDoctorsNames.ToList();
            
            foreach (var name in NameList)
            {
                Console.Write($"Doctor's Name {name.Id}: {name.DoctorName}, ");
            }
            Console.WriteLine("");

        }
        public static void GetEnemyName_Function(ApplicationContext context,int id)
        {
            var response = context.EnemyFunctions.FromSqlRaw($"select* from  GetEnemyname({id})").ToList().FirstOrDefault();
            Console.WriteLine($"Enemy Name has Id ={id} is {response.EnemyName}");
        }
    }
}
