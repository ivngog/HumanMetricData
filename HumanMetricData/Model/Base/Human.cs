using System;
using System.Collections.Generic;
using System.Text;
using HumanMetricData.SQLOperations;

namespace HumanMetricData.Model.Base
{
    public class Human : Image
    {
        
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        public string Address { get; set; }

        
       
        
    }
}
