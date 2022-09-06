using EFCore;

namespace DoctorWho.Db
{
    public static class CrudMethods
    {
        public static void CreateCompanion(ApplicationContext context, string ComapnionName, string WhoPlayed)
        {
            context.tblCompanions.Add(new EfDoctorWho.tblCompanion
            {
                ComapnionName = ComapnionName,
                WhoPlayed = WhoPlayed
            });
            context.SaveChanges();
        }
        public static void CreateEnemy(ApplicationContext context, string description, string EnemyName)
        {
            context.tblEnemys.Add(new EfDoctorWho.tblEnemy
            {
                Description = description,
                EnemyName = EnemyName,

            });
            context.SaveChanges();
        }
        public static void CreateDoctor(ApplicationContext context, int DoctorNumber, string DoctorName)
        {
            context.tblDoctors.Add(new EfDoctorWho.tblDoctor
            {
                BirthDate = DateTime.Now,
                DoctorNumber = DoctorNumber,
                FirstEpisodDate = DateTime.Now
               ,
                DoctorName = DoctorName,
                LastEpisodDate = DateTime.Now,

            });
            context.SaveChanges();
        }
        public static void CreateAuthor(ApplicationContext context, string AuthorName)
        {
            if (AuthorName != null)
            {
                context.tblAuthors.Add(new EfDoctorWho.tblAuthor
                {
                    AuthorName = AuthorName
                });
                context.SaveChanges();
                context.SaveChanges();
            }

        }
        public static void CreateEpisodes(ApplicationContext context) { 
            context.tblEpisods.Add(new EfDoctorWho.tblEpisod
            {
                EpisodDate = DateTime.Now,
                EpisodType = "ccdc",
                EpisodNumber = 1488,
                Notes = "dd",
                SeriesNumber = 1448,
                Title = "ttttt",
            });
            context.SaveChanges();
        }
        public static void updateCompanionName(ApplicationContext context, int id)
        {
                var Companion = context.tblCompanions.FirstOrDefault(s => s.Id == id);
                Companion.ComapnionName = "Edited";
                context.SaveChanges();   
        }
        public static void updateEnemyName(ApplicationContext context, int id)
        {
                var Enemy = context.tblEnemys.FirstOrDefault(s => s.Id==id);
                Enemy.EnemyName = "Edited";
                context.SaveChanges();   
        }
        public static void updateDoctorName(ApplicationContext context, int id)
        {
                var Doctor = context.tblDoctors.FirstOrDefault(s => s.Id == id);
                Doctor.DoctorName = "Edited";
                context.SaveChanges();   
        }
        public static void updateAuthorName(ApplicationContext context, int id)
        {
                var Author = context.tblAuthors.FirstOrDefault(s => s.Id == id);
                Author.AuthorName = "Edited";
                context.SaveChanges();
        }
        public static void updateEpisodTitle(ApplicationContext context, int id)
        {
                var Episod = context.tblEpisods.FirstOrDefault(s => s.Id == id);
                Episod.Title = "Edited";
                context.SaveChanges();   
        }
        public static void DeleteCompanion(ApplicationContext context, int id)
        {
                var Companion = context.tblCompanions.FirstOrDefault(s => s.Id == id);
                Companion.ComapnionName = "Edited";
                context.SaveChanges();
        }
        public static void DeleteEnemy(ApplicationContext context, int id)
        {
                var Enemy = context.tblEnemys.Find(id);
                if(Enemy != null)
                {
                    context.Remove(Enemy);
                    context.SaveChanges();
                }
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
        public static void DeleteAuthor(ApplicationContext context, int id)
        {
            var Author = context.tblAuthors.Find(id);
            if (Author != null)
            {
                context.Remove(Author);
                context.SaveChanges();
            }
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
        ///companions, enemies, doctors, authors, and episodes.
    }
}