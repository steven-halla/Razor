using Microsoft.AspNetCore.Mvc;
namespace aspCore.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /) local host 5000
        public string Index()
        {
            return "Hello World from HomeController!";
        }

        [HttpGet]
        [Route("hello")]
        public string Hello()
        {
            return "hi again";
        }

        [HttpGet]
        [Route("hello/goodbye")]
        public string GoodBye()
        {
            return "goodbye";
        }


    }
}