#pragma checksum "C:\Users\A\source\repos\ASPmvcPractice\MVCpracticeApp\MVCpracticeApp\Views\Shared\_EachTrip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1e6ac51915edc65e28431f8c33faa901ebe0be6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EachTrip), @"mvc.1.0.view", @"/Views/Shared/_EachTrip.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1e6ac51915edc65e28431f8c33faa901ebe0be6", @"/Views/Shared/_EachTrip.cshtml")]
    public class Views_Shared__EachTrip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCpracticeApp.Models.Trip>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<article class=\"blog-post\">\r\n\r\n    <h1>\r\n        ");
#nullable restore
#line 6 "C:\Users\A\source\repos\ASPmvcPractice\MVCpracticeApp\MVCpracticeApp\Views\Shared\_EachTrip.cshtml"
   Write(Html.ActionLink(Model.Name, "trip", "trip", new { Id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <div class=\"details\">\r\n        Date <span>");
#nullable restore
#line 9 "C:\Users\A\source\repos\ASPmvcPractice\MVCpracticeApp\MVCpracticeApp\Views\Shared\_EachTrip.cshtml"
              Write(Model.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> - <span>");
#nullable restore
#line 9 "C:\Users\A\source\repos\ASPmvcPractice\MVCpracticeApp\MVCpracticeApp\Views\Shared\_EachTrip.cshtml"
                                              Write(Model.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"content\">\r\n        ");
#nullable restore
#line 12 "C:\Users\A\source\repos\ASPmvcPractice\MVCpracticeApp\MVCpracticeApp\Views\Shared\_EachTrip.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <button class=\"btn btn-light \">    ");
#nullable restore
#line 15 "C:\Users\A\source\repos\ASPmvcPractice\MVCpracticeApp\MVCpracticeApp\Views\Shared\_EachTrip.cshtml"
                                  Write(Html.ActionLink("Delete", "delete", "trip", new { Id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button>\r\n\r\n</article>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCpracticeApp.Models.Trip> Html { get; private set; }
    }
}
#pragma warning restore 1591