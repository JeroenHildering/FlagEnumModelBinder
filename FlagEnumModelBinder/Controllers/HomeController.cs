using System.Web.Mvc;
using FlagEnumModelBinder.Models;

namespace FlagEnumModelBinder.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.SavedValues = "";
            return View(new FlagViewModel());
        }

        [HttpPost]
        public ActionResult Save(FlagViewModel model)
        {
            ViewBag.SavedValues = model.FlagProperty.ToString();
            return View("~/Views/Home/Index.cshtml", model);
        }
    }
}