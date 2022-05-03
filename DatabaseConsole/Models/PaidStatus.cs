using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConsole.Models
{
    public partial class PaidStatus
    {
        public int Id { get; set; }
        public string Status { get; set; } = "unpaid";
        public int TranscationId { get; set; }
        public virtual Transcation Transcation { get; set; }
    }
}
