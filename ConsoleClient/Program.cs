using Dal;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext context = new SchoolContext())
            {
                //---Static Linq---
                var students = context.Students.AsNoTracking().Where(s => s.Age >= 21).ToList();

                //Expression<Func<Student, bool>> lambda = null;

                //---Dynamic Linq---
                //ParameterExpression entity = Expression.Parameter(typeof(Student), "s");
                //MemberExpression member = Expression.Property(entity, "Age");
                //ConstantExpression constant = Expression.Constant(21, typeof(int));
                //BinaryExpression body = Expression.GreaterThanOrEqual(member, constant);

                //lambda = Expression.Lambda<Func<Student, bool>>(body, entity);
                //Console.WriteLine(lambda.ToString());

                //var students = context.Students.AsNoTracking().Where(lambda.Compile());

                foreach (Student student in students)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} {student.Age}yo");
                }

            }//Dispose();

            Console.ReadLine();
        }
    }
}
