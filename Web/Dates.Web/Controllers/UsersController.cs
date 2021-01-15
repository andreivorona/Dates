using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dates.Web.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult AddImage()
        {
            return this.View();
        }
    }
}
