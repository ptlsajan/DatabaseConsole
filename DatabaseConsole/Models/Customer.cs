using System;
using System.Collections.Generic;

namespace DatabaseConsole.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Transcations = new HashSet<Transcation>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Phone { get; set; }

        public decimal TotalAmount { get; set; } = 0;

        public virtual ICollection<Transcation> Transcations { get; set; } = null!;
    }
}
