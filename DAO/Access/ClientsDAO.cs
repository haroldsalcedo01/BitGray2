using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VO.Entities;
using VO.ExceptionHandler;
using VO.Interfaces.DAO;

namespace DAO.Access
{
    /// <summary>
    /// clase de acceso a datos de los clientes
    /// </summary>
    [PrintException(typeof(Exception))]
    public class ClientsDAO : Repository<ClientUser>, IClientsDAO
    {

        /// <summary>
        /// Permite la creacion de un cliente
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ClientUser Create(ClientUser entity)
        {
            return base.Create(entity);
        }

        /// <summary>
        /// permite la actualizacion de un cliente
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ClientUser Update(ClientUser entity)
        {
            return base.Update(entity);
        }
        
        /// <summary>
        /// Permite la eliminacion de un cliente
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(ClientUser entity)
        {
            base.Delete(entity);
        }

        /// <summary>
        /// busqueda generica de clientes a travez de una expresion lambda recibida
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public List<ClientUser> Search(Expression<Func<ClientUser, bool>> whereExpression, int page, int size, string[] includes)
        {
            return base.Search(whereExpression);
        }

        /// <summary>
        /// obtiene un cliente a travez de su userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public ClientUser Get(int userId)
        {

            ClientUser info = null;
            using (DAO.Context.Context context = new DAO.Context.Context())
            {
                info = context.ClientUser.FirstOrDefault(x => x.UserId == userId);
            }
            return info;
        }
    }
}
