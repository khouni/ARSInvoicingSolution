using System;
using System.Collections.Generic;

namespace _00.Infrastructure.Models
{
    public partial class Customer
    {
        public Guid CustomerUid { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public string TradeRegister { get; set; }
        public string SocialReason { get; set; }
        public string Adress { get; set; }
        public int? Phone { get; set; }
        public string Email { get; set; }
        public int TypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public CustomerType Type { get; set; }
    }
}
