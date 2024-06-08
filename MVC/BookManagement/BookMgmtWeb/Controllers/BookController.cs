using Microsoft.AspNetCore.Mvc;

namespace BookMgmtWeb.Controllers
{
    public class BookController : Controller
    {
        BookBl bbl = new BookBl(); 
        public IActionResult Index()        // View where display all books and also link to add new book.
        {
            return View();
        }
    }
}
