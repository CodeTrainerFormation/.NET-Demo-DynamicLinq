using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal class SchoolInitializer : CreateDatabaseIfNotExists<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
           
            #region Teachers
            var teachers = new List<Teacher>()
            {
                new Teacher()
                {
                    FirstName = "Barney",
                    LastName = "Stinson",
                    Age = 35,
                    Discipline = "Economie",
                    HiringDate = new DateTime(2008, 08, 30),
                },
                new Teacher()
                {
                    FirstName = "Perry",
                    LastName = "Cox",
                    Age = 45,
                    Discipline = "Medecine",
                    HiringDate = new DateTime(2000, 05, 15),
                },
            };
            context.Teachers.AddRange(teachers);
            context.SaveChanges();
            #endregion

            #region Students
            var students = new List<Student>()
            {
                new Student()
                {
                    FirstName = "Ted",
                    LastName = "Mosby",
                    Age = 20,
                    Average = 12.0,
                    IsClassDelegate = false,
                },
                new Student()
                {
                    FirstName = "John",
                    LastName = "Dorian",
                    Age = 22,
                    Average = 19.0,
                    IsClassDelegate = true,
                },
                new Student()
                {
                    FirstName = "Marshall",
                    LastName = "Eriksen",
                    Age = 21,
                    Average = 9.0,
                    IsClassDelegate = false,
                },
                new Student()
                {
                    FirstName = "Robin",
                    LastName = "Scherbatsky",
                    Age = 23,
                    Average = 13.0,
                    IsClassDelegate = false,
                },
                new Student()
                {
                    FirstName = "Lily",
                    LastName = "Aldrin",
                    Age = 20,
                    Average = 14.0,
                    IsClassDelegate = false,
                },
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            #endregion

            base.Seed(context);
        }
    }
}
