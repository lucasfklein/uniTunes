using System.Web;
using System.Web.Optimization;

namespace uniTunes.UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/jquery-1.10.2.js",
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                        "~/Content/bootstrap/bootstrap.css",
                        "~/Content/reset.css",
                        "~/Content/base.css",
                        "~/Content/site.css",
                        "~/Content/extensions.css"));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
