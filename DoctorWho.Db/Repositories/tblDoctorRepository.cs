using EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class DoctorssRepository
    {
        public static void CreateDoctor(ApplicationContext context, int DoctorNumber, string DoctorName)
        {
            context.tblDoctors.Add(new EfDoctorWho.tblDoctor
            {
                BirthDate = DateTime.Now,
                DoctorNumber = DoctorNumber,
                FirstEpisodDate = DateTime.Now,
                DoctorName = DoctorName,
                LastEpisodDate = DateTime.Now,

            });
            context.SaveChanges();
        }
        public static void updateDoctorName(ApplicationContext context, int id)
        {
                var Doctor = context.tblDoctors.FirstOrDefault(s => s.Id == id);
                Doctor.DoctorName = "Edited";
                context.SaveChanges();
        }
        public static void DeleteDoctor(ApplicationContext context, int id)
        {
            var Doctor = context.tblDoctors.Find(id);
            if (Doctor != null)
            {
                context.Remove(Doctor);
                context.SaveChanges();
            }
        }
        public static void GetAllDoctors(ApplicationContext context)
        {
            var Doctors = context.tblDoctors.Select(s => s).ToList();
            foreach (var doctor in Doctors)
            {
                Console.WriteLine($"Doctor Name {doctor.DoctorName} and its Series Number {doctor.DoctorNumber}");
            }
        }
    }
}
