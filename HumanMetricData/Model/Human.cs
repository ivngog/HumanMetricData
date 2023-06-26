using System;
using System.Collections.Generic;
using System.Text;

namespace HumanMetricData.Model
{
    public class Human
    {
        public enum Gender {male, female}
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        public string HumanGender { get; set; }
        public string Nationality { get; set; }
    }
}
