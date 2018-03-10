using System.Web.Mvc;

namespace LeagueAppManagement.Areas.Admins.Controllers
{
    public class ManagePlayerController : Controller
    {
        public ActionResult List()
        {
            return View();
        }
    }
}