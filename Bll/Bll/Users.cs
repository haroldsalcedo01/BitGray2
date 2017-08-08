using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAO.Access;
using VO.ExceptionHandler;
using VO.Interfaces.BLL;
using VO.Utils;

namespace Bll
{
    [PrintException(typeof(Exception))]
    public class Users : IUsers
    {
        public DAOContainer DAO { get; set; }

        /// <summary>
        /// lista todos los usuarios que concuerden con una palabra
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public List<VO.Entities.User> List(string word)
        {
            List<VO.Entities.User> users = new List<VO.Entities.User>();
            Expression<Func<VO.Entities.User, bool>> whereExpression = (x => x.IsActive == true);
            if (!string.IsNullOrWhiteSpace(word))
            {
                whereExpression = (x => (x.Name.Contains(word) || x.LastName.Contains(word)) && x.IsActive == true);
            }

            users = DAO.Resolve<UserDAO>().Search(whereExpression);
            return users;
        }

        /// <summary>
        /// Logea un usuario en la aplicacion
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public VO.DTO.UserDTO LogIn(string userName, string Password)
        {

            VO.Entities.User data = null;
            string hash = Encryptor.HashPassword(Password);
            Expression<Func<VO.Entities.User, bool>> whereExpression = (x => x.UserName.ToUpper() == userName.ToUpper() && x.Password == hash);
            data = DAO.Resolve<UserDAO>().Search(whereExpression).FirstOrDefault();
            VO.DTO.UserDTO user = VO.DTO.UserDTO.Convert(data);
            List<VO.Entities.RolesUser> rolesUser = DAO.Resolve<RolesUsers>().GetRolesByUserId(user.Id);
            List<VO.Entities.Roles> roles = DAO.Resolve<Roles>().GetAllRoles();
            if (rolesUser != null && rolesUser.Count > 0)
            {
                if (rolesUser.Any(x => x.RoleId == roles.Single(y => y.Name == "Cliente").Id))
                {
                    user.Type = "Client";
                }
                if (rolesUser.Any(x => x.RoleId == roles.Single(y => y.Name == "Empleado").Id))
                {
                    user.Type = "Employe";
                }

            }
            else
            {
                user.Type = "Employe";
            }

            return user;
        }

        /// <summary>
        /// crea un nuevo usuario
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public VO.Entities.User Create(VO.Entities.User entity)
        {
            VO.Entities.User data = null;
            try
            {
                if (entity != null && !string.IsNullOrWhiteSpace(entity.Name))
                {
                    data = DAO.Resolve<UserDAO>().Read(entity.Phone);
                    if (data == null)
                    {
                        entity.Password = Encryptor.HashPassword(entity.Password);
                        data = DAO.Resolve<UserDAO>().Create(entity);
                    }
                    else
                    {
                        throw new ArgumentException("Usuario duplicado");
                    }

                }
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return data;
        }

        /// <summary>
        /// actualiza un usuario
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public VO.Entities.User Update(VO.Entities.User entity)
        {
            VO.Entities.User data = null;
            data = DAO.Resolve<UserDAO>().Update(entity);
            return data;
        }

        /// <summary>
        /// elimina un usurios
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VO.Entities.User Delete(int id)
        {
            VO.Entities.User data = DAO.Resolve<UserDAO>().Get(id);
            DAO.Resolve<UserDAO>().Delete(data);
            return data;
        }

        /// <summary>
        /// crea un usuario cliente
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public VO.Entities.User CreateClient(VO.Entities.User user)
        {
            VO.Entities.User client = this.Create(user);
            DAO.Resolve<ClientsDAO>().Create(new VO.Entities.ClientUser() { UserId = client.Id, Balance = 0M });
            List<VO.Entities.Roles> roles = DAO.Resolve<Roles>().GetAllRoles();
            List<VO.Entities.RolesUser> rolesUser = new List<VO.Entities.RolesUser>();
            VO.Entities.RolesUser roleClient = new VO.Entities.RolesUser() { UserId = client.Id, RoleId = roles.Single(x => x.Name == "Cliente").Id };
            DAO.Resolve<RolesUserDAO>().Create(roleClient);
            return client;
        }

        /// <summary>
        /// obtiene un usuario atravez de su id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public VO.DTO.UserDTO Get(int userId)
        {
            return VO.DTO.UserDTO.Convert(DAO.Resolve<UserDAO>().Get(userId));
        }
    }
}
