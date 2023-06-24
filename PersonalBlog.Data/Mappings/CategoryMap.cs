using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entity.Entities;

namespace PersonalBlog.Data.Mappings;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
        new Category{
            Id = Guid.Parse("2e209a21-7bb2-43b1-a0c6-6e7d0c990db8"),
            CreatedDate = DateTime.Now,
            Name = ".Net Core"
        },
        new Category{
            Id = Guid.Parse("0bd8b92f-d7bf-4dce-91c3-ac17f3b1b345"),
            CreatedDate = DateTime.Now,
            Name = ".Net Framework 4.5"
        },new Category{
            Id = Guid.Parse("45269bbb-a36f-46c8-a69f-e1d2802207f5"),
            CreatedDate = DateTime.Now,
            Name = "Ado.Net"
        },new Category{
            Id = Guid.Parse("49405eff-13c5-4558-a5f2-8b589b7e915c"),
            CreatedDate = DateTime.Now,
            Name = "C# 7.0"
        },new Category{
            Id = Guid.Parse("4ab0c360-a01f-4862-aed4-52f16a08470d"),
            CreatedDate = DateTime.Now,
            Name = "Angular"
        },new Category{
            Id = Guid.Parse("62e6c2e9-e35c-4f4e-a4c2-4a70c7d06180"),
            CreatedDate = DateTime.Now,
            Name = "Blazor"
        },new Category{
            Id = Guid.Parse("c1faf13c-9e78-43be-9970-b6a20336bf48"),
            CreatedDate = DateTime.Now,
            Name = "CSS"
        },new Category{
            Id = Guid.Parse("336461a4-29b2-4dbc-887d-2b68e6527ba5"),
            CreatedDate = DateTime.Now,
            Name = "HTML"
        },new Category{
            Id = Guid.Parse("9bcef803-76d1-4993-8b1f-7eec1941acf4"),
            CreatedDate = DateTime.Now,
            Name = "LINQ"
        },new Category{
            Id = Guid.Parse("6724e8c6-a7fa-42d7-ad36-33e87d945a31"),
            CreatedDate = DateTime.Now,
            Name = "LINQ to SQL"
        },new Category{
            Id = Guid.Parse("c8784e8e-13de-4024-b7fb-71229b37fd55"),
            CreatedDate = DateTime.Now,
            Name = "React"
        },new Category{
            Id = Guid.Parse("c9b467ba-9efa-481f-bdc1-1132e6f5186d"),
            CreatedDate = DateTime.Now,
            Name = "WPF"
        },new Category{
            Id = Guid.Parse("4a8cad9c-57cd-4ad9-8048-7662c6c24a17"),
            CreatedDate = DateTime.Now,
            Name = "Node.js"
        },new Category{
            Id = Guid.Parse("6644a63f-c42b-49e8-afb9-67e012a3c855"),
            CreatedDate = DateTime.Now,
            Name = "Powershell"
        },new Category{
            Id = Guid.Parse("a0ce76d6-e259-47e5-afda-12e5f4b52852"),
            CreatedDate = DateTime.Now,
            Name = "Office Development"
        },new Category{
            Id = Guid.Parse("22b5d36e-1d52-4d2f-8ce1-31a0aa567c66"),
            CreatedDate = DateTime.Now,
            Name = "Kitap Tavsiyeleri"
        },new Category{
            Id = Guid.Parse("fa961207-14b0-4f31-9aa7-d9ab3ebd35f5"),
            CreatedDate = DateTime.Now,
            Name = "Entity Framework Core"
        },new Category{
            Id = Guid.Parse("fa961807-14b0-4f31-9aa7-d9ab3ebd35f5"),
            CreatedDate = DateTime.Now,
            Name = "Tasarım Kalıpları"
        },new Category{
            Id = Guid.Parse("fa961207-14b0-4f31-7aa7-d9ab3ebd34f5"),
            CreatedDate = DateTime.Now,
            Name = "Tasarım Prensipleri"
        });
    }
}
