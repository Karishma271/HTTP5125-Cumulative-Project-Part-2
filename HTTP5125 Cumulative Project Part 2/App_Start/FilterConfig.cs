﻿using System.Web;
using System.Web.Mvc;

namespace HTTP5125_Cumulative_Project_Part_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
