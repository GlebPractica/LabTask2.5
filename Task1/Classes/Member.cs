using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DateBirthDay {  get; set; }
        public string Gen { get; set; }
        public decimal Amount { get; set; }
        public string Timing { get; set; }

        public List<Payment> Payments { get; set; } = new(); // оплаты клиентов
    }
}
