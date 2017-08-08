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
    /// clase de configuraciones
    /// </summary>
    [PrintException(typeof(Exception))]
    public class Settings : ISettings
    {
        public DAOContainer DAO { get; set; }

        /// <summary>
        /// obtiene todas las configuraciones en base de datos
        /// </summary>
        /// <returns></returns>
        public List<VO.Entities.Settings> GetAllConfigurations()
        {
            List<VO.Entities.Settings> settings = null;

            Expression<Func<VO.Entities.Settings, bool>> whereExpression = (x => x.Id > 0);
            settings = DAO.Resolve<SettingsDAO>().Search(whereExpression);
            return settings;       
        }

        /// <summary>
        /// crea una nueva key de configuracion
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public VO.Entities.Settings Create(VO.Entities.Settings entity)
        {
            VO.Entities.Settings data = null;
            data = DAO.Resolve<SettingsDAO>().Create(entity);
            return data;
        }

        /// <summary>
        /// actualiza un key de configuracion
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public VO.Entities.Settings Update(VO.Entities.Settings entity)
        {
            VO.Entities.Settings data = null;
            data = DAO.Resolve<SettingsDAO>().Update(entity);
            return data;
        }

        /// <summary>
        /// elimina un key de configuracion
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VO.Entities.Settings Delete(int id)
        {
            VO.Entities.Settings data = DAO.Resolve<SettingsDAO>().Get(id);
            DAO.Resolve<SettingsDAO>().Delete(data);
            return data;
        }
    }
}
