using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    internal class PersonMapping : EntityTypeConfiguration<Person>
    {
        public PersonMapping()
        {
            this.ToTable("Person", "School");

            this.HasKey(p => p.PersonID)
                .Property(p => p.PersonID)
                .HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(p => p.Age)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute()));
        }
    }
}
