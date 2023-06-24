using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entity.Entities;

namespace PersonalBlog.Data.Mappings;

public class ImageMap : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.HasData(new Image
        {
            Id = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
            FileName = "DenemePfoto",
            FileType = "PNG"
        }
        );
    }
}
