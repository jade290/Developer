using System.Web;
using System.Web.Optimization;

namespace Developer
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Client/vendor/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Client/vendor/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Client/vendor/jquery.unobtrusive*",
                "~/Client/vendor/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Client/vendor/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Client/vendor/SiteOwner/js/TweenMax.min.js",
                "~/Client/vendor/SiteOwner/js/jquery.touchSwipe.min.js",
                "~/Client/vendor/SiteOwner/js/jquery.mixitup.min.js",
                "~/Client/vendor/SiteOwner/js/jquery.carouFredSel-6.2.1-packed.js",
                "~/Client/vendor/SiteOwner/js/jquery.dropdownit.js",
                "~/Client/vendor/SiteOwner/js/jquery.stellar.min.js",
                "~/Client/vendor/SiteOwner/js/ScrollToPlugin.min.js",
                "~/Client/vendor/Bootstrap-3.3.6/js/bootstrap.min.js",
                "~/Client/vendor/SiteOwner/js/jquery.mixitup.min.js",
                "~/Client/vendor/SiteOwner/js/masonry.min.js",
                "~/Client/vendor/SiteOwner/js/perfect-scrollbar-0.4.5.with-mousewheel.min.js",
                "~/Client/vendor/SiteOwner/js/magnific-popup.js",
                "~/Client/vendor/SiteOwner/js/custom.js",
                "~/Client/vendor/tag-it-master/js/tag-it.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Client/vendor/font-awesome-4.5.0/css/font-awesome.min.css",
                "~/Client/vendor/Bootstrap-3.3.6/css/bootstrap.min.css",
                "~/Client/vendor/SiteOwner/css/perfect-scrollbar-0.4.5.min.css",
                "~/Client/vendor/SiteOwner/css/magnific-popup.css",
                "~/Client/vendor/SiteOwner/css/style.css",
                "~/Client/vendor/SiteOwner/css/custom-style.css",
                "~/Client/vendor/SiteOwner/css/default.css",
                "~/Client/vendor/tag-it-master/css/jquery.tagit.css",
                "~/Client/vendor/tag-it-master/css/tagit.ui-zendesk.css"
                ));
        }
    }
}