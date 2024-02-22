using Microsoft.AspNetCore.Mvc;

namespace Miniproject2.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }



    }

}
