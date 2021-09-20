using System;

namespace Assignment2
{
    public class Student
    {
        public int Id { get; init; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public Statuses Status {
            get {
                var now = DateTime.Now;
                if (StartDate + TimeSpan.FromDays(180) > now)
                    return Statuses.New;
                if (StartDate < now && EndDate > now)
                    return Statuses.Active;
                if (GraduationDate < StartDate && EndDate < now)
                    return Statuses.Dropout;
                if (GraduationDate > StartDate && GraduationDate > now)
                    return Statuses.Graduated;
                throw new InvalidTimeZoneException();
            }
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }


        
        public string ToString() {
            return
                $"Id: {Id.ToString()}, Name: {GivenName}, Surname: {Surname}, Status: {Status.ToString()}, Start Date: {StartDate.ToString()}, End Date: {EndDate.ToString()}, Graduation Date: {GraduationDate.ToString()}";
        }
    }

    public enum Statuses {
        New,
        Active,
        Dropout,
        Graduated
    }
}
