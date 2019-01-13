using System;
using System.Collections.Generic;

namespace _01.Core.Data
{
    public partial class Currency
    {
        public Currency()
        {
            HourlyRate = new HashSet<HourlyRate>();
        }

        public int CurrencyUid { get; set; }
        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<HourlyRate> HourlyRate { get; set; }
    }
}
