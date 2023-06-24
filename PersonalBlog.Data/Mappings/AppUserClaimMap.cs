using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entity.Entities.Identity;

namespace PersonalBlog.Data.Mappings;

public class AppUserClaimMap : IEntityTypeConfiguration<AppUserClaim>
{
    public void Configure(EntityTypeBuilder<AppUserClaim> builder)
    {
        builder.HasKey(uc => uc.Id);
        builder.ToTable("AspNetUserClaims");
    }
}
