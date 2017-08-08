using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO.Interfaces.General
{
    /// <summary>
    /// Generalizador de persistencia en clases de negocio
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IPersistent<TEntity>
    {      
        TEntity Create(TEntity entity);
               
        TEntity Update(TEntity entity);
    }
}
