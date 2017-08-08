using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DAO.Access
{
    /// <summary>
    /// Clase contenedora
    /// </summary>
    public class DAOContainer
    {
        public T Resolve<T>()
        {
            return Builder.Instance.Resolve<T>();
        }


        /// <summary>
        /// Constructor de instancias
        /// </summary>
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
                InjectionMember[] parameters = { };               
                Container.RegisterType<UserDAO>();
                Container.RegisterType<ClientsDAO>();
                Container.RegisterType<ConsumesDAO>();
                Container.RegisterType<RechargesDAO>();
                Container.RegisterType<RolesDAO>();
                Container.RegisterType<RolesUserDAO>();
                Container.RegisterType<SettingsDAO>();

            }
        }
    }
}
