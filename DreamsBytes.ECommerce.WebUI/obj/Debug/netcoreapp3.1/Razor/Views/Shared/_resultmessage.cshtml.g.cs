#pragma checksum "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\Shared\_resultmessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4344e8526daf71eaf3d0f96ec62e8a0208b0518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__resultmessage), @"mvc.1.0.view", @"/Views/Shared/_resultmessage.cshtml")]
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
#line 1 "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\_ViewImports.cshtml"
using DreamsBytes.ECommerce.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\_ViewImports.cshtml"
using DreamsBytes.ECommerce.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\_ViewImports.cshtml"
using DreamsBytes.ECommerce.DTOs.Concrete.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\_ViewImports.cshtml"
using DreamsBytes.ECommerce.DTOs.Concrete.CartDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\_ViewImports.cshtml"
using DreamsBytes.ECommerce.DTOs.Concrete.CategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\_ViewImports.cshtml"
using DreamsBytes.ECommerce.DTOs.Concrete.OrderDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\_ViewImports.cshtml"
using DreamsBytes.ECommerce.DTOs.Concrete.ProductDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\_ViewImports.cshtml"
using DreamsBytes.ECommerce.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4344e8526daf71eaf3d0f96ec62e8a0208b0518", @"/Views/Shared/_resultmessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd71825a304d9ba1efcbc107188a701ddaec2e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__resultmessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 84, "\"", 114, 3);
            WriteAttributeValue("", 92, "alert", 92, 5, true);
            WriteAttributeValue(" ", 97, "alert-", 98, 7, true);
#nullable restore
#line 5 "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\Shared\_resultmessage.cshtml"
WriteAttributeValue("", 104, Model.Css, 104, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h4 class=\"alert-title\">");
#nullable restore
#line 6 "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\Shared\_resultmessage.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p>");
#nullable restore
#line 7 "C:\Users\Ömer\source\repos\ECommerce\DreamsBytes.ECommerce.WebUI\Views\Shared\_resultmessage.cshtml"
          Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
