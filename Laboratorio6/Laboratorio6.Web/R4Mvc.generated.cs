// <auto-generated />
// This file was generated by R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and run the generator tool again.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using R4Mvc;

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
public static partial class MVC
{
    static readonly R4Mvc.GameAreaClass s_Game = new R4Mvc.GameAreaClass();
    public static R4Mvc.GameAreaClass Game => s_Game;
    public static readonly Laboratorio6.Web.Features.Base.BaseController Base = new Laboratorio6.Web.Features.Base.R4MVC_BaseController();
    public static readonly Laboratorio6.Web.Features.Home.HomeController Home = new Laboratorio6.Web.Features.Home.R4MVC_HomeController();
    public static readonly Laboratorio6.Web.Features.Login.LoginController Login = new Laboratorio6.Web.Features.Login.R4MVC_LoginController();
    public static readonly R4Mvc.SharedController Shared = new R4Mvc.SharedController();
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
public static partial class MVCPages
{
}

namespace R4Mvc
{
    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy()
        {
        }

        public static Dummy Instance = new Dummy();
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class SharedController
    {
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
                public readonly string _Layout = "_Layout";
                public readonly string _LayoutHtml = "_LayoutHtml";
            }

            public readonly string _Layout = "~/Views/Shared/_Layout.cshtml";
            public readonly string _LayoutHtml = "~/Views/Shared/_LayoutHtml.cshtml";
        }

        static readonly ViewsClass s_Views = new ViewsClass();
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class GameAreaClass
    {
        public readonly string Name = "Game";
        public readonly Laboratorio6.Web.Areas.Game.Game.GameController Game = new Laboratorio6.Web.Areas.Game.Game.R4MVC_GameController();
    }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
public static partial class Links
{
    public const string UrlPath = "~";
    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
    public static partial class css
    {
        public const string UrlPath = "~/css";
        public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static readonly string bundle_global_css = Url("bundle-global.css");
        public static readonly string bundle_global_min_css = Url("bundle-global.min.css");
        public static readonly string bundle_vue_multiselect_css = Url("bundle-vue-multiselect.css");
        public static readonly string bundle_vue_multiselect_min_css = Url("bundle-vue-multiselect.min.css");
        public static readonly string site_css = Url("site.css");
    }

    public static partial class js
    {
        public const string UrlPath = "~/js";
        public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static readonly string bundle_global_js = Url("bundle-global.js");
        public static readonly string bundle_global_min_js = Url("bundle-global.min.js");
        public static readonly string bundle_global_min_js_map = Url("bundle-global.min.js.map");
        public static readonly string bundle_vue_multiselect_js = Url("bundle-vue-multiselect.js");
        public static readonly string bundle_vue_multiselect_min_js = Url("bundle-vue-multiselect.min.js");
        public static readonly string bundle_vue_multiselect_min_js_map = Url("bundle-vue-multiselect.min.js.map");
        public static readonly string bundle_vue_js = Url("bundle-vue.js");
        public static readonly string bundle_vue_min_js = Url("bundle-vue.min.js");
        public static readonly string bundle_vue_min_js_map = Url("bundle-vue.min.js.map");
        public static readonly string site_js = Url("site.js");
    }

    public static readonly string favicon_ico = Url("favicon.ico");
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal static class R4MvcHelpers
{
    private static string ProcessVirtualPathDefault(string virtualPath) => virtualPath;
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult : ActionResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_JsonResult : JsonResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_JsonResult(string area, string controller, string action, string protocol = null): base(null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_ContentResult : ContentResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_ContentResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_FileResult : FileResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_FileResult(string area, string controller, string action, string protocol = null): base(null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RedirectResult : RedirectResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RedirectResult(string area, string controller, string action, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToActionResult : RedirectToActionResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToActionResult(string area, string controller, string action, string protocol = null): base(" ", " ", " ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToRouteResult : RedirectToRouteResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToRouteResult(string area, string controller, string action, string protocol = null): base(null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_ActionResult : ActionResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_ActionResult(string pageName, string pageHandler, string protocol = null)
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_JsonResult : JsonResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_JsonResult(string pageName, string pageHandler, string protocol = null): base(null)
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_ContentResult : ContentResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_ContentResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_FileResult : FileResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_FileResult(string pageName, string pageHandler, string protocol = null): base(null)
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectResult : RedirectResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectResult(string pageName, string pageHandler, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectToActionResult : RedirectToActionResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectToActionResult(string pageName, string pageHandler, string protocol = null): base(" ", " ", " ")
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectToRouteResult : RedirectToRouteResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectToRouteResult(string pageName, string pageHandler, string protocol = null): base(null)
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}
#pragma warning restore 1591, 3008, 3009, 0108
