using PersonalBlog.Entity.DTOs.Comment;
using PersonalBlog.Entity.Entities.Identity;

namespace PersonalBlog.Entity.DTOs.Article;

public class ArticleDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedDate { get; set; }
    public AppUser User { get; set; }
    public Guid UserId { get; set; }
    public ICollection<ArticleCategoryDto> Categories { get; set; }
    public List<Guid> CategoryId { get; set; }
    public ICollection<CommentListDto> Comments { get; set; } = new HashSet<CommentListDto>();
}
