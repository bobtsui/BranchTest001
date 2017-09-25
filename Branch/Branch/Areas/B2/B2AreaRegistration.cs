using System.Web.Mvc;

namespace Branch.Areas.B2
{
    public class B2AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "B2";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "B2_default",
                "B2/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}