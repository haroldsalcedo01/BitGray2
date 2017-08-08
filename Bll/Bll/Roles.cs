using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Access;
using VO.Interfaces.BLL;
using System.Linq.Expressions;
using VO.ExceptionHandler;

namespace Bll
{
    /// <summary>
    /// clase encargade de los roles 
    /// </summary>
    [PrintException(typeof(Exception))]
    public class Roles : IRoles
    {
        public DAOContainer DAO { get; set; }

        /// <summary>
        /// crea un nuevo rol
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public VO.Entities.Roles Create(VO.Entities.Roles entity)
        {
            VO.Entities.Roles data = null;
            data = DAO.Resolve<RolesDAO>().Create(entity);
            return data;
        }

        /// <summary>
        /// actualiza un rol
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public VO.Entities.Roles Update(VO.Entities.Roles entity)
        {
            VO.Entities.Roles data = null;
            data = DAO.Resolve<RolesDAO>().Create(entity);
            return data;
        }

        /// <summary>
        /// elimina un rol
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VO.Entities.Roles Delete(int id)
        {
            VO.Entities.Roles data = DAO.Resolve<RolesDAO>().Get(id);
            DAO.Resolve<RolesDAO>().Delete(data);
            return data;
        }

        /// <summary>
        /// obtiene todos los roles disponibles
        /// </summary>
        /// <returns></returns>
        public List<VO.Entities.Roles> GetAllRoles()
        {
            List<VO.Entities.Roles> roles = null;

            Expression<Func<VO.Entities.Roles, bool>> whereExpression = (x => x.Id > 0);
            roles = DAO.Resolve<RolesDAO>().Search(whereExpression);
            return roles;       
        }
    }
}
