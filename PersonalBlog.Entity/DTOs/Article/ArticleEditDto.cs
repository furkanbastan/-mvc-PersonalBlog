using PersonalBlog.Entity.DTOs.Category;

namespace PersonalBlog.Entity.DTOs.Article;

public class ArticleEditDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public List<Guid> SelectedCategoryList { get; set; } = new();
    public List<CategoryDto> CategoryList { get; set; }
}
