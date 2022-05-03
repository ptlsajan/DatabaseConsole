using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConsole.Models
{
    public partial class FieldDetail
    {
        public FieldDetail()
        {
            Transcations = new HashSet<Transcation>();
        }
        public int Id { get; set; }
        public string Field { get; set; }

        public virtual ICollection<Transcation> Transcations { get; set; } = null!;
    }
}
