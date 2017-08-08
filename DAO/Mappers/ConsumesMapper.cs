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
    /// mapeador de consumos
    /// </summary>
    public class ConsumesMapper : EntityTypeConfiguration<Consumes>
    {
        private string Schema;

        public ConsumesMapper(string Schema)
        {
            // TODO: Complete member initialization
            this.Schema = Schema;

            this.ToTable("Consumes", this.Schema);


            this.HasKey(e => e.Id)
             .Property(e => e.Id)
             .HasColumnName("Id")
             .HasColumnType("INT")
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
             .IsRequired();


            this.Property(e => e.UserId)
               .HasColumnName("UserId")
               .IsRequired();


            this.Property(e => e.Time)
               .HasColumnName("Time")
               .IsRequired();

            this.Property(e => e.DateCall)
                .HasColumnName("DateCall")
                .IsRequired();

            this.Property(e => e.ValueCall)
                .HasColumnName("ValueCall")
                .IsRequired();
        }
    }
}
