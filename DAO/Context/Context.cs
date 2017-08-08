using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Mappers;
using Microsoft.Practices.Unity;
using VO.Entities;

namespace DAO.Context
{
    public class Context : DbContext
    {
        private string Schema { get; set; }

        #region Constructor
        #region Constructores
        static Context()
        {
            Database.SetInitializer<Context>(null);
        }

        public Context()
            : base("Name=PC_Conn")
        { }
        #endregion
  
     
        #endregion

        #region Prop
        public virtual DbSet<ClientUser> ClientUser { get; set; }
        public virtual DbSet<Consumes> Consumes { get; set; }
        public virtual DbSet<Recharges> Recharges { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolesUser> RolesUser { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<User> User { get; set; }
        #endregion

        
        #region Mapping Configuration
          protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            Database.SetInitializer<Context>(null);

            //Configurar las propiedades del contexto
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
            

             
            modelBuilder.Configurations.Add(new ClientUserMapper(Schema));
            modelBuilder.Configurations.Add(new ConsumesMapper(Schema));
            modelBuilder.Configurations.Add(new RechargesMapper(Schema));
            modelBuilder.Configurations.Add(new RolesMapper(Schema));
            modelBuilder.Configurations.Add(new RolesUserMapper(Schema));
            modelBuilder.Configurations.Add(new SettingsMapper(Schema));
            modelBuilder.Configurations.Add(new UserMapper(Schema));
            
        }
        #endregion


    }
}
