using System.Web;
using System.Web.Optimization;

namespace AEXApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/js/woothemes-FlexSlider-06b12f8/jquery.flexslider-min.js",
                        "~/js/prettyPhoto_3.1.5/jquery.prettyPhoto.js",
                        //                "~/js/woothemes-FlexSlider-06b12f8/bootstrap.min.css",
                        ////"~/js/modernizr.custom.48287.js",
                       // "~/js/_theme.js"
                        "~/js/isotope/jquery.isotope.min.js" ,
                        "~/js/jquery.ui.totop.js",
                        "~/js/easing.js",
                        "~/js/wow.min.js",
                        "~/js/snap.svg-min.js",
                        "~/js/restart_theme.js",
                        "~/js/collapser.js",
                        "~/js/bootstrap.min.js"

                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/js/modernizr*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"
                //"~/js/*.js"
                      ));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          //"~/Content/bootstrap.css",
            //    //"~/Content/site.css",
            //          "~/css/animate.css",
            //          "~/css/style.css"
            //          ));
            bundles.Add(new StyleBundle("~/test/css").Include(
                                        "~/css/animate.css",
                                        "~/css/style.css",
                                        "~/Content/site.css",
                                        "~/js/woothemes-FlexSlider-06b12f8/flexslider.css",
                                        //"~/js/woothemes-FlexSlider-06b12f8/jquery.flexslider-min.css"
                                        //"~/js/woothemes-FlexSlider-06b12f8/bootstrap.min.css",
                                        "~/js/prettyPhoto_3.1.5/prettyPhoto.css"
          ));

            bundles.Add(new StyleBundle("~/Test/font").Include(
                      "~/fonts/font-awesome/css/font-awesome.min.css"
                    ));


        }
    }
}
