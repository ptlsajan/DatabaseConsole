using System;
using System.Collections.Generic;

namespace DatabaseConsole.Models
{
    public partial class Transcation
    {
        public Transcation()
        {
            PaidStatuss = new HashSet<PaidStatus>();
        }
        public int Id { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }

        public decimal TotalHours { get; set; }
        public decimal PriceT { get; set; }
        public decimal PriceP { get; set; }
        public int CustomerId { get; set; }
        public int RateId { get; set; }
        public int CropDetailId { get; set; }

        public int FieldDetailId { get; set; }


        public virtual Customer Customer { get; set; }
        public virtual Rate Rate { get; set; }
        public virtual CropDetail CropDetail { get; set; }

        public virtual FieldDetail FieldDetail { get; set; }
        public virtual ICollection<PaidStatus> PaidStatuss { get; set; } = null!;
    }
}
