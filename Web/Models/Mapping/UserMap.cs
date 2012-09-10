using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Web.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserName);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PasswordHash)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.PasswordSalt)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.Email)
                .IsRequired();

            this.Property(t => t.LastIpAddress)
                .HasMaxLength(50);

            this.Property(t => t.LastSessionId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.PasswordHash).HasColumnName("PasswordHash");
            this.Property(t => t.PasswordSalt).HasColumnName("PasswordSalt");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IsApproved).HasColumnName("IsApproved");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateLastLogin).HasColumnName("DateLastLogin");
            this.Property(t => t.DateLastActivity).HasColumnName("DateLastActivity");
            this.Property(t => t.DateLastPasswordChange).HasColumnName("DateLastPasswordChange");
            this.Property(t => t.LastIpAddress).HasColumnName("LastIpAddress");
            this.Property(t => t.LastSessionId).HasColumnName("LastSessionId");
        }
    }
}
