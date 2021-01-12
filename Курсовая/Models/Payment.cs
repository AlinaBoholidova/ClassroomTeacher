using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая
{
    [Table(Name = "Payment")]
    class Payment
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Payment_ID { get; set; }
        [Column(Name = "Pupil_ID")]
        public int Pupil_ID { get; set; }
        [Column(Name = "PaymentRate_ID")]
        public int PaymentRate_ID { get; set; }
        [Column(Name = "Month")]
        public string Month { get; set; }
        [Column(Name = "Paid")]
        public bool Paid { get; set; } = false;
    }
}
