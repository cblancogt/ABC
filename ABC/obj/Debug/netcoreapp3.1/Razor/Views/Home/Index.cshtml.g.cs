#pragma checksum "C:\proyectos\ABC\ABC\ABC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e38a2571bd12dcaa000438c1dee280963d86a034"
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
#line 1 "C:\proyectos\ABC\ABC\ABC\Views\_ViewImports.cshtml"
using ABC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\proyectos\ABC\ABC\ABC\Views\_ViewImports.cshtml"
using ABC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e38a2571bd12dcaa000438c1dee280963d86a034", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2886293d51e9e0d7000f1088ab21680d2e30ea80", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ABC.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button is-success is-large"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Proyectos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearProyecto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\proyectos\ABC\ABC\ABC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Principal.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""app"">
    <section class=""section is-title-bar"">
        <div class=""level"">
            <div class=""level-left"">
                <div class=""level-item"">
                    <ul>
                        <li>Admin</li>
                        <li>Bienvenidos</li>
                    </ul>
                </div>
            </div>

            <div class=""level-right"">
                <p class=""level-item""><a>Avances</a></p>
                <p class=""level-item""><a>Costos</a></p>
                <p class=""level-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e38a2571bd12dcaa000438c1dee280963d86a0344737", async() => {
                WriteLiteral("Crear Proyecto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
            </div>

        </div>
    </section>
    <section class=""section is-main-section"">
        <div class=""tile is-ancestor"">
            <div class=""tile is-parent"">
                <div class=""card tile is-child"">
                    <div class=""card-content"">
                        <div class=""level is-mobile"">
                            <div class=""level-item"">
                                <div class=""is-widget-label"">
                                    <h3 class=""subtitle is-spaced"">
                                        Usuarios
                                    </h3>
                                    <h1 class=""title"">
                                        92
                                    </h1>
                                </div>
                            </div>
                            <div class=""level-item has-widget-icon"">
                                <div class=""is-widget-icon"">
                                    <span class=""ico");
            WriteLiteral(@"n has-text-success is-large"">
                                        <i class=""mdi mdi-account-circle mdi-48px""></i>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""tile is-parent"">
                <div class=""card tile is-child"">
                    <div class=""card-content"">
                        <div class=""level is-mobile"">
                            <div class=""level-item"">
                                <div class=""is-widget-label"">
                                    <h3 class=""subtitle is-spaced"">
                                        Proyectos
                                    </h3>
                                    <h1 class=""title"">
                                        75%
                                    </h1>
                                </div>
                    ");
            WriteLiteral(@"        </div>
                            <div class=""level-item has-widget-icon"">
                                <div class=""is-widget-icon"">
                                    <span class=""icon has-text-success is-large"">
                                        <i class=""mdi mdi-check-underline-circle mdi-48px""></i>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""tile is-parent"">
                <div class=""card tile is-child"">
                    <div class=""card-content"">
                        <div class=""level is-mobile"">
                            <div class=""level-item"">
                                <div class=""is-widget-label"">
                                    <h3 class=""subtitle is-spaced"">
                                        Tareas
                                    </h3>");
            WriteLiteral(@"
                                    <h1 class=""title"">
                                        75%
                                    </h1>
                                </div>
                            </div>
                            <div class=""level-item has-widget-icon"">
                                <div class=""is-widget-icon"">
                                    <span class=""icon has-text-success is-large"">
                                        <i class=""mdi mdi-clock-check mdi-48px""></i>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""tile is-parent"">
                <div class=""card tile is-child"">
                    <div class=""card-content"">
                        <div class=""level is-mobile"">
                            <div class=""level-item"">
                            ");
            WriteLiteral(@"    <div class=""is-widget-label"">
                                    <h3 class=""subtitle is-spaced"">
                                        Efectividad
                                    </h3>
                                    <h1 class=""title"">
                                        75%
                                    </h1>
                                </div>
                            </div>
                            <div class=""level-item has-widget-icon"">
                                <div class=""is-widget-icon"">
                                    <span class=""icon has-text-success is-large"">
                                        <i class=""mdi mdi-circle-slice-7 mdi-48px""></i>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <script type=""text/javascript"" src=""https://www.g");
            WriteLiteral(@"static.com/charts/loader.js""></script>
        <script type=""text/javascript"">
      google.charts.load('current', {'packages':['corechart']});
      google.charts.setOnLoadCallback(drawChart);

      function drawChart() {
        var data = google.visualization.arrayToDataTable([
          ['Nov2021', 'Completos', 'Atrasados'],
          ['Dic2021',  32,      11],
          ['Ene2022',  87,      2],
          ['Feb2022',  66,       5],
          ['Mar2022',  21,      36]
        ]);

        var options = {
          title: 'Proyectos de ABC',
          hAxis: {title: 'Mes',  titleTextStyle: {color: '#333'}},
          vAxis: {minValue: 0}
        };

        var chart = new google.visualization.AreaChart(document.getElementById('chart_div'));
        chart.draw(data, options);
      }
        </script>
            
            <div id=""chart_div"" style=""width: 100%; height: 500px;""></div>
    </section>  
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ABC.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
