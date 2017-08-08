using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO.DTO;
using VO.Entities;
using VO.Interfaces.General;

namespace VO.Interfaces.BLL
{
    public interface IUsers : IPersistent<User>,
        IDeleteableResult<User>
    {
        List<User> List(string word);
        UserDTO LogIn(string userName, string Password);
        User CreateClient(User user);
        UserDTO Get(int userId);
    }
}
