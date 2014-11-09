﻿using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace AspNetBundling
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
