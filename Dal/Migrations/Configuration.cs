namespace Dal.Migrations
{
    using DomainModel;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Dal.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Dal.SchoolContext";
        }

        protected override void Seed(Dal.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            #region Teachers
            var teachers = new List<Teacher>()
            {
                new Teacher()
                {
                    PersonID = 1,
                    FirstName = "Barney",
                    LastName = "Stinson",
                    Age = 35,
                    Discipline = "Economie",
                    HiringDate = new DateTime(2008, 08, 30),
                },
                new Teacher()
                {
                    PersonID = 2,
                    FirstName = "Perry",
                    LastName = "Cox",
                    Age = 45,
                    Discipline = "Medecine",
                    HiringDate = new DateTime(2000, 05, 15),
                },
            };
            context.Teachers.AddOrUpdate(teachers.ToArray());
            #endregion

            #region Students
            var students = new List<Student>()
            {
                new Student()
                {
                    PersonID = 3,
                    FirstName = "Ted",
                    LastName = "Mosby",
                    Age = 20,
                    Average = 12.0,
                    IsClassDelegate = false,
                },
                new Student()
                {
                    PersonID = 4,
                    FirstName = "John",
                    LastName = "Dorian",
                    Age = 22,
                    Average = 19.0,
                    IsClassDelegate = true,
                },
                new Student()
                {
                    PersonID = 5,
                    FirstName = "Marshall",
                    LastName = "Eriksen",
                    Age = 21,
                    Average = 9.0,
                    IsClassDelegate = false,
                },
                new Student()
                {
                    PersonID = 6,
                    FirstName = "Robin",
                    LastName = "Scherbatsky",
                    Age = 23,
                    Average = 13.0,
                    IsClassDelegate = false,
                },
                new Student()
                {
                    PersonID = 7,
                    FirstName = "Lily",
                    LastName = "Aldrin",
                    Age = 20,
                    Average = 14.0,
                    IsClassDelegate = false,
                },
            };

            context.Students.AddOrUpdate(students.ToArray());

            #endregion

            //EMPLOYEES
        }
    }
}
