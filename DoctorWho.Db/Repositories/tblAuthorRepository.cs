using EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class tblAuthorRepository
    {
        public static void CreateAuthor(ApplicationContext context, string AuthorName)
        {
            if (AuthorName != null)
            {
                context.tblAuthors.Add(new EfDoctorWho.tblAuthor
                {
                    AuthorName = AuthorName
                });
                context.SaveChanges();
            }

        }
        public static void updateAuthorName(ApplicationContext context, int id)
        {
                var Author = context.tblAuthors.FirstOrDefault(s => s.Id == id);
                Author.AuthorName = "Edited";
                context.SaveChanges();
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



    }
}
