using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Access;
using VO.Entities;
using VO.ExceptionHandler;
using VO.Interfaces.BLL;

namespace Bll
{
    /// <summary>
    /// clase de negocio para clientes
    /// </summary>
    [PrintException(typeof(Exception))]
    public class Client : IClients
    {
        public DAOContainer DAO { get; set; }

        
        public List<ClientUser> List(string word)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// crea un nuevo cliente
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ClientUser Create(ClientUser entity)
        {
            VO.Entities.ClientUser data = null;
            data = DAO.Resolve<ClientsDAO>().Create(entity);
            return data;
        }


        /// <summary>
        /// actualiza un cliente
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ClientUser Update(ClientUser entity)
        {
            VO.Entities.ClientUser data = null;
            data = DAO.Resolve<ClientsDAO>().Update(entity);
            return data;
        }

        /// <summary>
        /// elimina un cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ClientUser Delete(int id)
        {
            VO.Entities.ClientUser data = DAO.Resolve<ClientsDAO>().Get(id);
            DAO.Resolve<ClientsDAO>().Delete(data);
            return data;
        }

        /// <summary>
        /// obtiene un cliente por su id de usuario
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public ClientUser Get(int userId)
        {
            return DAO.Resolve<ClientsDAO>().Get(userId);
        }
    }
}
