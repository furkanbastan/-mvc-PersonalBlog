using PersonalBlog.Entity.Entities.Common;

namespace PersonalBlog.Entity.Entities;

public class Category : EntityBase
{
    public string Name { get; set; }
    public ICollection<ArticleCategory> Articles { get; set; } = new HashSet<ArticleCategory>();
}
