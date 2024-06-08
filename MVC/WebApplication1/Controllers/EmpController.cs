using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View("random");
        }

        public IActionResult AddEmp() 
        {
            return View("AddEmp");
        }

        public IActionResult EmpList()
        {
            return View("EmpList");
        }
        public IActionResult Update()
        {
            return View("Update");
        }
    }
}
