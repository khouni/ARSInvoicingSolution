using System;
using System.Collections.Generic;

namespace _00.Infrastructure.Models
{
    public partial class HourlyRate
    {
        public int HourlyRateUid { get; set; }
        public int HourlyRateId { get; set; }
        public int CustomerTypeId { get; set; }
        public int InterventionTypeId { get; set; }
        public int CurrencyId { get; set; }
        public decimal PriceWithoutTaxe { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public Currency Currency { get; set; }
        public CustomerType CustomerType { get; set; }
        public HourlyRate HourlyRateNavigation { get; set; }
        public InterventionType InterventionType { get; set; }
        public HourlyRate InverseHourlyRateNavigation { get; set; }
    }
}
