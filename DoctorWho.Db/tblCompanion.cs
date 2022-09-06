using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDoctorWho
{
    public class tblCompanion
    {
        public int Id { get; set; } 
        public string ComapnionName { get; set; }
        public string WhoPlayed { get; set; }
        public ICollection<tblEpisod> TblEpisod { get; set; }

    }
}
