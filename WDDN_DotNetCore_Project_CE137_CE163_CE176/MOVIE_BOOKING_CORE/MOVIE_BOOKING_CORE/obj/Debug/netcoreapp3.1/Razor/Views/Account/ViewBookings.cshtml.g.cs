#pragma checksum "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8098aeccce8133af2f888632a02871fe8b3b5aa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ViewBookings), @"mvc.1.0.view", @"/Views/Account/ViewBookings.cshtml")]
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
#line 2 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\_ViewImports.cshtml"
using MOVIE_BOOKING_CORE.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\_ViewImports.cshtml"
using MOVIE_BOOKING_CORE.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8098aeccce8133af2f888632a02871fe8b3b5aa4", @"/Views/Account/ViewBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86de85b7dd98b764782d10367d3c15c3273a86ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ViewBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<MovieBooking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MovieTicket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Your Bookings</h1>\r\n\r\n");
#nullable restore
#line 5 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th>
                Movie Name
            </th>
            <th>
                Show Date
            </th>
            <th>
                Show Time
            </th>
            <th>
                Ticket Type
            </th>
            <th>
                Total Tickets 
            </th>
            <th>
                Total Bill
            </th>


        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.showtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.ticketType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.total_tickets));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ₹ ");
#nullable restore
#line 53 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml"
             Write(Html.DisplayFor(modelItem => item.total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 57 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 60 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>You have no bookings</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8098aeccce8133af2f888632a02871fe8b3b5aa48568", async() => {
                WriteLiteral("Show Movies");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 65 "D:\DDUSEM5\WDDN\Core Project\WDDN_DotNetCore_Project_CE137_CE163_CE176\MOVIE_BOOKING_CORE\MOVIE_BOOKING_CORE\Views\Account\ViewBookings.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<MovieBooking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
