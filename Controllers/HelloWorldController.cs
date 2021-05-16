using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye World");
        }
        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string Rick, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {Rick}, ID: {3}");
        }
    }
}