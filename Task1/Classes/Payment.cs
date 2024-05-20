using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class Payment
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public DateTime DatePay { get; set; }
        public decimal Amount { get; set; }
    }
}
