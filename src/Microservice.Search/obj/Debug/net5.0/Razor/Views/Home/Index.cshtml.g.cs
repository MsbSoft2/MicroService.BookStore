#pragma checksum "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af24c766d8fd36b1f81d811e2edfbcf3ab35df3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\_ViewImports.cshtml"
using Microservice.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\_ViewImports.cshtml"
using Microservice.Search.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af24c766d8fd36b1f81d811e2edfbcf3ab35df3e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6efd7bdada2284fd9ec97cbbf437f20502c22f2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-sm btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "جستجو کتاب";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Search", async() => {
                WriteLiteral(@"
    <div class=""row justify-content-center"">
        <div class=""col-md-8 text-center"">
            <h1 class=""display-4 text-danger"">جستجوی کتاب</h1>
            <hr />
            <h5 class=""text-dark mb-4 mt-2"">
                جستجو بین نام کتاب ها و توضیحات کتاب ها و نویسنده کتاب ها
            </h5>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af24c766d8fd36b1f81d811e2edfbcf3ab35df3e5811", async() => {
                    WriteLiteral(@"
                <input name=""title"" class=""form-control w-75 text-center border-primary"" 
                       type=""search"" placeholder=""کلمه مورد نظر خود را وارد کنید"" 
                       aria-label=""Search"">
                <button class=""btn btn-outline-primary my-sm-3 d-sm-block px-5 rounded-end"" 
                        type=""submit"">
                    جستجو
                </button>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row my-4 text-right  justify-content-center\" dir=\"rtl\">\r\n");
#nullable restore
#line 32 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                <div class=\"card\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1212, "\"", 1250, 3);
#nullable restore
#line 36 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
WriteAttributeValue("", 1218, ViewData["url"], 1218, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1236, "/", 1236, 1, true);
#nullable restore
#line 36 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
WriteAttributeValue("", 1237, item.Image, 1237, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top p-4\" />\r\n                    <div class=\"card-title mx-3\">\r\n                        نام کتاب :\r\n                        ");
#nullable restore
#line 39 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        توضیحات کتاب :\r\n                        ");
#nullable restore
#line 43 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                    </div>\r\n                    <div class=\"card-footer bg-white\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af24c766d8fd36b1f81d811e2edfbcf3ab35df3e10523", async() => {
                WriteLiteral("\r\n                            مشاهده جزئیات\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Title", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
                                WriteLiteral(item.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
                                      WriteLiteral(item.Description);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Description"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Description", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Description"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
                                 WriteLiteral(item.Price);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Price"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Price", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Price"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
                                 WriteLiteral(item.Auther);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Auther"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Auther", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Auther"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
                                 WriteLiteral(int.Parse(item.Count.ToString()));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Count"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Count", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Count"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
                                 WriteLiteral(item.Serial);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Serial"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Serial", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Serial"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
                                WriteLiteral(item.Image);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Image"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Image", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Image"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 60 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 62 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning text-center my-3 mx-3\">\r\n        <h2>\r\n            کتاب مورد نظر یافت نشد\r\n        </h2>\r\n    </div>\r\n");
#nullable restore
#line 70 "D:\Larn\University Eduction\001\پروژه کارشناسی\Service.BookStore\src\Microservice.Search\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591