using System.Web.Mvc;

namespace blog_yeni.Areas.yonetim
{
    public class yonetimAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "yonetim";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "yonetim_default",
                "yonetim/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
