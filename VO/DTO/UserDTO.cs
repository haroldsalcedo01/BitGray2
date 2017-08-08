using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO.Entities;

namespace VO.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string NUI { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public double Balance { get; set; }

        public static UserDTO Convert(User user)
        {
            UserDTO objReturn = new UserDTO();
            objReturn.Id = user.Id;
            objReturn.Name = user.Name;
            objReturn.LastName = user.LastName;
            objReturn.NUI = user.NUI;
            objReturn.Phone = user.Phone;
            objReturn.Address = user.Address;
            objReturn.Email = user.Email;            
            return objReturn;
        }

        public static User Convert(UserDTO user)
        {
            User objReturn = new User();
            objReturn.Id = user.Id;
            objReturn.Name = user.Name;
            objReturn.LastName = user.LastName;
            objReturn.NUI = user.NUI;
            objReturn.Phone = user.Phone;
            objReturn.Address = user.Address;
            objReturn.Email = user.Email;
            return objReturn;
        }
    }


}
