using System.Web.Optimization;

namespace BuildHealth2013.WebUI.App_Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/scripts/modernizr").Include(
                "~/Scripts/modernizr-*"
            ));

            // Can comment parts that are not in use
            bundles.Add(new ScriptBundle("~/bundles/scripts/vendor").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-ui-{version}.js",
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"
                //"~/Scripts/bootstrap-transition",
                //"~/Scripts/bootstrap-affix",
                //"~/Scripts/bootstrap-alert",
                //"~/Scripts/bootstrap-button",
                //"~/Scripts/bootstrap-carousel",
                //"~/Scripts/bootstrap-collapse",
                //"~/Scripts/bootstrap-dropdown",
                //"~/Scripts/bootstrap-modal",
                //"~/Scripts/bootstrap-scrollspy",
                //"~/Scripts/bootstrap-tab",
                //"~/Scripts/bootstrap-tooltip",
                //"~/Scripts/bootstrap-popover",
                //"~/Scripts/bootstrap-typeahead"
            ));

            bundles.Add(new StyleBundle("~/bundles/styles/vendor").Include(
                "~/Content/themes/base/jquery.ui.core.css",
                //"~/Content/themes/base/jquery.ui.accordion.css",
                //"~/Content/themes/base/jquery.ui.autocomplete.css",
                //"~/Content/themes/base/jquery.ui.button.css",
                //"~/Content/themes/base/jquery.ui.datepicker.css",
                //"~/Content/themes/base/jquery.ui.dialog.css",
                //"~/Content/themes/base/jquery.ui.menu.css",
                //"~/Content/themes/base/jquery.ui.progressbar.css",
                //"~/Content/themes/base/jquery.ui.resizable.css",
                //"~/Content/themes/base/jquery.ui.selectable.css",
                //"~/Content/themes/base/jquery.ui.slider.css",
                //"~/Content/themes/base/jquery.ui.spinner.css",
                //"~/Content/themes/base/jquery.ui.tabs.css",
                //"~/Content/themes/base/jquery.ui.tooltip.css",
                "~/Content/themes/base/jquery.ui.theme.css"
            ));

            bundles.Add(new StyleBundle("~/bundles/styles/app").Include(
                "~/Content/Styles/main.css"
            ));
        }
    }
}