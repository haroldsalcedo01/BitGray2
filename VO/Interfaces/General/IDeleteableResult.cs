using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO.Interfaces.General
{
    public interface IDeleteableResult<TEntity> where TEntity : class,new()
    {
        TEntity Delete(int id);
    }
}
