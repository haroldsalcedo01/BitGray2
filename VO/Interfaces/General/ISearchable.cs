using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO.Interfaces.General
{
    /// <summary>
    /// Generalizador de busquedas para capa de negocio
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface ISearchable<TEntity> where TEntity : class, new()
    {
        List<TEntity> List(string filter);
    }
}
