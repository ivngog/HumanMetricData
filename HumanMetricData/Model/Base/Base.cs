using System;
using System.Collections.Generic;
using System.Text;

namespace HumanMetricData.Model.Base
{
    
    public class Base
    {
        
        public int Id { get; set; }
        public int HumanId { get; set; }
        public string ActiveRecord { get; set; }
        public DateTime DateOfRecordNumber { get; set; }

        public DateTime DateOfСommiting { get; set; }
        public string PlaceOfRegistration { get; set; }
        public string PerformedSacrament { get; set; }
        public string Notes { get; set; }
        public string NameOfJournal { get; set; }
        public string FirstInitials { get; set; }
        public string SecondInitials { get; set; }
        public string ThirdInitials { get; set; }
        public string FourInitials { get; set; }
        public string FirstPassport { get; set; }
        public string SecondPassport { get; set; }
        public string ThirdPassport { get; set; }
        public string FourPassport { get; set; }
        public DateTime FirstBirthday { get; set; }
        public DateTime SecondBirthday { get; set; }
        public DateTime ThirdBirthday { get; set; }
        public DateTime FourBirthday { get; set; }
        public string FirstAddress { get; set; }
        public string SecondAddress { get; set; }
        public string ThirdAddress { get; set; }
        public string FourAddress { get; set; }
        
        
    }
}
