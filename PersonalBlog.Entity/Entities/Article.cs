using PersonalBlog.Entity.Entities.Common;
using PersonalBlog.Entity.Entities.Identity;

namespace PersonalBlog.Entity.Entities;

public class Article : EntityBase
{
    public string Title { get; set; }
    public string Content { get; set; }
    public AppUser User { get; set; }
    public Guid UserId { get; set; } =  Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427");
    public ICollection<ArticleCategory> Categories { get; set; } = new HashSet<ArticleCategory>();
    public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
}
