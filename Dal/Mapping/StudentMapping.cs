using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    internal class StudentMapping : EntityTypeConfiguration<Student>
    {
        public StudentMapping()
        {
            this.ToTable(schemaName: "School", tableName: "Student");
        }
    }
}
