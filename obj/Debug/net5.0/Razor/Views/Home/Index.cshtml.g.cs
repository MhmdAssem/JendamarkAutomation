#pragma checksum "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c49f904db9168a502416d170a48a953a12a919da"
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
#line 1 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
using Jendamark_Automation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c49f904db9168a502416d170a48a953a12a919da", @"/Views/Home/Index.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FormStyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/TableStyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@" 


<div class=""text-center"">
    <h1 class=""display-4"" style=""text-align:center;"">Its all about operations</h1>
</div>

<table id= ""OperationsTable"">
    <thead>
        <tr>
            <th>OperationID</th>
            <th>Name</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody id=""OperationTableBody"">
");
#nullable restore
#line 20 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
         foreach (var item in Model.Operations)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 498, "\"", 533, 2);
            WriteAttributeValue("", 503, "OperationRow_", 503, 13, true);
#nullable restore
#line 22 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
WriteAttributeValue("", 516, item.OperationID, 516, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>\r\n                ");
#nullable restore
#line 24 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OperationID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 788, "\"", 820, 1);
#nullable restore
#line 30 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
WriteAttributeValue("", 803, item.OperationID, 803, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 873, "\"", 905, 1);
#nullable restore
#line 31 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
WriteAttributeValue("", 888, item.OperationID, 888, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick= \"", 949, "\"", 994, 3);
            WriteAttributeValue("", 960, "deleteOperation(", 960, 16, true);
#nullable restore
#line 32 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
WriteAttributeValue("", 976, item.OperationID, 976, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 993, ")", 993, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>

</table>
<button class=""Add-New-Device-Button"" onclick=""openNewDeviceForm()"">Add New Device</button>
<button class=""Add-New-Operation-Button"" onclick=""openNewOperationForm()"">Add New Operation</button>




<div class=""form-popup"" id=""NewDeviceForm"">
  <form action=""/Home/SaveDevice"" class=""form-container"" method=""post"">
    <h1>New Device</h1>

    <label for=""Name""><b>Name</b></label>
    <input type=""text"" placeholder=""Enter Device Name"" name=""Name"" required>

    <label for=""DeviceType""><b>DeviceType</b></label>
    <select name=""DeviceTypes"" id=""DeviceTypes"">
    <option value=""0"">BarcodeScanner</option>
    <option value=""1"">Printer</option>
    <option value=""2"">Camera</option>
    <option value=""3"">SocketTray</option>
  </select>


    <button type=""submit"" class=""btn"">Save</button>
    <button type=""button"" class=""btn cancel"" onclick=""closeNewDeviceForm()"">Close</button>
  </form>
</div>


<div class=""form-popup"" id=""NewOperationForm"">
  <form action=""/Hom");
            WriteLiteral(@"e/SaveOperation"" class=""form-container"" method=""post"">
    <h1>New Operation</h1>

    <label for=""Name""><b>Name</b></label>
    <input type=""text"" placeholder=""Enter Operation Name"" name=""Name"" required>
    <label for=""Devices""><b>Devices</b></label>
    <select name=""Devices"" id=""Devices"">
   
");
#nullable restore
#line 76 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
     foreach(var device in Model.Devices)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <option");
            BeginWriteAttribute("value", " value=\"", 2448, "\"", 2472, 1);
#nullable restore
#line 78 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
WriteAttributeValue("", 2456, device.DeviceID, 2456, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
                                    Write(device.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 79 "F:\FreeLance\Jendamark Automation\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </select>
    <button type=""submit"" class=""btn"">Save</button>
    <button type=""button"" class=""btn cancel"" onclick=""closeNewOperationForm()"">Close</button>
  </form>
</div>


<script src=""https://code.jquery.com/jquery-3.5.1.min.js"" type=""text/javascript""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c49f904db9168a502416d170a48a953a12a919da10267", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c49f904db9168a502416d170a48a953a12a919da11465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"/js/site.js\"  type=\"text/javascript\"></script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
