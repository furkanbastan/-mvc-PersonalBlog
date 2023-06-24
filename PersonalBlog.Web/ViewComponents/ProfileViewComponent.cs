using Microsoft.AspNetCore.Mvc;

namespace PersonalBlog.Web.ViewComponents;

public class ProfileViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return await Task.Run(() => View());
    }
}
