using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entity.Entities.Identity;

namespace PersonalBlog.Data.Mappings;

public class AppUserRoleMap : IEntityTypeConfiguration<AppUserRole>
{
    public void Configure(EntityTypeBuilder<AppUserRole> builder)
    {
        builder.HasKey(r => new { r.UserId, r.RoleId });

        builder.ToTable("AspNetUserRoles");

        builder.HasData(new AppUserRole
        {
            UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
            RoleId = Guid.Parse("16EA936C-7A28-4C30-86A2-9A9704B6115E")
        });
    }
}
