#pragma checksum "/Users/yra03/Bucks/UnitExercises/Unit4/BucksNewUniversity/Pages/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cbeea507d48b77b2ed9f08fabdd414fbc095a73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BucksNewUniversity.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
namespace BucksNewUniversity.Pages
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
#line 1 "/Users/yra03/Bucks/UnitExercises/Unit4/BucksNewUniversity/Pages/_ViewImports.cshtml"
using BucksNewUniversity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cbeea507d48b77b2ed9f08fabdd414fbc095a73", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"803275d2e5fcd18d8f865cf751fdb758a48b1d33", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/yra03/Bucks/UnitExercises/Unit4/BucksNewUniversity/Pages/About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Student Body Statistics</h2>\n\n<table>\n    <tr>\n        <th>\n            Enrollment Date\n        </th>\n        <th>\n            Students\n        </th>\n    </tr>\n\n");
#nullable restore
#line 20 "/Users/yra03/Bucks/UnitExercises/Unit4/BucksNewUniversity/Pages/About.cshtml"
     foreach (var item in Model.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 24 "/Users/yra03/Bucks/UnitExercises/Unit4/BucksNewUniversity/Pages/About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 27 "/Users/yra03/Bucks/UnitExercises/Unit4/BucksNewUniversity/Pages/About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 30 "/Users/yra03/Bucks/UnitExercises/Unit4/BucksNewUniversity/Pages/About.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BucksNewUniversity.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BucksNewUniversity.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BucksNewUniversity.Pages.AboutModel>)PageContext?.ViewData;
        public BucksNewUniversity.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
