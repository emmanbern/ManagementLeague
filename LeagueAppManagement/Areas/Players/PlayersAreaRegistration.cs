using System.Web.Mvc;

namespace LeagueAppManagement.Areas.Players
{
    public class PlayersAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Players";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Players_default",
                "Players/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}