using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO.Entities
{
    public class Recharges
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Value { get; set; }
        public decimal BondsValue { get; set; }
        public decimal TotalRecharge { get; set; }
        public DateTime DateRecharge { get; set; }
        public bool ApplyPromo { get; set; }
    }
}
