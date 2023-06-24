using PersonalBlog.Entity.Entities.Common;

namespace PersonalBlog.Entity.Entities;

public class ArticleCategory : IEntityBase
{
    public Guid ArticleId { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public Article Article { get; set; }
}
