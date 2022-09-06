using DoctorWho.Db;
using EFCore;
using EfDoctorWho;
using Microsoft.EntityFrameworkCore;
namespace program{

    public class Program
    {
        public static  void Main(string[] args)
        {
           var context = new ApplicationContext();
            
           ViewProceduresFunction.GetEnemiesNameProcedure(context);    
           ViewProceduresFunction.PrintDoctorsNamesView(context);
           ViewProceduresFunction.GetEnemyName_Function(context,1);
            CrudMethods.CreateEpisodes(context);

            SeedData.InsertAuthorEpisodData(context,"unKNown", DateTime.Now,4545,"ew","note1",589,"-");
            SeedData.InsertAuthorEpisodData(context,"unKNown", DateTime.Now,4545,"ew","note1",589,"-");
            SeedData.InsertAuthorEpisodData(context,"unKNown", DateTime.Now,4545,"ew","note1",589,"-");
            SeedData.InsertAuthorEpisodData(context,"unKNown", DateTime.Now,4545,"ew","note1",589,"-");
            SeedData.InsertAuthorEpisodData(context,"unKNown", DateTime.Now,4545,"ew","note1",589,"-");   
            SeedData.InsertDoctorEpisodData(context,"D5",15, DateTime.Now, DateTime.Now,DateTime.Now,DateTime.Now,4545,"ew","note1",589,"-");
            SeedData.InsertDoctorEpisodData(context,"D5",15, DateTime.Now, DateTime.Now,DateTime.Now,DateTime.Now,4545,"ew","note1",589,"-");
            SeedData.InsertDoctorEpisodData(context,"D5",15, DateTime.Now, DateTime.Now,DateTime.Now,DateTime.Now,4545,"ew","note1",589,"-");
            SeedData.InsertDoctorEpisodData(context,"D5",15, DateTime.Now, DateTime.Now,DateTime.Now,DateTime.Now,4545,"ew","note1",589,"-");
            SeedData.InsertDoctorEpisodData(context,"D5",15, DateTime.Now, DateTime.Now,DateTime.Now,DateTime.Now,4545,"ew","note1",589,"-");
            SeedData.InsertCompanionEpisodData(context,"D5","w",488,"ew","note1",589,"-");
            SeedData.InsertCompanionEpisodData(context,"D5","w",488,"ew","note1",589,"-");
            SeedData.InsertCompanionEpisodData(context,"D5","w",488,"ew","note1",589,"-");
            SeedData.InsertCompanionEpisodData(context,"D5","w",488,"ew","note1",589,"-");
            SeedData.InsertCompanionEpisodData(context,"D5","w",488,"ew","note1",589,"-");
            SeedData.InsertEnemyEpisodData(context,"D5","nothing---",488,"ew","note1",589,"-");
            SeedData.InsertEnemyEpisodData(context,"D5","nothing---",488,"ew","note1",589,"-");
            SeedData.InsertEnemyEpisodData(context,"D5","nothing---",488,"ew","note1",589,"-");
            SeedData.InsertEnemyEpisodData(context,"D5","nothing---",488,"ew","note1",589,"-");
            SeedData.InsertEnemyEpisodData(context,"D5","nothing---",488,"ew","note1",589,"-");


         

            /* Task11.GetAllDoctors(context); 
             Task11.AddEnemytblEpisod(context,1,"2"); 
             */
            // CrudMethods.DeleteAuthor(context, 1);
            // CrudMethods.CreateAuthor(context, "yoy");

        }
    }


}