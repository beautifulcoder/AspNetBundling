using System.Web.Optimization;

namespace AspNetBundling
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundle/bootstrap-styles")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme.css")
                .Include("~/Content/Site.css"));
            bundles.Add(new StyleBundle("~/bundle/Home/Index-styles")
                .Include("~/Content/StyleSheet1.css")
                .Include("~/Content/StyleSheet2.css")
                .Include("~/Content/StyleSheet3.css"));

            bundles.Add(new ScriptBundle("~/bundle/bootstrap-scripts")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/modernizr-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundle/Home/Index-scripts")
                .Include("~/Scripts/JavaScript1.js")
                .Include("~/Scripts/JavaScript2.js")
                .Include("~/Scripts/JavaScript3.js"));
        }
    }
}
