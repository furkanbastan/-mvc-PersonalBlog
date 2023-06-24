using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entity.Entities;

namespace PersonalBlog.Data.Mappings;

public class CommentMap : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasData(
            new Comment
            {
                Name = "Efe",
                Email = "efeovic@gmail.com",
                Content = "Ben bu makaleyi çok beğendim ve beni çok geliştirsi gerçekten çok teşekkürler sağlıcakla kalın Furkan Bey.",
                ArticleId = Guid.Parse("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"),
                Id = Guid.Parse("142759af-50fb-424e-b4a4-baf6c318da94")
            },
            new Comment
            {
                Name = "Furkan",
                Email = "efeovic@gmail.com",
                Content = "Ben bu makaleyi çok beğendim ve beni çok geliştirsi gerçekten çok teşekkürler sağlıcakla kalın Furkan Bey.",
                ArticleId = Guid.Parse("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"),
                Id = Guid.Parse("ab5e18ab-268b-4409-8fe2-dd6d6a85d420"),
                ParentCommentId = Guid.Parse("142759af-50fb-424e-b4a4-baf6c318da94")
            },
            new Comment
            {
                Name = "Engin",
                Email = "efeovic@gmail.com",
                Content = "Ben bu makaleyi çok beğendim ve beni çok geliştirsi gerçekten çok teşekkürler sağlıcakla kalın Furkan Bey.",
                ArticleId = Guid.Parse("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"),
                Id = Guid.Parse("adc2196a-e77f-4d49-9285-3c50935e957d"),
                ParentCommentId = Guid.Parse("ab5e18ab-268b-4409-8fe2-dd6d6a85d420")
            },
            new Comment
            {
                Name = "Emirhan",
                Email = "efeovic@gmail.com",
                Content = "Ben bu makaleyi çok beğendim ve beni çok geliştirsi gerçekten çok teşekkürler sağlıcakla kalın Furkan Bey.",
                ArticleId = Guid.Parse("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"),
                Id = Guid.Parse("8966fde2-9198-461a-bb67-29a661cfced0"),
                ParentCommentId = Guid.Parse("adc2196a-e77f-4d49-9285-3c50935e957d")
            }
        );
    }
}
