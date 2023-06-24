namespace PersonalBlog.Entity.Entities.Common;

public class EntityBase : IEntityBase
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime ModifiedDate { get; set; }
    public bool IsDeleted { get; set; } = false;
}
