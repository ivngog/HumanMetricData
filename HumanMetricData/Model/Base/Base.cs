using System;
using System.Collections.Generic;
using System.Text;

namespace HumanMetricData.Model.Base
{
    public class Base
    {
        public int Id { get; set; }
        public int HumanId { get; set; }
        public int NumberOfRecord { get; set; }
        public string Name { get; set; }
        public DateTime DateOfRecordNumber { get; set; }
        
        public DateTime DateOfСommiting { get; set; }
        public string BloodType { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PlaceOfRegistration { get; set; }
        public string SeriesOfDocument { get; set; }
        public int NumberOfDocument { get; set; }
        public string Religion { get; set; }
        public int FirstPersonId { get; set; }
        public int LastPersonId { get; set; }
        public string PerformedSacrament { get; set; }
        public string Notes { get; set; }
    }
}
