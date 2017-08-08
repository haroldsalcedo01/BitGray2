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
    /// clase de configuraciones en base de datos
    /// </summary>
    [PrintException(typeof(Exception))]
    public class SettingsDAO : Repository<Settings>, ISettingsDAO
    {
        /// <summary>
        /// crea un nuevo registro de configuracion
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Settings Create(Settings entity)
        {
            return base.Create(entity);
        }

        /// <summary>
        /// actualiza un registro de configuracion
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Settings Update(Settings entity)
        {
            return base.Update(entity);
        }

        /// <summary>
        /// elimina un registro de configuracion
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(Settings entity)
        {
            base.Delete(entity);
        }

        /// <summary>
        /// busca n la tabla de configuraiones atravez de una expresion lambda
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public List<Settings> Search(System.Linq.Expressions.Expression<Func<Settings, bool>> whereExpression, int page, int size, string[] includes)
        {
            return base.Search(whereExpression);
        }

        /// <summary>
        /// obtiene un registro de configuracion atravez de su llave primaria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Settings Get(int id)
        {
            return base.Find(id);
        }

        /// <summary>
        /// obtiene un registro de configuracion atravez del key de la tabla
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Settings GetByKey(string key)
        {
            try
            {
                System.Linq.Expressions.Expression<Func<Settings, bool>> whereExpression = (x => x.Key == key);
                return base.Search(whereExpression).FirstOrDefault();
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
        }
    }
}
