namespace Dates.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class UsersController : Controller
    {
        public IActionResult AddImage()
        {
            return this.View();
        }
    }
}
