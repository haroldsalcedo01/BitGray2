using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO.Entities;
using VO.Interfaces.General;

namespace VO.Interfaces.DAO
{
    public interface IRechargesDAO : IPersistentEntity<Recharges>,
        IDeletableEntity<Recharges>,
        ISearchableDAO<Recharges>
    {
        Recharges Get(int id);
    }
}
