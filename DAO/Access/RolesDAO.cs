using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO.Entities;
using VO.ExceptionHandler;
using VO.Interfaces.DAO;

namespace DAO.Access
{
    /// <summary>
    /// clase de acceso a datos de los roles
    /// </summary>
    [PrintException(typeof(Exception))]
    public class RolesDAO : Repository<Roles>, IRolesDAO
    {
        /// <summary>
        /// obtiene un rol a travez de su llave primaria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Roles Get(int id)
        {
            return base.Find(id);
        }

        /// <summary>
        /// busqueda generica de roles a travez de una expresion lambda
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public List<Roles> Search(System.Linq.Expressions.Expression<Func<Roles, bool>> whereExpression, int page = 1, int size = 10, string[] includes = null)
        {
            return base.Search(whereExpression);
        }             

        /// <summary>
        /// creacion de un rol
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Roles Create(Roles entity)
        {
            return base.Create(entity);
        }

        /// <summary>
        /// actualizacion de un rol
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Roles Update(Roles entity)
        {
            return base.Update(entity);
        }

        /// <summary>
        /// eliminacion de un rol
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(Roles entity)
        {
            base.Delete(entity);
        }

        
    }
}
