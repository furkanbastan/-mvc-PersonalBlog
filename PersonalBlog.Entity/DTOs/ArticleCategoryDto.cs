using PersonalBlog.Entity.DTOs.Article;
using PersonalBlog.Entity.DTOs.Category;

namespace PersonalBlog.Entity.DTOs;

public class ArticleCategoryDto
{
    public Guid ArticleId { get; set; }
    public ArticleDto Article { get; set; }
    public Guid CategoryId { get; set; }
    public CategoryDto Category { get; set; }
}
