using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Web.Models.Mapping
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.UpdatedAt });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Summary)
                .HasMaxLength(100);

            this.Property(t => t.Level)
                .HasMaxLength(16);

            this.Property(t => t.Logger)
                .HasMaxLength(128);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.IpAddress)
                .HasMaxLength(100);

            this.Property(t => t.Browser)
                .HasMaxLength(100);

            this.Property(t => t.Server)
                .HasMaxLength(100);

            this.Property(t => t.Session)
                .HasMaxLength(100);

            this.Property(t => t.UserName)
                .HasMaxLength(100);

            this.Property(t => t.Application)
                .HasMaxLength(100);

            this.Property(t => t.Type)
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Log");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.Logger).HasColumnName("Logger");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IpAddress).HasColumnName("IpAddress");
            this.Property(t => t.Browser).HasColumnName("Browser");
            this.Property(t => t.Server).HasColumnName("Server");
            this.Property(t => t.Session).HasColumnName("Session");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Application).HasColumnName("Application");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Layout).HasColumnName("Layout");
            this.Property(t => t.UpdatedAt).HasColumnName("UpdatedAt");
        }
    }
}
