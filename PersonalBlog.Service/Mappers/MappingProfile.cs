using AutoMapper;
using PersonalBlog.Entity.DTOs;
using PersonalBlog.Entity.DTOs.Article;
using PersonalBlog.Entity.DTOs.Category;
using PersonalBlog.Entity.DTOs.Comment;
using PersonalBlog.Entity.DTOs.User;
using PersonalBlog.Entity.Entities;
using PersonalBlog.Entity.Entities.Identity;

namespace PersonalBlog.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ArticleCategory, ArticleCategoryDto>().ReverseMap();

        CreateMap<Article, ArticleDto>().ReverseMap();
        CreateMap<Article, ArticleListDto>().ReverseMap();
        CreateMap<Article, ArticleEditDto>().ReverseMap();
        CreateMap<Article, ArticleCreateDto>().ReverseMap();

        CreateMap<Comment, CommentListDto>().ReverseMap();

        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CategoryCreateDto>().ReverseMap();

        CreateMap<AppUser, UserListDto>().ReverseMap();
    }
}
