using System;
using System.Collections.Generic;
using System.Text;

namespace HumanMetricData.Model.Base
{
    
    public class Base
    {
        
        public int Id { get; set; }
        public int Id2 { get; set; }
        public int HumanId { get; set; }
        public string ActiveRecord { get; set; }
        public DateTime DateOfRecordNumber { get; set; }

        public DateTime DateOfСommiting { get; set; }
        public string PlaceOfRegistration { get; set; }
        public string PerformedSacrament { get; set; }
        public string Notes { get; set; }
        public string NameOfJournal { get; set; }

#nullable enable
        public string? FirstInitials { get; set; } = null;
        public string? SecondInitials { get; set; } = null;
        public string? ThirdInitials { get; set; } = null;
        public string? FourInitials { get; set; } = null;
        public string? FirstPassport { get; set; } = null;
        public string? SecondPassport { get; set; } = null;
        public string? ThirdPassport { get; set; } = null;
        public string? FourPassport { get; set; } = null;
        public DateTime? FirstBirthday { get; set; } = null;
        public DateTime? SecondBirthday { get; set; } = null;
        public DateTime? ThirdBirthday { get; set; } = null;
        public DateTime? FourBirthday { get; set; } = null;
        public string? FirstAddress { get; set; } = null;
        public string? SecondAddress { get; set; } = null;
        public string? ThirdAddress { get; set; } = null;
        public string? FourAddress { get; set; } = null;
#nullable disable


    }
}
