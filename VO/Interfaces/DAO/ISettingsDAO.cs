using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO.Entities;
using VO.Interfaces.General;

namespace VO.Interfaces.DAO
{
    public interface ISettingsDAO : IPersistentEntity<Settings>,
        IDeletableEntity<Settings>,
        ISearchableDAO<Settings>
    {
        Settings Get(int id);
    }
}
