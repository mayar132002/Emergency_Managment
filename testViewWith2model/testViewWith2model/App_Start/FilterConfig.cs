﻿using System.Web;
using System.Web.Mvc;

namespace testViewWith2model
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
