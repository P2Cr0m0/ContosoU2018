using ContosoU2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2018.Data
{
    public class DbInitializer
    {
        public static Grade Grade { get; private set; }
        public static int StudentID { get; private set; }

        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            //=========STUDENTS==========//
            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student
                {
                    FirstName = "Carson",
                    LastName = "Alexander",
                    Email = "calexander@contoso.com",
                    EnrollmentDate = DateTime.Parse("2017-09-01"),
                    Address = "4 Flanders Court",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 8H1"
                },
                new Student
                {
                    FirstName = "Carson2",
                    LastName = "Alexander2",
                    Email = "calexander2@contoso.com",
                    EnrollmentDate = DateTime.Parse("2017-09-01"),
                    Address = "4 Flanders Court",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 8H1"
                }
            };

            foreach (Student i in students)
            {
                context.Students.Add(i);
            }
            context.SaveChanges();

            //=====instruct

            var instructors = new Instructor[]
            {
                new Instructor
                {
                    FirstName = "bob",
                    LastName = "bob",
                    Email = "bob@contoso.com",
                    HireDate = DateTime.Parse("2017-09-01"),
                    Address = "4 Flanders Court",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 8H1"
                },
                new Instructor
                {
                    FirstName = "bobob",
                    LastName = "bobob",
                    Email = "bobob@contoso.com",
                    HireDate = DateTime.Parse("2017-09-01"),
                    Address = "4 Flanders Court",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 8H1"
                },
            };
            foreach(Instructor i in instructors)
            {
                context.Istructors.Add(i);
            }
            context.SaveChanges();

            //==========COURSES===========//
            var courses = new Course[]
            {
                new Course{CourseID = 1050,Title = "Chemestry",Credits=3},
                new Course{CourseID = 1040,Title = "Chemestry2",Credits=3},
            };
            foreach (Course c in courses)
            {
                context.Add(c);
            }
            context.SaveChanges();

            //===================================Enrollment===============================//
            var enrollments = new Enrollment[]
            {
                new Enrollment{CourseID=1050,StudentID=students.Single(s=>s.LastName=="Alexander").ID,Grade=Grade.A},
                new Enrollment{CourseID=4022,StudentID=students.Single(s=>s.LastName=="Alexander2").ID,Grade=Grade.B}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            //save context
            context.SaveChanges();


        }
    }
}
