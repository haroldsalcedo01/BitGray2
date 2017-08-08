using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO.Interfaces.General
{
    /// <summary>
    /// generalizador para la creacion y actualizacion de entidades
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IPersistentEntity<TEntity> where TEntity : class, new()
    {
        
        TEntity Create(TEntity entity);

        
        TEntity Update(TEntity entity);        
        
    }
}
