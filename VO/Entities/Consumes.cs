using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO.Entities
{
    public class Consumes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Time { get; set; }
        public DateTime DateCall { get; set; }
        public decimal ValueCall { get; set; }
    }
}
