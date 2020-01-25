using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    internal class TeacherMapping : EntityTypeConfiguration<Teacher>
    {
        public TeacherMapping()
        {
            this.ToTable(schemaName: "School", tableName: "Teacher");

            this.Property(t => t.Discipline)
                .HasMaxLength(100);

            //this.Property(t => t.HiringDate)
            //    .HasColumnType("datetime");

            //zero-or-one-to-zero-or-one
            this.HasOptional(t => t.Classroom)
                .WithOptionalDependent(c => c.Teacher);
        }
    }
}
