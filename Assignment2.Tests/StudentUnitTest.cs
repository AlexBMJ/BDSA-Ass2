using System;
using Xunit;
using System;

namespace Assignment2.Tests
{
    public class StudentUnitTest
    {
        [Fact]
        public void Status_GivenStartDate2020andEndDate2023andNow2021_ReturnsActive() {
            var student = new Student() {Id = 1, GivenName = "John", Surname = "Doe"};
            student.StartDate = new DateTime(2020, 8, 24);
            student.EndDate = new DateTime(2023, 7, 23);
            Console.WriteLine(student.ToString());
            Assert.Equal(Statuses.Active, student.Status);
        }
    }
}
