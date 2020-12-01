using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Razor.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /) local host 5000
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("info")]
        public ViewResult Info()
        {
            return View("Info");
        }

        [HttpGet]
        [Route("elsewhere")]
        public string GoodBye()
        {
            return "goodbye";
        }


    }
}