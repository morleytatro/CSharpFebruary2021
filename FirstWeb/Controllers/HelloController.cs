using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers
{
    public class HelloController : Controller
    {
        // like urls.py
        // gluing a URL pattern to some logic
        [HttpGet("")]
        // return render()
        public ViewResult Index()
        {
            return View();
        }

        // path("some-route/<str:some_param>", views.some_route)
        [HttpGet("some-route/{someParam}")]
        public string SomeRoute(int someParam)
        {
            return $"The param is {someParam}.";
        }
    }
}