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
    /// Clase de acceso a datos para recargas
    /// </summary>
    [PrintException(typeof(Exception))]
    public class RechargesDAO : Repository<Recharges>, IRechargesDAO
    {
        /// <summary>
        /// busqueda generica de recargas a travez de una expresion lambda
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public List<Recharges> Search(System.Linq.Expressions.Expression<Func<Recharges, bool>> whereExpression, int page = 1, int size = 10, string[] includes = null)
        {
            return base.Search(whereExpression);
        }

        /// <summary>
        /// crea una recarga
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Recharges Create(Recharges entity)
        {
            return base.Create(entity);
        }

        /// <summary>
        /// Actualiza una recarga
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Recharges Update(Recharges entity)
        {
            return base.Update(entity);
        }

        /// <summary>
        /// elimina una recarga
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(Recharges entity)
        {
            base.Delete(entity);
        }

        /// <summary>
        /// obtiene una recarga
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Recharges Get(int id)
        {
            return base.Find(id);
        }

        /// <summary>
        /// obtiene las recargas de un usuario determinado
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Recharges> GetRechargesByUserId(int userId)
        {
            List<Recharges> info = null;
            using (DAO.Context.Context context = new DAO.Context.Context())
            {
                info = context.Recharges.Where(x => x.UserId == userId).ToList();
            }
            return info;
        }
    }
}
