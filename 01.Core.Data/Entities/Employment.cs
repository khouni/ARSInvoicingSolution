using System;
using System.Collections.Generic;

namespace _00.Infrastructure.Models
{
    public partial class Employment
    {
        public Employment()
        {
            Employe = new HashSet<Employe>();
        }

        public Guid EmploymentUid { get; set; }
        public int EmploymentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<Employe> Employe { get; set; }
    }
}
