using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO.Entities;

namespace DAO.Mappers
{
    /// <summary>
    /// mapeador de usuarios
    /// </summary>
    public class UserMapper : EntityTypeConfiguration<User>
    {
        private string Schema;

        public UserMapper(string Schema)
        {
   
            this.Schema = Schema;

            this.ToTable("Users", this.Schema);

            this.HasKey(e => e.Id)
             .Property(e => e.Id)
             .HasColumnName("Id")
             .HasColumnType("INT")
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
             .IsRequired();

            this.Property(e => e.UserName)
               .HasColumnName("UserName")
               .IsRequired();

            this.Property(e => e.NUI)
               .HasColumnName("NUI")
               .IsRequired();           

            this.Property(e => e.LastName)
               .HasColumnName("LastName")
               .IsRequired();

            this.Property(e => e.Name)
               .HasColumnName("Name")
               .IsRequired();

            this.Property(e => e.Phone)
               .HasColumnName("Phone")
               .IsRequired();

            this.Property(e => e.Address)
               .HasColumnName("Address")
               .IsRequired();

            this.Property(e => e.Email)
               .HasColumnName("Email")
               .IsRequired();

            this.Property(e => e.Password)
               .HasColumnName("Password")
               .IsRequired();

            this.Property(e => e.IsActive)
               .HasColumnName("IsActive")
               .IsRequired();
        }
    }
}
