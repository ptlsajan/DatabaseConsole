using System;
using System.Collections.Generic;

namespace DatabaseConsole.Models
{
    public partial class Rate
    {
        public Rate()
        {
            Transcations = new HashSet<Transcation>();
        }
        public int Id { get; set; }
        public decimal Price { get; set; }

        public ICollection<Transcation> Transcations { get; set; } = null!;
    }
}
