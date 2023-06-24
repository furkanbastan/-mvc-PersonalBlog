using Microsoft.AspNetCore.Identity;
using PersonalBlog.Entity.Entities.Common;

namespace PersonalBlog.Entity.Entities.Identity;

public class AppUser : IdentityUser<Guid>, IEntityBase
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Guid ImageId { get; set; }
    public Image Image { get; set; }
    public ICollection<Article> Articles { get; set; } = new HashSet<Article>();
}
