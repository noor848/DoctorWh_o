using EFCore;
using EfDoctorWho;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public static class GettingData
    {
        public static void GetAllDoctors(ApplicationContext context)
        {
            var Doctors = context.tblDoctors.Select(s => s).ToList();
            foreach (var doctor in Doctors)
            {
                Console.WriteLine($"Doctor Name {doctor.DoctorName} and its Series Number {doctor.DoctorNumber}");
            }
        }
        public static void GetEnemyById(ApplicationContext context,int id)
        {
            var Enemey = context.tblEnemys.Find(id);
            
            Console.WriteLine($"Enemy Name {Enemey.EnemyName} and its Description {Enemey.Description}");
        }
        public static void GetCompanionById(ApplicationContext context,int id)
        {
            var companion = context.tblCompanions.Find(id);
            
            Console.WriteLine($"companion Name {companion.ComapnionName}");
        }

    }


}

