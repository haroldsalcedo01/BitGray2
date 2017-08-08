using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO.Entities;
using VO.Interfaces.General;

namespace VO.Interfaces.DAO
{
    public interface IClientsDAO : IPersistentEntity<ClientUser>,
        IDeletableEntity<ClientUser>,
        ISearchableDAO<ClientUser>
    {
        ClientUser Get(int userId);
    }
}
