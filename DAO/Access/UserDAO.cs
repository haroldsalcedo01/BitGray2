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

    [PrintException(typeof(Exception))]
    public class UserDAO : Repository<User>, IUserDAO
    {
     
        /// <summary>
        /// obtiene un usuario atravez de su llave primaria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User Get(int id)
        {
            return base.Find(id);
        }

        /// <summary>
        /// crea un nuevo usuario
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public User Create(User entity)
        {
            return base.Create(entity);
        }

        /// <summary>
        /// actualiza un usuario
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public User Update(User entity)
        {
            return base.Update(entity); 
        }      

        /// <summary>
        /// busca en la tabla de usurios traves de una expresion lambda
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <returns></returns>
        public List<User> Search(Expression<Func<User, bool>> whereExpression)
        {
            return base.Search(whereExpression);
        }      

        /// <summary>
        /// elimina un usuario
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(User entity)
        {
            base.Delete(entity);
        }

        /// <summary>
        /// lee un usuario atravez de telefono (el telefono no se puede repetir)
        /// </summary>
        /// <param name="Phone"></param>
        /// <returns></returns>
        public User Read(string Phone)
        {
            User info = null;
            using (DAO.Context.Context context = new DAO.Context.Context())
            {
                info = context.User.FirstOrDefault(x => x.Phone == Phone);
            }
            return info;
        }

        
    }
}
