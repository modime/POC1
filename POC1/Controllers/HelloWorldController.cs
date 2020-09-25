using Microsoft.AspNetCore.Mvc;
using POC1.HelloWorldHelper;

namespace POC1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            //return "Hello!";

            return HelloWorld.GetGreeting();
        }
    }
}
