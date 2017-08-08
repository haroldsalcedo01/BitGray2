using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO.Entities;
using VO.Interfaces.General;

namespace VO.Interfaces.BLL
{
    public interface IRolesUsers : IPersistent<RolesUser>,
        IDeleteableResult<RolesUser>
    {
        List<RolesUser> GetRolesByUserId(int userId);
    }
}
