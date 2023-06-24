using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalBlog.Service.Mappers;
using PersonalBlog.Service.Services.Abstractions;
using PersonalBlog.Service.Services.Concrete;
using PersonalBlog.Service.Validators;

namespace PersonalBlog.Service;

public static class ServiceRegistration
{
    public static void AddServiceLayer(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation(opt =>
            {
                opt.DisableDataAnnotationsValidation = true;
                //opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
            })
            .AddValidatorsFromAssemblyContaining<AppUserValidator>();

        services.AddAutoMapper(typeof(MappingProfile));

        services.AddScoped<IArticleService, ArticleService>();
        services.AddScoped<ICommentService, CommentService>();
        services.AddScoped<ICategoryService, CategoryService>();
    }
}
