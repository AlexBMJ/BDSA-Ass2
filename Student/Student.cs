using System;

namespace Student
{
    public class Student
    {
        public int Id { get; init; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Status { get; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public string toString() {
            return $"Id: {Id.ToString()}, Name: {GivenName}, Surname: {Surname}, Status: {Status}, Start Date: {StartDate.ToString()}, End Date: {EndDate.ToString()}, Graduation Date: {GraduationDate.ToString()}"
        }
    }

    enum Status {
        New,
        Active,
        Dropout,
        Graduated
    }
}
