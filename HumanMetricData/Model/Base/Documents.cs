using System;
using System.Collections.Generic;
using System.Text;

namespace HumanMetricData.Model.Base
{
    public class Documents:Base
    {
        public string BirthCertificate { get; set; }
        public string DeathCertificate { get; set; }
        public string WeddingCertificate { get; set; }
        public string PassportNumber { get; set; }
    }
}
