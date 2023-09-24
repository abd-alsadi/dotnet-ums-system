using System.Web;
using System.Web.Optimization;

namespace KmnlkUMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/javascript/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/javascript/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/javascript/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/javascript/bootstrap.js",
                      "~/Scripts/javascript/respond.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/datatable").Include(
                     "~/Scripts/datatable/jquery.dataTables.min.js",
                     "~/Scripts/datatable/dataTables.bootstrap4.min.js"
                     ));


            bundles.Add(new ScriptBundle("~/bundles/theme").Include(
                  "~/Content/theme/vendor/jquery/jquery.min.js",
                  "~/Content/theme/vendor/bootstrap/js/bootstrap.bundle.min.js",
                  "~/Content/theme/vendor/jquery-easing/jquery.easing.min.js",
                  "~/Content/theme/vendor/datatables/jquery.dataTables.js",
                  "~/Content/theme/vendor/datatables/dataTables.bootstrap4.js",
                  "~/Content/theme/js/sb-admin.min.js"
                  ));

            bundles.Add(new ScriptBundle("~/bundles/shared").Include(
                   "~/Scripts/shared/shared.js"));


            bundles.Add(new StyleBundle("~/Content/css/pub").Include(
                      "~/Content/pub/Site.css"));

            bundles.Add(new StyleBundle("~/Content/css/theme/en").Include(
                    "~/Content/theme/vendor/fontawesome-free/css/all.min.css",
                    "~/Content/theme/vendor/datatables/dataTables.bootstrap4.css",
                    "~/Content/theme/css/sb-admin.css"
                    ));

            bundles.Add(new StyleBundle("~/Content/css/theme/ar").Include(
                  "~/Content/theme/vendor/fontawesome-free/css/all.min.css",
                  "~/Content/theme/vendor/datatables/dataTables.bootstrap4.css",
                  "~/Content/theme/css/sb-admin-ar.css"
                  ));
        }
    }
}
