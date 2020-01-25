using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Classroom
    {
        public int ClassroomID { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public string Corridor { get; set; }

        //navigation properties
        public virtual ICollection<Student> Students { get; set; }
        public virtual Teacher Teacher { get; set; }

    }
}
