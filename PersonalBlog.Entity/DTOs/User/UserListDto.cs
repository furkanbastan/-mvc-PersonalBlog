namespace PersonalBlog.Entity.DTOs.User;

public class UserListDto
{
    public UserListDto()
    {
        FullName = $"{FirstName} {LastName}";
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
}
