using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDoctorWho
{
    public class tblEnemy
    {
        public int Id { get; set; }
        public string EnemyName { get; set; }
        public string Description { get; set; }
        public ICollection<tblEpisod> TblEpisod { get; set; }

    }
}
