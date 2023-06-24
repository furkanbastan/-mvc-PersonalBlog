using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PersonalBlog.Data.Contexts;
using PersonalBlog.Entity.DTOs.Article;
using PersonalBlog.Entity.Entities;
using PersonalBlog.Service.Services.Abstractions;

namespace PersonalBlog.Service.Services.Concrete;

public class ArticleService : IArticleService
{
    private readonly IMapper _mapper;
    private readonly PersonalBlogDbContext _context;
    private readonly ICategoryService _categoryService;
    public ArticleService(PersonalBlogDbContext context, IMapper mapper, ICategoryService categoryService)
    {
        _context = context;
        _mapper = mapper;
        _categoryService = categoryService;
    }

    public async Task<ArticleListDto> GetArticlesWithPagination()
    {
        //Pagination Yapılacak
        var articles = await _context.Articles
            .Include(a => a.User)
            .Include(a => a.Categories)
            .ThenInclude(a => a.Category)
            .ToListAsync();
        var map = _mapper.Map<List<ArticleDto>>(articles);
        var articleListDto = new ArticleListDto{Articles = map};
        return articleListDto;
    }
    public async Task<ArticleListDto> GetArticlesArchiveWithPagination()
    {
        //Pagination Yapılacak
        var articles = await _context.Articles.ToListAsync();
        var map = _mapper.Map<List<ArticleDto>>(articles);
        var articleListDto = new ArticleListDto{Articles = map};
        return articleListDto;
    }
    public async Task<ArticleDto> GetArticleDetailWithComments(Guid id)
    {
        var article = await _context.Articles
            .Include(a => a.Comments)
            .Include(a => a.User)
            .Include(a => a.Categories)
            .ThenInclude(a => a.Category)
            .Where(a => a.Id == id)
            .FirstOrDefaultAsync();
        var map = _mapper.Map<ArticleDto>(article);
        return map;
    }
    public async Task<ArticleDto> GetArticleDetailWithCategory(Guid id)
    {
        var article = await _context.Articles
            .Include(a => a.Categories)
            .ThenInclude(a => a.Category)
            .Where(a => a.Id == id)
            .FirstOrDefaultAsync();
        var map = _mapper.Map<ArticleDto>(article);
        return map;
    }
    public async Task EditArticle(ArticleEditDto articleEditDto)
    {
        var articleCategories = await _context.ArticleCategories.Include(a => a.Article).Where(a => a.ArticleId == articleEditDto.Id).ToListAsync();
        _context.RemoveRange(articleCategories);

        var article = await _context.Articles.FirstOrDefaultAsync(a => a.Id == articleEditDto.Id);
        _mapper.Map(articleEditDto, article);

        articleEditDto.SelectedCategoryList.ForEach(id => article.Categories.Add(new ArticleCategory{ArticleId = article.Id, CategoryId = id}));

        await Task.Run(() => _context.Update(article));
        await _context.SaveChangesAsync();
    }
    public async Task<ArticleEditDto> GetArticleEditDto(Guid id)
    {
        var article = await _context.Articles
            .Include(a => a.Categories)
            .ThenInclude(x => x.Category)
            .Where(a => a.Id == id)
            .FirstOrDefaultAsync();
        var map = _mapper.Map<ArticleEditDto>(article);
        
        foreach (var category in article.Categories) map.SelectedCategoryList.Add(category.CategoryId);

        map.CategoryList = await _categoryService.GetCategories();

        return map;
    }
    public async Task<ArticleCreateDto> GetArticleCreateDto()
    {
        return new ArticleCreateDto{CategoryList = await _categoryService.GetCategories()};
    }
    public async Task<List<ArticleDto>> GetArticlesByCategory(Guid id)
    {
        var articles = await _context.Articles
            .Include(a => a.Categories)
            .ThenInclude(a => a.Category)
            .ToListAsync();

        var articlesByCategory = new List<Article>();
        articles.ForEach(a => 
        {
            if(a.Categories.Where(x => x.CategoryId == id).Any())
                articlesByCategory.Add(a);
        });

        var map =  _mapper.Map<List<ArticleDto>>(articlesByCategory);
        return map;
    }
    public async Task CreateArticle(ArticleCreateDto articleCreateDto)
    {
        var map = _mapper.Map<Article>(articleCreateDto);
        articleCreateDto.SelectedCategoryList.ForEach(id => map.Categories.Add(new ArticleCategory{ArticleId = map.Id, CategoryId = id}));

        await _context.AddAsync(map);
        await _context.SaveChangesAsync();
    }
    
    public async Task DeleteArticle(Guid id)
    {
        var articleCategories = await _context.ArticleCategories.Where(x => x.ArticleId == id).ToListAsync();
        _context.RemoveRange(articleCategories);

        var article = await _context.Articles.FindAsync(id);
        _context.Remove(article);

        await _context.SaveChangesAsync();
    }
}

//Önemli
//Not ThenInculude kullanmak yerine şunu kullan önce cross table da ki verileri Include ile getir sonra principal table daki crosstable navigationı Inculude ile getir.
//Silme operasyonlarında önce bağımlı(dependent) nesnenin elemanlarını silmelisin
//Ekleme işlemlerinde zaten 