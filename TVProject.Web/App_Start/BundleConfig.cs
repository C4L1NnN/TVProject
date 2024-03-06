using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace TVProject.Web.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bootstrap core css
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Vendors/css/bootstrap.css", new CssRewriteUrlTransform()));

            //font awesome style 
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include("~/Vendors/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            //style
            bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/Vendors/css/style.css", new CssRewriteUrlTransform()));
            
            //responsive
            bundles.Add(new StyleBundle("~/bundles/responsive/css").Include("~/Vendors/css/responsive.css", new CssRewriteUrlTransform()));


            //--SCRIPTS--

            //jQery
            bundles.Add(new ScriptBundle("~/bundles/jqery/js").Include("~/Vendors/js/jquery-3.4.1.min.js"));
            
            //bootstrap js
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Vendors/js/bootstrap.js"));
            
            //custom js
            bundles.Add(new ScriptBundle("~/bundles/custom/js").Include("~/Vendors/js/custom.js"));

        }
    }
}