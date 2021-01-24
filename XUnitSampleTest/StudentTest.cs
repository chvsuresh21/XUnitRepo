using System;
using Xunit;
using XUnitSample;

namespace XUnitSampleTest
{
    public class StudentTest
    {
        [Fact]
        public void GetTotalRecords()
        {
            var result = StudentUtil.GetTotalRecords();
            Assert.Equal(4, result);
        }

        [Theory]
        [InlineData("1", "Hyderabad")]
        [InlineData("2", "Ongole")]
        [InlineData("4", "Nellore")]
        public void GetStudentLocationByStudentIdTest(string studentId, string expectedResult)
        {
            var result = StudentUtil.GetStudentLocationByStudentId(studentId);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetStudentLocationByStudentIdExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => StudentUtil.GetStudentLocationByStudentId(""));
        }
        
        [Theory]
        [MemberData(nameof(StudentTestData.students), MemberType = typeof(StudentTestData))]
        public void GetStudentByNameTest(Student std)
        {
            var result = StudentUtil.GetStudentByName("Chatakondi");
            Assert.Equal(std.EmailId,result.EmailId);
        }
    }
    public class StudentTestData
    {
        public static TheoryData<Student> students => new TheoryData<Student> {
            new Student { StudentId="1", FirstName="Chatakondi", LastName="Suresh", Location="Hyderabad", Gender='M', EmailId="suresh.chatakondi@tcs.com"  },
            new Student { StudentId="2", FirstName="Venkata", LastName="Ramesh", Location="Ongole", Gender='M', EmailId="suresh.chatakondi@tcs.com"  },
            new Student { StudentId="3", FirstName="Darisi", LastName="Chakravarthi", Location="Chennai", Gender='M', EmailId="suresh.chatakondi@tcs.com"  },
        };
    }
}
