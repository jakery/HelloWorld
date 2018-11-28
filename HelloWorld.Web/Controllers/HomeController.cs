using HelloWorld.Api;
using HelloWorld.Api.Factory;
using HelloWorld.Web.Models;
using System.Web.Mvc;

namespace HelloWorld.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var factory = new HelloWorldFactory();
            var helloWorldPlaintextParadigm = factory.CreateHelloWorldGetter("plaintext");
            var homeViewModel = new HomeViewModel
            {
                helloWorldMessage = helloWorldPlaintextParadigm.GetHelloWorld()
            };
            return View(homeViewModel);
        }
    }
}