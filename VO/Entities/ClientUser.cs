using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO.Entities
{
    public class ClientUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }        
        public decimal Balance { get; set; }
        [NotMapped]
        public User User { get; set; }
    }
}
