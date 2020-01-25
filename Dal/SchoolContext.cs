using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using System.ComponentModel.DataAnnotations.Schema;
using Dal.Mapping;

namespace Dal
{
    public class SchoolContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Employee> Employees { get; set; }

        static SchoolContext()
        {
            Database.SetInitializer<SchoolContext>(new SchoolInitializer());
        }

        public SchoolContext()
            : base("SchoolDb")
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Configuration");

            modelBuilder.Configurations.Add(new PersonMapping());
            modelBuilder.Configurations.Add(new StudentMapping());
            modelBuilder.Configurations.Add(new TeacherMapping());
            modelBuilder.Configurations.Add(new ClassroomMapping());
            modelBuilder.Configurations.Add(new EmployeeMapping());

            base.OnModelCreating(modelBuilder);
        }


    }
}
