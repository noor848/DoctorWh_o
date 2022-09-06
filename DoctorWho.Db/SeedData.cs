using EFCore;
using EfDoctorWho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class SeedData
    {
        public static void InsertAuthorEpisodData(ApplicationContext context, string AuthorName, DateTime EpisodDate, int EpisodNumber, string EpisodType, string Notes, int SeriesNumber, string Title)
        {
            context.AddRange(
            new tblAuthor
            {
                AuthorName = AuthorName,
                TblEpisod = new List<tblEpisod>
                 { new tblEpisod{
                        EpisodDate = EpisodDate,
                        EpisodNumber = EpisodNumber,
                        EpisodType = EpisodType,
                        Notes = Notes,
                        SeriesNumber = SeriesNumber,
                        Title = Title,
               }}
            });
        }
        public static void InsertDoctorEpisodData(ApplicationContext context, string DoctorName, int DoctorNumber,
            DateTime BirthDate, DateTime FirstEpisodDate, DateTime LastEpisodDate, DateTime EpisodDate, int EpisodNumber, string EpisodType, string Notes, int SeriesNumber, string Title)
        {
            context.AddRange(
              new tblDoctor
              {
                  DoctorName = DoctorName,
                  DoctorNumber = DoctorNumber,
                  BirthDate = BirthDate,
                  FirstEpisodDate = FirstEpisodDate,
                  LastEpisodDate = LastEpisodDate,
                  TblEpisod = new List<tblEpisod>
                     { new tblEpisod{
                        EpisodDate = EpisodDate,
                        EpisodNumber = EpisodNumber,
                        EpisodType = EpisodType,
                        Notes = Notes,
                        SeriesNumber = SeriesNumber,
                        Title = Title,
                    }}
              });
        }
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

        /*  public static void InsertEpisodData(ApplicationContext context, string EnemyName, string Description,
               int EpisodNumber, string EpisodType, string Notes, int SeriesNumber, string Title)
          {
              context.AddRange(
                   new tblEpisod
                   {
                     EpisodDate = DateTime.Now,
                      EpisodNumber =EpisodNumber,
                      EpisodType = EpisodType,
                      Notes = Notes,
                      SeriesNumber = SeriesNumber,
                      Title = Title,
                      TblAuthor=new tblAuthor()

                    );
              context.SaveChanges();
          }

          */
    }
}
