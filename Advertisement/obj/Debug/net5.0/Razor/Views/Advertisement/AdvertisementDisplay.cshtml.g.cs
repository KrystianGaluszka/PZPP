#pragma checksum "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33ee96bfdf47f9d05cabf158552158e2e5ee457e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advertisement_AdvertisementDisplay), @"mvc.1.0.view", @"/Views/Advertisement/AdvertisementDisplay.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\_ViewImports.cshtml"
using Advertisement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\_ViewImports.cshtml"
using Advertisement.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\_ViewImports.cshtml"
using Advertisement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ee96bfdf47f9d05cabf158552158e2e5ee457e", @"/Views/Advertisement/AdvertisementDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d24c929b29ec889106e731508cfc30ae49ed416", @"/Views/_ViewImports.cshtml")]
    public class Views_Advertisement_AdvertisementDisplay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdvertisementViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/displayAd.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/lightgallery/css/lightgallery.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/lightSlider/css/lightslider.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
  
    ViewData["Title"] = "AdvertisementDisplay";
    var adId = ViewBag.Id;
    var title = ViewBag.Name;
    var first = true;
    var adList = ViewBag.List as List<Advertisements>;
    var picList = ViewBag.PicList as List<Pictures>;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33ee96bfdf47f9d05cabf158552158e2e5ee457e5306", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33ee96bfdf47f9d05cabf158552158e2e5ee457e6420", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33ee96bfdf47f9d05cabf158552158e2e5ee457e7534", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
 foreach (var item in adList)
{
    if (adId == item.Id)
    {
        if (item.PicturesCol == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-center\"></div>\r\n");
#nullable restore
#line 22 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n            <ol class=\"carousel-indicators\">\r\n                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"0\" class=\"active\"></li>\r\n");
#nullable restore
#line 28 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
                 for (int i = 1; i < item.PicturesCol.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li data-target=\"#carouselExampleIndicators\" data-slide-to=i></li>\r\n");
#nullable restore
#line 31 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ol>\r\n            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 34 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
                 foreach (var img in picList)
                {
                    if (img.AdvertisementId == adId)
                    {
                        var path = $"~/AdPictures/{img.Name}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1420, "\"", 1486, 2);
            WriteAttributeValue("", 1428, "carousel-item", 1428, 13, true);
#nullable restore
#line 39 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
WriteAttributeValue(" ", 1441, first ? Html.Raw("active") : Html.Raw(""), 1442, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"d-block w-100\" id=\"image\"");
            BeginWriteAttribute("src", " src=", 1555, "", 1578, 1);
#nullable restore
#line 40 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
WriteAttributeValue("", 1560, Url.Content(path), 1560, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 42 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
                        first = false;
                    }
                    else continue;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
");
#nullable restore
#line 56 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h4 style=\"margin-top:2%\">");
#nullable restore
#line 58 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n");
            WriteLiteral("        <dl>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 63 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                <div style=\"max-width:800px\">");
#nullable restore
#line 66 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <hr />\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 70 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
           Write(Html.DisplayNameFor(model => model.AdTypes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 73 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
           Write(Html.DisplayFor(modelItem => item.AdTypes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n");
#nullable restore
#line 76 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
    }
    else continue;

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Users\Shaddar\Desktop\Ostatniraz2\Advertisement\Views\Advertisement\AdvertisementDisplay.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    <script>\r\n        var bootstrapButton = $.fn.button.noConflict()\r\n        $.fn.bootstrapBtn = bootstrapButton\r\n    </script>\r\n\r\n    <script>\r\n\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdvertisementViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
