using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Web.Models.Mapping
{
    public class RoleMembershipMap : EntityTypeConfiguration<RoleMembership>
    {
        public RoleMembershipMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserName, t.RoleName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RoleMemberships");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.RoleName).HasColumnName("RoleName");

            // Relationships
            this.HasRequired(t => t.Role)
                .WithMany(t => t.RoleMemberships)
                .HasForeignKey(d => d.RoleName);
            this.HasRequired(t => t.User)
                .WithMany(t => t.RoleMemberships)
                .HasForeignKey(d => d.UserName);

        }
    }
}
