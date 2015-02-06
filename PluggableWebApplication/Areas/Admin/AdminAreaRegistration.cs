﻿using System.Web.Mvc;

namespace Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new {controller="Home", action = "Index", area="Admin", id = UrlParameter.Optional },
                namespaces: new[] { "Admin.Controllers"}
            );
        }
    }
}