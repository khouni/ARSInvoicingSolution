using System;
using System.Collections.Generic;

namespace _00.Infrastructure.Models
{
    public partial class Employe
    {
        public Guid EmployeUid { get; set; }
        public int RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int EmploymentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public Employment Employment { get; set; }
    }
}
