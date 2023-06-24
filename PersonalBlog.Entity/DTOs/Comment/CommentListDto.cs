namespace PersonalBlog.Entity.DTOs.Comment;

public class CommentListDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Content { get; set; }
    public bool IsApprove { get; set; } = false;
    public CommentListDto ParentComment { get; set; }
    public List<CommentListDto> ChildComments { get; set; }
}
