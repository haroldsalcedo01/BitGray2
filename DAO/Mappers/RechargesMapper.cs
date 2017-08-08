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
    /// mapeador de recargas
    /// </summary>
    public class RechargesMapper : EntityTypeConfiguration<Recharges>
    {
        private string Schema;

        public RechargesMapper(string Schema)
        {
            // TODO: Complete member initialization
            this.Schema = Schema;

            this.ToTable("Recharges", this.Schema);


            this.HasKey(e => e.Id)
             .Property(e => e.Id)
             .HasColumnName("Id")
             .HasColumnType("INT")
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
             .IsRequired();

            this.Property(e => e.UserId)
               .HasColumnName("UserId")
               .IsRequired();

       
            this.Property(e => e.Value)
               .HasColumnName("Value")
               .IsRequired();

            this.Property(e => e.DateRecharge)
                .HasColumnName("DateRecharge")
                .IsRequired();

            this.Property(e => e.ApplyPromo)
                .HasColumnName("ApplyPromo")
                .IsRequired();

            this.Property(e => e.BondsValue)
                .HasColumnName("BondsValue")
                .IsRequired();

            this.Property(e => e.TotalRecharge)
                .HasColumnName("TotalRecharge")
                .IsRequired();

          
        }
    }
}
