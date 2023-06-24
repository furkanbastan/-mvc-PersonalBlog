using PersonalBlog.Entity.Entities.Common;

namespace PersonalBlog.Entity.Entities;

public class Image : EntityBase
{
    public string FileType { get; set; }
    public string FileName { get; set; }
}
