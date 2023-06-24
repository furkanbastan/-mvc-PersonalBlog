using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entity.Entities;

namespace PersonalBlog.Data.Mappings;

public class ArticleCategoryMap : IEntityTypeConfiguration<ArticleCategory>
{
    public void Configure(EntityTypeBuilder<ArticleCategory> builder)
    {
        builder.HasKey(ac => new{ac.ArticleId, ac.CategoryId});
        builder.HasData(
            new ArticleCategory
            {
                ArticleId = Guid.Parse("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"),
                CategoryId = Guid.Parse("2e209a21-7bb2-43b1-a0c6-6e7d0c990db8")
            },new ArticleCategory
            {
                ArticleId = Guid.Parse("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"),
                CategoryId =Guid.Parse("0bd8b92f-d7bf-4dce-91c3-ac17f3b1b345")
            },new ArticleCategory
            {
                ArticleId = Guid.Parse("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"),
                CategoryId =Guid.Parse("49405eff-13c5-4558-a5f2-8b589b7e915c")
            },new ArticleCategory
            {
                ArticleId = Guid.Parse("6dd7b93d-d7bf-5bce-91c3-ac17f3b1b336"),
                CategoryId =Guid.Parse("49405eff-13c5-4558-a5f2-8b589b7e915c")
            },new ArticleCategory
            {
                ArticleId = Guid.Parse("6dd7b93d-d7bf-5bce-91c3-ac17f3b1b336"),
                CategoryId =Guid.Parse("62e6c2e9-e35c-4f4e-a4c2-4a70c7d06180")
            }
        );
    }
}
