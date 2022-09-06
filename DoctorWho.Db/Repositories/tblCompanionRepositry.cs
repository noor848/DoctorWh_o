using EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class tblCompanionRepositry
    {
        public static void GetCompanionById(ApplicationContext context, int id)
        {
            var companion = context.tblCompanions.Find(id);
            Console.WriteLine($"companion Name {companion.ComapnionName}");
        }
        public static void CreateCompanion(ApplicationContext context, string ComapnionName, string WhoPlayed)
        {
            context.tblCompanions.Add(new EfDoctorWho.tblCompanion
            {
                ComapnionName = ComapnionName,
                WhoPlayed = WhoPlayed
            });
            context.SaveChanges();
        }
        public static void updateCompanionName(ApplicationContext context, int id)
        {
            var Companion = context.tblCompanions.FirstOrDefault(s => s.Id == id);
            Companion.ComapnionName = "Edited";
            context.SaveChanges();
        }
        public static void DeleteCompanion(ApplicationContext context, int id)
        {
                var Companion = context.tblCompanions.FirstOrDefault(s => s.Id == id);
                Companion.ComapnionName = "Edited";
                context.SaveChanges();
        }

    }
}
