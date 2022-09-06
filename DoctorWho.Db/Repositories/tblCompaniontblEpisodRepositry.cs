using EFCore;
using EfDoctorWho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class tblCompaniontblEpisodRepositry
    {
        public static void InsertCompanionEpisodData(ApplicationContext context, string ComapnionName, string WhoPlayed,
                int EpisodNumber, string EpisodType, string Notes, int SeriesNumber, string Title)
        {

            context.AddRange(
            new tblCompanion
            {
                ComapnionName = ComapnionName,
                WhoPlayed = WhoPlayed,

                TblEpisod = new List<tblEpisod> {
                 new tblEpisod
                 {
                    EpisodDate = DateTime.Now,
                    EpisodNumber =EpisodNumber,
                    EpisodType = EpisodType,
                    Notes = Notes,
                    SeriesNumber = SeriesNumber,
                    Title = Title,
                 }
                  }
            });
            context.SaveChanges();
        }
    }
}
