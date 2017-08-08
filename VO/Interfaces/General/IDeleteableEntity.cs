using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO.Interfaces.General
{
    public interface IDeletableEntity<TEntity>
    {
        void Delete(TEntity entity);
    }
}
