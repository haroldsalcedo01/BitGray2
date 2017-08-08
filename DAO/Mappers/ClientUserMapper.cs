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
    /// mapeador de cliente
    /// </summary>
    public class ClientUserMapper : EntityTypeConfiguration<ClientUser>
    {
        private string Schema;

        public ClientUserMapper(string Schema)
        {
            // TODO: Complete member initialization
            this.Schema = Schema;

            this.ToTable("Clients", this.Schema);

            this.HasKey(e => e.Id)
      .Property(e => e.Id)
      .HasColumnName("Id")
      .HasColumnType("INT")
      .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
      .IsRequired();


            this.Property(e => e.UserId)
               .HasColumnName("UserId")
               .IsRequired();

           

            this.Property(e => e.Balance)
               .HasColumnName("Balance")
               .IsRequired();



        }
    }
}
