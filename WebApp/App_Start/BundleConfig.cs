using System.Web.Optimization;

namespace Atarbashi.WebApp.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/App_Themes/Atarbashi/vendors/jquery/jquery-{version}.min.js",
                       "~/App_Themes/Atarbashi/vendors/bootstrap/bootstrap.bundle.min.js",
                       "~/App_Themes/Atarbashi/vendors/skrollr.min.js",
                       "~/App_Themes/Atarbashi/vendors/owl-carousel/owl.carousel.min.js",
                       "~/App_Themes/Atarbashi/vendors/nice-select/jquery.nice-select.min.js",
                       "~/App_Themes/Atarbashi/vendors/jquery.ajaxchimp.min.js",
                       "~/App_Themes/Atarbashi/vendors/mail-script.js",
                       "~/App_Themes/Atarbashi/js/main.js",
                       "~/App_Themes/Atarbashi/js/atarbashi.js"));

          

            bundles.Add(new StyleBundle("~/bootstrap/css").Include(
                     "~/App_Themes/Atarbashi/vendors/bootstrap/bootstrap.min.css",
                     "~/App_Themes/Atarbashi/vendors/fontawesome/css/all.min.css",
                     "~/App_Themes/Atarbashi/vendors/themify-icons/themify-icons.css",
                     "~/App_Themes/Atarbashi/vendors/nice-select/nice-select.css",
                     "~/App_Themes/Atarbashi/vendors/owl-carousel/owl.theme.default.min.css",
                     "~/App_Themes/Atarbashi/vendors/owl-carousel/owl.carousel.min.css",
                     "~/App_Themes/Atarbashi/css/style.css"));

        }
    }
}