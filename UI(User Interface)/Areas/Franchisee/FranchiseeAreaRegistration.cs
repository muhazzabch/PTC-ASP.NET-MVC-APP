using System.Web.Mvc;

namespace UI_User_Interface_.Areas.Franchisee
{
    public class FranchiseeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Franchisee";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Franchisee_default",
                "Franchisee/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}