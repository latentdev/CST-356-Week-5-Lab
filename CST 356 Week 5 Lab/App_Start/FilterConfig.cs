﻿using System.Web;
using System.Web.Mvc;

namespace CST_356_Week_5_Lab
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
