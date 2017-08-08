using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAO.Context;

namespace DAO.Access
{
    /// <summary>
    /// Clase base de administracion de contextos
    /// </summary>
    public abstract class RepositoryBase<TEntityType, TContextType>
        where TEntityType : class
        where TContextType : DbContext
    {
        /// <summary>
        /// Crear el contexto 
        /// </summary>
        /// <returns></returns>
        protected abstract TContextType CreateContext();

        /// <summary>
        /// Crea una entidad en el contexto
        /// </summary>
        /// <param name="record">Entidad a crear</param>
        /// <returns>Entidad creado</returns>
        public virtual TEntityType Create(TEntityType record)
        {
            using (TContextType context = CreateContext())
            {
                context.Entry(record).State = EntityState.Added;
                context.SaveChanges();

         
            }
            return record;
        }

        /// <summary>
        /// Crea una lista de entidades en el contexto
        /// </summary>
        /// <param name="list">Entidad a crear</param>
        /// <returns>Entidad creado</returns>
        public virtual List<TEntityType> Create(List<TEntityType> list)
        {
            using (TContextType context = CreateContext())
            {
                foreach (TEntityType record in list)
                {
                    context.Entry(record).State = EntityState.Added;
                }
                context.SaveChanges();
            }
            return list;
        }

        /// <summary>
        /// Busca una entidad por sus claves primarias
        /// </summary>
        /// <param name="keys">Claves primarias (en el mismo order que se esecifica en el mapper)</param>
        /// <returns>Entidad que coincide con los parametros de busqueda</returns>
        public virtual TEntityType Find(params object[] keys)
        {
            TEntityType record;
            using (TContextType context = CreateContext())
            {
                record = context.Set<TEntityType>().Find(keys);
            }
            return record;
        }

        /// <summary>
        /// Actualiza una entidad en el contexto
        /// </summary>
        /// <param name="record">Entidad a actualizar</param>
        /// <returns>Entidad actualizada</returns>
        public virtual TEntityType Update(TEntityType record)
        {
            using (TContextType context = CreateContext())
            {
                context.Entry(record).State = EntityState.Modified;
                context.SaveChanges();
            }
            return record;
        }

        /// <summary>
        /// Actualiza una lista de entidades
        /// </summary>
        /// <param name="list">Entidades a acualizar</param>
        /// <returns>Entidades actualizadas</returns>
        public virtual List<TEntityType> Update(List<TEntityType> list)
        {
            using (TContextType context = CreateContext())
            {
                foreach (TEntityType record in list)
                {
                    context.Entry(record).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
            return list;
        }

        /// <summary>
        /// Elimina una entidad del contexto
        /// </summary>
        /// <param name="record">Entidad a eliminar (no es necesario obtenerla previamente
        /// basta con establecer las propiedades que correspondan a las llaves primarias)</param>        
        public virtual void Delete(TEntityType record)
        {
            using (TContextType context = CreateContext())
            {
                context.Entry(record).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Elimina un listado de entidades del contexto
        /// </summary>
        /// <param name="list">Entidades a eliminar</param>        
        public virtual void Delete(IEnumerable<TEntityType> list)
        {
            using (TContextType context = CreateContext())
            {
                foreach (TEntityType record in list)
                {
                    context.Entry(record).State = EntityState.Deleted;
                }
                context.SaveChanges();
            }
        }

        public virtual List<TEntityType> Search(Expression<Func<TEntityType, bool>> whereExpression) 
        {
            List<TEntityType> info = null;
            using (TContextType context = CreateContext())
            {
                info = context.Set<TEntityType>().Where(whereExpression).ToList();
            }
            return info;
        }
    }


    /// <summary>
    /// Clase base del Acceso a datos del contexto
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Repository<T> : RepositoryBase<T, DAO.Context.Context>
       where T : class
    {
        /// <summary>
        /// Crear el contexto 
        /// </summary>
        /// <returns>Nuevo contexto</returns>
        protected override DAO.Context.Context CreateContext()
        {
            return new DAO.Context.Context();
        }
    }
}
