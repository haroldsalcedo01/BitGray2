using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll;
using DAO.Access;
using Microsoft.Practices.Unity;
using VO.Interfaces.BLL;

namespace Bll
{
    public static class Factory
    {
        public static IUsers Users { get { return Builder.Instance.Resolve<IUsers>(); } }
        public static IClients Client { get { return Builder.Instance.Resolve<IClients>(); } }
        public static IRecharges Recharges { get { return Builder.Instance.Resolve<IRecharges>(); } }
        public static IConsumes Consumes { get { return Builder.Instance.Resolve<IConsumes>(); } }


        public class Builder : UnityContainerExtension
        {
            #region Singleton Pattern

            /// <summary>
            /// Objeto para hacer operaciones de singleton
            /// </summary>
            private static readonly object Sync = new object();

            /// <summary>
            /// Instancia
            /// </summary>
            private static volatile Builder instance;

            /// <summary>
            /// Constuctor
            /// </summary>
            private Builder()
            {
            }

            /// <summary>
            /// Referencia a la única instancia
            /// </summary>
            public static Builder Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (Sync)
                        {
                            if (instance == null)
                            {
                                instance = new Builder();
                            }
                        }
                    }

                    return instance;
                }
            }

            #endregion

            /// <summary>
            ///
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <returns></returns>
            public T Resolve<T>()
            {
                return Container.Resolve<T>();
            }

            /// <summary>
            /// Inicializa el componente
            /// </summary>
            protected override void Initialize()
            {
                //se referencia el data access y se registra
                Container.AddExtension(DAOContainer.Builder.Instance);

                //resuelve las propiedades que tenga en la business con el nombre que le indique
                InjectionProperty daoProperty = new InjectionProperty("DAO");

            
                InjectionMember[] parameters = { daoProperty };

               
                Container.RegisterType<IUsers, Users>(parameters);
                Container.RegisterType<IClients, Client>(parameters);
                Container.RegisterType<IRoles, Roles>(parameters);
                Container.RegisterType<IRolesUsers, RolesUsers>(parameters);
                Container.RegisterType<IConsumes, Consumes>(parameters);
                Container.RegisterType<IRecharges, Recharges>(parameters);
                Container.RegisterType<ISettings, Settings>(parameters);

            }
        }
    }
}
