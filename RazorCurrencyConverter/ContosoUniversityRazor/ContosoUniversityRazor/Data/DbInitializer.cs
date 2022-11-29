using ContosoUniversityRazor.Models;

namespace ContosoUniversityRazor.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstMidName="Maarten",LastName="Vanderbeeken",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstMidName="James",LastName="Day",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName="Kevin",LastName="Corlett",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstMidName="Tomas",LastName="Pinto",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstMidName="Samuel",LastName="Baker",EnrollmentDate=DateTime.Parse("2018-09-01")},
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1,Title="Web Applications",Credits=3},
                new Course{CourseID=2,Title="Database Design",Credits=3},
                new Course{CourseID=3,Title="Network Systems",Credits=3},
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=2,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=3,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=2,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=3,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=3},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}