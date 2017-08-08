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
    /// mapeador de configuraciones
    /// </summary>
    public class SettingsMapper : EntityTypeConfiguration<Settings>
    {
        private string Schema;

        public SettingsMapper(string Schema)
        {
            // TODO: Complete member initialization
            this.Schema = Schema;

            this.ToTable("Settings", this.Schema);

            this.HasKey(e => e.Id)
             .Property(e => e.Id)
             .HasColumnName("Sett_Id")
             .HasColumnType("INT")
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
             .IsRequired();

            this.Property(e => e.Key)
               .HasColumnName("Sett_Key")
               .IsRequired();

            this.Property(e => e.Value)
               .HasColumnName("Sett_Value")
               .IsRequired();
        }
    }
}
