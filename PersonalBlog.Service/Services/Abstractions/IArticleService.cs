using PersonalBlog.Entity.DTOs.Article;

namespace PersonalBlog.Service.Services.Abstractions;

public interface IArticleService
{
    public Task<ArticleListDto> GetArticlesWithPagination();
    public Task<ArticleListDto> GetArticlesArchiveWithPagination();
    public Task<ArticleDto> GetArticleDetailWithComments(Guid id);
    public Task<ArticleDto> GetArticleDetailWithCategory(Guid id);
    public Task EditArticle(ArticleEditDto articleEditDto);
    public Task<List<ArticleDto>> GetArticlesByCategory(Guid id);
    public Task<ArticleEditDto> GetArticleEditDto(Guid id);
    public Task CreateArticle(ArticleCreateDto articleCreateDto);
    public Task DeleteArticle(Guid id);
    public Task<ArticleCreateDto> GetArticleCreateDto();
}
