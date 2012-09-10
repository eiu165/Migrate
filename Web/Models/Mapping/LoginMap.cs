using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Web.Models.Mapping
{
    public class LoginMap : EntityTypeConfiguration<Login>
    {
        public LoginMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.UserName, t.Email, t.DateCreated });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .IsRequired();

            this.Property(t => t.IpAddress)
                .HasMaxLength(50);

            this.Property(t => t.SessionId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Logins");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.FailedAttempts).HasColumnName("FailedAttempts");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.IpAddress).HasColumnName("IpAddress");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
        }
    }
}
