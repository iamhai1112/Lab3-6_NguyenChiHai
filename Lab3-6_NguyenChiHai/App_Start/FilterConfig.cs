﻿using System.Web;
using System.Web.Mvc;

namespace Lab3_6_NguyenChiHai
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
