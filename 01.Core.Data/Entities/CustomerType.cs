using System;
using System.Collections.Generic;

namespace _00.Infrastructure.Models
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            Customer = new HashSet<Customer>();
            HourlyRate = new HashSet<HourlyRate>();
        }

        public Guid CustomerTypeTypeUid { get; set; }
        public int CustomerTypeTypeId { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<Customer> Customer { get; set; }
        public ICollection<HourlyRate> HourlyRate { get; set; }
    }
}
