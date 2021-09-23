using System;
using Xunit;
using System;

namespace Assignment2.Tests
{
    public class StudentUnitTest {
        [Fact]
        public void Status_GivenStartDate2020andEndDate2023andNow2021_ReturnsActive() {
            var student = new Student() {Id = 1, GivenName = "John", Surname = "Doe"};
            student.StartDate = DateTime.Now.Subtract(TimeSpan.FromDays(417));
            student.EndDate = DateTime.Now.AddYears(1).AddMonths(9).AddDays(6);
            Assert.Equal(Statuses.Active, student.Status);
        }

        [Fact]
        public void ImmutableStudentEquals_ReturnsTrueGivenTwoObjects_WithSameValues() {
            var Istudent1 = new ImmutableStudent() 
            {
                Id = 1,
                GivenName = "John",
                Surname = "Doe"
            };
            var Istudent2 = new ImmutableStudent() 
            {
                Id = 1,
                GivenName = "John",
                Surname = "Doe"
            };
            
            Assert.Equal(Istudent1, Istudent2);
        }

        [Fact]
        public void ImmutableStudentEquals_ReturnsFalseGivenTwoObjects_WithDifferentValues() {
            var Istudent = new ImmutableStudent() 
            {
                Id = 1,
                GivenName = "John",
                Surname = "Doe"
            };
            var newIstudent = Istudent with {Id = 2, GivenName = "Alex"};

            Assert.NotEqual(Istudent, newIstudent);
        }

        [Fact]
        public void ImmutableStudent_ToString_Returns_Properties() {
            var Istudent = new ImmutableStudent() 
            {
                Id = 1,
                GivenName = "John",
                Surname = "Doe",
                StartDate = new DateTime(2020, 8, 24),
                EndDate = new DateTime(2023, 7, 23),
                GraduationDate = new DateTime(2023, 7, 15)
            };

            string output = Istudent.ToString();
            string expected = $"ImmutableStudent {{ Id = 1, GivenName = John, Surname = Doe, Status = Active, StartDate = {Istudent.StartDate.ToString()}, EndDate = {Istudent.EndDate.ToString()}, GraduationDate = {Istudent.GraduationDate.ToString()} }}";

            Assert.Equal(expected, output);
        }
    }
}
