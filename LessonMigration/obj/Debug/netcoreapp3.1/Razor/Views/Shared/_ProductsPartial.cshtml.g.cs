#pragma checksum "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\Shared\_ProductsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6f24c03b23c65d20aa330e63dcbbe3d77110af8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductsPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductsPartial.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\_ViewImports.cshtml"
using LessonMigration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\_ViewImports.cshtml"
using LessonMigration.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\_ViewImports.cshtml"
using LessonMigration.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f24c03b23c65d20aa330e63dcbbe3d77110af8", @"/Views/Shared/_ProductsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15bb8ae992336ed7ecf780060bded98401cd356d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\Shared\_ProductsPartial.cshtml"
 if (Model.Count() > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\Shared\_ProductsPartial.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\r\n            <div class=\"product-item text-center\" data-id=\"");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\Shared\_ProductsPartial.cshtml"
                                                      Write(product.Category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <div class=\"img\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 303, "\"", 310, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\Shared\_ProductsPartial.cshtml"
                         if (product.Images.Where(m => m.IsMain == true).Count() > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 460, "\"", 535, 2);
            WriteAttributeValue("", 466, "img/", 466, 4, true);
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\Shared\_ProductsPartial.cshtml"
WriteAttributeValue("", 470, product.Images.Where(m=>m.IsMain == true).FirstOrDefault().Image, 470, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 554, "\"", 560, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\Shared\_ProductsPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </div>\r\n                <div class=\"title mt-3\">\r\n                    <h6>");
#nullable restore
#line 19 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\Shared\_ProductsPartial.cshtml"
                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </div>\r\n                <div class=\"price\">\r\n                    <span class=\"text-black-50\">Add to cart</span>\r\n                    <span class=\"text-black-50\">$");
#nullable restore
#line 23 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\Shared\_ProductsPartial.cshtml"
                                            Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\Shared\_ProductsPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\P126-AspNet-Area-PartialView\LessonMigration\LessonMigration\Views\Shared\_ProductsPartial.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
