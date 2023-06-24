using Microsoft.AspNetCore.Mvc;

namespace PersonalBlog.Web.ViewComponents;

public class FooterViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return await Task.Run(() => View());
    }
}
