using EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class tblEpisodRepositry
    {
        public static void CreateEpisodes(ApplicationContext context, string EposideType, int EposidNum, string notes, int seriesNumber, int authorid, string title)
        {
            context.tblEpisods.Add(new EfDoctorWho.tblEpisod
            {
                EpisodDate = DateTime.Now,
                EpisodType = EposideType,
                EpisodNumber = EposidNum,
                Notes = notes,
                SeriesNumber = seriesNumber,
                Title = title,

            });
            context.SaveChanges();
        }
        public static void updateEpisodTitle(ApplicationContext context, int id)
        {
                var Episod = context.tblEpisods.FirstOrDefault(s => s.Id == id);
                Episod.Title = "Edited";
                context.SaveChanges();   
        }
        public static void DeleteEpisod(ApplicationContext context, int id) 
        {
                var Episod = context.tblEpisods.Find(id);
                if (Episod != null)
                {
                    context.Remove(Episod);
                    context.SaveChanges();
                }
        }

    }
}
