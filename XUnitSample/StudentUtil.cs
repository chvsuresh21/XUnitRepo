using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitSample
{
    public static class StudentUtil
    {
        static List<Student> lstStudents = new List<Student> {
            new Student { StudentId="1", FirstName="Chatakondi", LastName="Suresh", Location="Hyderabad", Gender='M', EmailId="suresh.chatakondi@tcs.com"  },
            new Student { StudentId="2", FirstName="Venkata", LastName="Ramesh", Location="Ongole", Gender='M', EmailId="suresh.chatakondi@tcs.com"  },
            new Student { StudentId="3", FirstName="Darisi", LastName="Chakravarthi", Location="Chennai", Gender='M', EmailId="suresh.chatakondi@tcs.com"  },
            new Student { StudentId="4", FirstName="Anumala", LastName="Sravanthi", Location="Nellore", Gender='F', EmailId="suresh.chatakondi@tcs.com"  }
        };
        public static Student GetStudentByName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name must be provided.");
            }

            return lstStudents.Where(a => a.FirstName == firstName).FirstOrDefault();
        }
        public static int GetTotalRecords()
        {

            return lstStudents.Count();

        }
        public static string GetStudentLocationByStudentId(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId))
            {
                throw new ArgumentException("First name must be provided.");
            }
            var student = lstStudents.Where(a => a.StudentId == studentId).FirstOrDefault();
            if (student == null)
                throw new ArgumentException("No user exists");
            else
                return student.Location;
        }

        
    }

    //public class StudentTest
    //{
    //    IEnumerable<int> result = from value in Enumerable.Range(0, 5)
    //                              select value;
    //    IEnumerable<Student> result = from value in Enumerable.Range(0, 5)
    //                              select value;
    //    Student[] students = new Student[2];
    //    Student[0] =  new Student { StudentId="1", FirstName="Chatakondi", LastName="Suresh", Location="Hyderabad", Gender='M', EmailId="suresh.chatakondi@tcs.com"  }
    //    public IEnumerator<Student[]> GetEnumerator()
    //    {
    //        yield return new Student[] { 1, 2, 3 };
    //        yield return new object[] { -4, -6, -10 };
    //        yield return new object[] { -2, 2, 0 };
    //        yield return new object[] { int.MinValue, -1, int.MaxValue };
    //    }

    //    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    //}
}
