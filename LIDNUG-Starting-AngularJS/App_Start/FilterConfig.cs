﻿using System.Web;
using System.Web.Mvc;

namespace LIDNUG_Starting_AngularJS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
