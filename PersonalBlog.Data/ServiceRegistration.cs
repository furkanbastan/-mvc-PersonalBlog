using Microsoft.Extensions.DependencyInjection;
using PersonalBlog.Data.Contexts;
using PersonalBlog.Data.Repositories;

namespace PersonalBlog.Data;

public static class ServiceRegistration
{
    public static void AddDataServices(this IServiceCollection services)
    {
        services.AddDbContext<PersonalBlogDbContext>();
        services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
    }
}
