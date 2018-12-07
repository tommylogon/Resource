using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Resource.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            Response.Redirect("Panel/index");
        }
    }
}