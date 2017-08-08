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
    /// clase encargada de la asociacion de roles y usuarios en acceso a datos
    /// </summary>
    [PrintException(typeof(Exception))]
    public class RolesUserDAO : Repository<RolesUser>, IRolesUserDAO
    {
        /// <summary>
        /// busqueda atravez de una expresion lambda en los roles y usuarios
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public List<RolesUser> Search(System.Linq.Expressions.Expression<Func<RolesUser, bool>> whereExpression, int page = 1, int size = 10, string[] includes = null)
        {
            return base.Search(whereExpression);
        }

        /// <summary>
        /// creacion de rol por usuario
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public RolesUser Create(RolesUser entity)
        {
            return base.Create(entity);
        }

        /// <summary>
        /// actualizacion de rol por usurio
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public RolesUser Update(RolesUser entity)
        {
            return base.Update(entity);
        }

        /// <summary>
        /// eliminacion de rol por usuario
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(RolesUser entity)
        {
            base.Delete(entity);
        }

        /// <summary>
        /// obtiene un rol por usuario atravez de su llave primaria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RolesUser Get(int id)
        {
            return base.Find(id);
        }
    }
}
