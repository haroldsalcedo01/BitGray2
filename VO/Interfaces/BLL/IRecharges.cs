using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO.Entities;
using VO.Interfaces.General;

namespace VO.Interfaces.BLL
{
    public interface IRecharges : IPersistent<Recharges>,
        IDeleteableResult<Recharges>
    {
        List<Recharges> GetRechargesByUserId(int userId);
        Recharges SimulateRecharge(int userId, decimal value);
        Recharges Recharge(int userId, decimal value);
    }
}
