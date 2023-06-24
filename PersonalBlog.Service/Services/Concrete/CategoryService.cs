using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PersonalBlog.Data.Contexts;
using PersonalBlog.Data.Repositories;
using PersonalBlog.Entity.DTOs.Category;
using PersonalBlog.Entity.Entities;
using PersonalBlog.Service.Services.Abstractions;

namespace PersonalBlog.Service.Services.Concrete;

public class CategoryService : ICategoryService
{
    private readonly IMapper _mapper;
    private readonly IRepository<Category> _repository;
    private readonly PersonalBlogDbContext _context;
    public CategoryService(IMapper mapper, IRepository<Category> repository, PersonalBlogDbContext context)
    {
        _mapper = mapper;
        _repository = repository;
        _context = context;
    }
    public async Task<List<CategoryDto>> GetCategories()
    {
        var categories = await _repository.GetAllAsync();
        var map = _mapper.Map<List<CategoryDto>>(categories);
        map = map.OrderBy(c => c.Name).ToList();
        return map;
    }
    public async Task CreateCategory(CategoryCreateDto categoryCreateDto)
    {
        var map = _mapper.Map<Category>(categoryCreateDto);
        await _repository.AddAsync(map);
        await _repository.SaveAsync();
    }
    public async Task<CategoryDto> GetCategoryDetail(string id)
    {
        var category = await _repository.GetByGuidAsync(Guid.Parse(id));
        var map = _mapper.Map<CategoryDto>(category);
        return map;
    }
}
