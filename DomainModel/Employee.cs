using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Employee : Person
    {
        public int Rank { get; set; }
        public string Position { get; set; }
    }
}
