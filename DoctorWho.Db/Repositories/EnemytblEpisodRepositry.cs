using EFCore;
using EfDoctorWho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EnemytblEpisodRepositry
    {
        public static void InsertEnemyEpisodData(ApplicationContext context, string EnemyName, string Description,
           int EpisodNumber, string EpisodType, string Notes, int SeriesNumber, string Title)
        {
            context.AddRange(
             new tblEnemy
             {
                 EnemyName = EnemyName,
                 Description = Description,

                 TblEpisod = new List<tblEpisod> {
                 new tblEpisod
                 {
                   EpisodDate = DateTime.Now,
                    EpisodNumber =EpisodNumber,
                    EpisodType = EpisodType,
                    Notes = Notes,
                    SeriesNumber = SeriesNumber,
                    Title = Title,
                 }}
             });
            context.SaveChanges();
        }
    }
}
