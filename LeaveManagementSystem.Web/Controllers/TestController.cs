using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Hello, World!",
                DateOfBirth = new DateTime(1990, 1, 1)
            };

            return View(data);
        }
    }
}
