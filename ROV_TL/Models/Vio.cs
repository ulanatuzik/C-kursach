using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROV_TL.Models
{
    public class Vio
    {
        public int VioId { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public string Violation { get; set; }
        public int Fine { get; set; }
        public DateTime Date { get; set; }
    }
}
