using System.Web.Mvc;

namespace Branch.Areas.B3
{
    public class B3AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "B3";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "B3_default",
                "B3/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}