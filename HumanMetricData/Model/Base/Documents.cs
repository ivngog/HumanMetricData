using System;
using System.Collections.Generic;
using System.Text;

namespace HumanMetricData.Model.Base
{
    public class Documents:Base
    {
        public string BirthCertificate { get; set; } = null;
        public string DeathCertificate { get; set; } = null;
        public string WeddingCertificate { get; set; } = null;
        public string PassportNumber { get; set; } = null;
    }
}
