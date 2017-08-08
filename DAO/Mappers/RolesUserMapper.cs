using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO.Entities;

namespace DAO.Mappers
{
    /// <summary>
    /// mapeador de roles x usuario
    /// </summary>
    public class RolesUserMapper : EntityTypeConfiguration<RolesUser>
    {
        private string Schema;

        public RolesUserMapper(string Schema)
        {
            // TODO: Complete member initialization
            this.Schema = Schema;

            this.ToTable("RolesUser", this.Schema);

            this.HasKey(e => e.Id)
               .Property(e => e.Id)
               .HasColumnName("Id")
               .HasColumnType("INT")
               .IsRequired();

            this.Property(e => e.UserId)
             .HasColumnName("UserId")
             .IsRequired();

            this.Property(e => e.RoleId)
             .HasColumnName("RoleId")
             .IsRequired();



        }
    }
}
