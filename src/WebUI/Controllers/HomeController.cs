using System.Data.Entity;
using System.Web.Mvc;
using BuildHealth2013.WebUI.Infrastructure.EntityFramework;
using BuildHealth2013.WebUI.Models;

namespace BuildHealth2013.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDbContext _dbContext;

        public HomeController(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var users = _dbContext.Set<UserProfile>();

            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
