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
    /// Clase de consumos
    /// </summary>
    [PrintException(typeof(Exception))]
    public class ConsumesDAO : Repository<Consumes>, IConsumesDAO
    {
        /// <summary>
        /// Busca los consumos a travez de una expresion lambda
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public List<Consumes> Search(System.Linq.Expressions.Expression<Func<Consumes, bool>> whereExpression, int page = 1, int size = 10, string[] includes = null)
        {
            return base.Search(whereExpression);
        }


        /// <summary>
        /// crea un consumo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Consumes Create(Consumes entity)
        {
            return base.Create(entity);
        }

        /// <summary>
        /// actualiza un consumo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Consumes Update(Consumes entity)
        {
            return base.Update(entity);
        }

        /// <summary>
        /// elimina un consumo
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(Consumes entity)
        {
            base.Delete(entity);
        }
        
        /// <summary>
        /// Obtiene un consumo a travez de su llave primaria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Consumes Get(int id)
        {
            return base.Find(id);
        }
    }
}
