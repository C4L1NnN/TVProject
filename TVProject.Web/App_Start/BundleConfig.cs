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
            //<-HOME->
            //bootstrap core css
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Vendors/css/bootstrap.css", new CssRewriteUrlTransform()));

            //font awesome style 
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include("~/Vendors/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            //style
            bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/Vendors/css/style.css", new CssRewriteUrlTransform()));
            
            //responsive
            bundles.Add(new StyleBundle("~/bundles/responsive/css").Include("~/Vendors/css/responsive.css", new CssRewriteUrlTransform()));



            //<-ABOUT->
            //bootsrtap core css 
            bundles.Add(new StyleBundle("~/bundles/bootstrap-About/css").Include("~/Vendors/css/bootstrap.css", new CssRewriteUrlTransform()));
            
            //font-awesome style
            bundles.Add(new StyleBundle("~/bundles/font-awesome-About/css").Include("~/Vendors/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            //Custom styles for this template 
            bundles.Add(new StyleBundle("~/bundles/style-About/css").Include("~/Vendors/css/style.css", new CssRewriteUrlTransform()));

            // responsive style
            bundles.Add(new StyleBundle("~/bundles/responsive-About/css").Include("~/Vendors/css/responsive.css", new CssRewriteUrlTransform()));



            //--SCRIPTS--

            //<-HOME->
            //jQery
            bundles.Add(new ScriptBundle("~/bundles/jqery/js").Include("~/Vendors/js/jquery-3.4.1.min.js"));
            
            //bootstrap js
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Vendors/js/bootstrap.js"));
            
            //custom js
            bundles.Add(new ScriptBundle("~/bundles/custom/js").Include("~/Vendors/js/custom.js"));


            //<-ABOUT->
            //jQery-About
            bundles.Add(new ScriptBundle("~/bundles/jqery-about/js").Include("~/Vendors/js/jquery-3.4.1.min.js"));

            //bootstrap-About
            bundles.Add(new ScriptBundle("~/bundles/bootstrap-about/js").Include("~/Vendors/js/bootstrap.js"));

            //custom-About
            bundles.Add(new ScriptBundle("~/bundles/custom-about/js").Include("~/Vendors/js/custom.js"));

        }
    }
}