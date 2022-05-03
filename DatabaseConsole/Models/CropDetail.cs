using System;
using System.Collections.Generic;

namespace DatabaseConsole.Models
{
    public partial class CropDetail
    {
        public CropDetail()
        {
            Transcations = new HashSet<Transcation>();
        }
        public int Id { get; set; }
        public string Crop { get; set; }
       
        public virtual ICollection<Transcation> Transcations { get; set; } = null!;
    }
}
