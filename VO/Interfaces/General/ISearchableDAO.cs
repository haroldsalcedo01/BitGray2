using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VO.Interfaces.General
{
    /// <summary>
    /// Generalizador para la busqueda en entidades por expresiones
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface ISearchableDAO<TEntity> where TEntity : class, new()
    {
        List<TEntity> Search(Expression<Func<TEntity, bool>> whereExpression);
    }
}
