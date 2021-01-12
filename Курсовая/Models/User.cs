using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая
{
    [Table(Name="User")]
    public class User
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int User_ID { get; set; }
        [Column(Name = "Login")]
        public string Login { get; set; }
        [Column(Name = "Password")]
        public string Password { get; set; }
        [Column(Name = "Status")]
        public string Status { get; set; } = "Один з батьків/Опікун";
    }
}
