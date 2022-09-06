using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDoctorWho
{
    public class tblEpisod
    {
        public int Id { get; set; }
       public int SeriesNumber { get; set; }
       public int EpisodNumber { get; set; }
       public string EpisodType { get; set; }
       public string Title { get; set; }
       public DateTime EpisodDate { get; set; }
       public string Notes { get; set; }
        public ICollection<tblCompanion> TblCompanion { get; set; }
       public ICollection<tblEnemy> TblEnemy { get; set; }

    }
}
