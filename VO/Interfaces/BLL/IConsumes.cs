using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO.Entities;
using VO.Interfaces.General;

namespace VO.Interfaces.BLL
{
    public interface IConsumes : IPersistent<Consumes>,
        IDeleteableResult<Consumes>
    {
        List<Consumes> GetConsumesByUserId(int UserId);

        Consumes Call(int userId, decimal seconds);
    }
}
