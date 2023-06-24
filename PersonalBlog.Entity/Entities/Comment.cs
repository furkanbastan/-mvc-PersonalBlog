using PersonalBlog.Entity.Entities.Common;

namespace PersonalBlog.Entity.Entities;

public class Comment : EntityBase
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Content { get; set; }
    public bool IsApprove { get; set; } = false;
    public Guid ArticleId { get; set; }
    public Article Article { get; set; }
    public Guid? ParentCommentId { get; set; }
    public Comment ParentComment { get; set; }
    public ICollection<Comment> ChildComments { get; set; }
}
