using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDoctorWho
{
    public class tblAuthor
    {
       public int Id { get; set; }
       public string AuthorName { get; set; }
        public ICollection<tblEpisod> TblEpisod { get; set; }

    }
}
