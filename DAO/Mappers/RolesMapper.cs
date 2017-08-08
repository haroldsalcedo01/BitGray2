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
    /// mapeador de roles
    /// </summary>
    public class RolesMapper : EntityTypeConfiguration<Roles>
    {
        private string Schema;

        public RolesMapper(string Schema)
        {
            // TODO: Complete member initialization
            this.Schema = Schema;

            this.ToTable("Roles", this.Schema);


            this.HasKey(e => e.Id)
             .Property(e => e.Id)
             .HasColumnName("Id")
             .HasColumnType("INT")
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
             .IsRequired();


            this.Property(e => e.Name)
               .HasColumnName("Name")
               .IsRequired();


        }
    }
}
