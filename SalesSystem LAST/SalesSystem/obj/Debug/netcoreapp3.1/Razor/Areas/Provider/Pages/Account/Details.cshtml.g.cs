#pragma checksum "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\Account\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c94653ddd149f8a925117d1963127ea4c151f8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Provider_Pages_Account_Details), @"mvc.1.0.razor-page", @"/Areas/Provider/Pages/Account/Details.cshtml")]
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
#line 1 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\_ViewImports.cshtml"
using SalesSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\_ViewImports.cshtml"
using SalesSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\_ViewImports.cshtml"
using SalesSystem.Areas.Provider.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\_ViewImports.cshtml"
using SalesSystem.Areas.Provider.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c94653ddd149f8a925117d1963127ea4c151f8e", @"/Areas/Provider/Pages/Account/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b4443f887dce266b13c6e97f4cd689746ca4ad", @"/Areas/Provider/Pages/_ViewImports.cshtml")]
    public class Areas_Provider_Pages_Account_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Provider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Reports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\Account\Details.cshtml"
  
    var image = "data:image/jpg;base64," + Convert.ToBase64String(Model.Input.DataProvider.Image,
        0, Model.Input.DataProvider.Image.Length);
    var name = Model.Input.DataProvider.Provider ;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h1>");
#nullable restore
#line 9 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\Account\Details.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm \">\r\n            <div class=\"card text-center\" style=\"width: 21rem;\">\r\n                <div class=\"card-header \">\r\n                    <img class=\'imageUserDetails\'");
            BeginWriteAttribute("src", " src=\"", 496, "\"", 508, 1);
#nullable restore
#line 14 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\Account\Details.cshtml"
WriteAttributeValue("", 502, image, 502, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"col-md-10\">\r\n                        <div class=\"row\">\r\n                            <p> ");
#nullable restore
#line 19 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\Account\Details.cshtml"
                           Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        \r\n                        <div class=\"row\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c94653ddd149f8a925117d1963127ea4c151f8e7513", async() => {
                WriteLiteral("\r\n                                Reportes\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\Account\Details.cshtml"
                                                                        WriteLiteral(Model.Input.DataProvider.IdProvider);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-sm"">
            <div class=""card"">
                <div class=""card-body"">
                    <table class=""tableCursos"">
                        <tbody>
                            <tr>
                                <th>
                                    Informacion
                                </th>
                            </tr>
                            <tr>
                                <th>
                                    Nombre
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    <p>");
#nullable restore
#line 48 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\Account\Details.cshtml"
                                  Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    Telefono
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    <p>");
#nullable restore
#line 58 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\Account\Details.cshtml"
                                  Write(Model.Input.DataProvider.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </td>
                            </tr>
                            <tr>
                                <th>
                                    Correo electronico
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    <p>");
#nullable restore
#line 68 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\Account\Details.cshtml"
                                  Write(Model.Input.DataProvider.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c94653ddd149f8a925117d1963127ea4c151f8e12694", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\Account\Details.cshtml"
                                          
                                            var DataProvider = JsonConvert.SerializeObject(Model.Input.DataProvider);
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"DataProvider\"");
                BeginWriteAttribute("value", " value=\"", 3215, "\"", 3236, 1);
#nullable restore
#line 78 "C:\Users\AJpag\Downloads\C#\SalesSystem\SalesSystem\Areas\Provider\Pages\Account\Details.cshtml"
WriteAttributeValue("", 3223, DataProvider, 3223, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input type=\"submit\" value=\"Editar\" class=\"btn btn-success \">\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsModel>)PageContext?.ViewData;
        public DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591