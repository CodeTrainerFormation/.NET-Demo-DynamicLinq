using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    internal class ClassroomMapping : EntityTypeConfiguration<Classroom>
    {
        public ClassroomMapping()
        {
            this.ToTable("Classroom", "School");

            this.Property(c => c.Name)
                .HasMaxLength(50);

            this.Property(c => c.Corridor)
                .HasMaxLength(50);

            //one-to-many
            this.HasMany(c => c.Students)
                .WithOptional(s => s.Classroom);

            //one-to-one
            //this.HasRequired(c => c.Teacher)
            //    .WithOptional(t => t.Classroom);
        }
    }
}
