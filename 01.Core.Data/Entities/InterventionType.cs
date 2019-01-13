using System;
using System.Collections.Generic;

namespace _00.Infrastructure.Models
{
    public partial class InterventionType
    {
        public InterventionType()
        {
            HourlyRate = new HashSet<HourlyRate>();
        }

        public Guid InterventionTypeUid { get; set; }
        public int InterventionTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<HourlyRate> HourlyRate { get; set; }
    }
}
