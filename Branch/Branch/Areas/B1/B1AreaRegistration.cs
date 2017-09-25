using System.Web.Mvc;

namespace Branch.Areas.B1
{
    public class B1AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "B1";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "B1_default",
                "B1/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}