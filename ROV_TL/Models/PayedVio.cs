using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROV_TL.Models
{
    public class PayedVio
    {
        [Key]
        public int PayId { get; set; }
        public int PrevVioId { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public string Violation { get; set; }
        public string Fine { get; set; }
        public DateTime Date { get; set; }
    }
}
