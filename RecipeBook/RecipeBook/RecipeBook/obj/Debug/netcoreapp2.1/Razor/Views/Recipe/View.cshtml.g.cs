#pragma checksum "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c3b6e5cc402f95b36246d762ecad612b3ac6502"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_View), @"mvc.1.0.view", @"/Views/Recipe/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipe/View.cshtml", typeof(AspNetCore.Views_Recipe_View))]
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
#line 2 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\_ViewImports.cshtml"
using RecipeBook.Models;

#line default
#line hidden
#line 3 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\_ViewImports.cshtml"
using RecipeBook.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c3b6e5cc402f95b36246d762ecad612b3ac6502", @"/Views/Recipe/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3098de68f44e29ffa95b063863ed50e6f9dc10d", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-warning center-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IngAddToRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ingredient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success glyphicon-plus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(64, 170, true);
            WriteLiteral("\r\n<div id=\"rOverview\" class=\"container\">\r\n    <div class=\"row label-info\" id=\"h1Format\">\r\n        <div class=\"col-sm-8 pull-sm-4\"><h1 class=\"label-info\" id=\"h1Format\"><b>");
            EndContext();
            BeginContext(235, 17, false);
#line 8 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
                                                                           Write(Model.Recipe.Name);

#line default
#line hidden
            EndContext();
            BeginContext(252, 61, true);
            WriteLiteral("</b></h1></div>\r\n        <div class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(313, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e61a573bb70144c6a348eaf3fc1ee088", async() => {
                BeginContext(425, 11, true);
                WriteLiteral("Edit Recipe");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-RecipeID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
                                                                                         WriteLiteral(Model.Recipe.RecipeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RecipeID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-RecipeID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RecipeID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(440, 74, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <h4 class=\"label-info\" id=\"h4Format\"><b>");
            EndContext();
            BeginContext(515, 24, false);
#line 13 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
                                       Write(Model.Recipe.Description);

#line default
#line hidden
            EndContext();
            BeginContext(539, 324, true);
            WriteLiteral(@"</b></h4>
    <table class=""table table-sm table-striped table-bordered"">
        <thead>
            <tr id=""tHead"">
                <th>Servings:</th>
                <th>Prep Time:</th>
                <th>Cook Time:</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th>");
            EndContext();
            BeginContext(864, 21, false);
#line 24 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
               Write(Model.Recipe.Servings);

#line default
#line hidden
            EndContext();
            BeginContext(885, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(913, 24, false);
#line 25 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
               Write(Model.Recipe.PrepMinutes);

#line default
#line hidden
            EndContext();
            BeginContext(937, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(965, 24, false);
#line 26 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
               Write(Model.Recipe.CookMinutes);

#line default
#line hidden
            EndContext();
            BeginContext(989, 213, true);
            WriteLiteral("</th>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<div class=\"container\">\r\n    <div id=\"rIngredients\" class=\"mark\">\r\n        <h2><b><u>INGREDIENTS</u></b></h2>\r\n        <ul class=\"list-unstyled\">\r\n");
            EndContext();
#line 35 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
             foreach(Ingredient i in Model.Ingredients)
            {

#line default
#line hidden
            BeginContext(1274, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(1295, 8, false);
#line 37 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
               Write(i.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1305, 6, false);
#line 37 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
                         Write(i.Unit);

#line default
#line hidden
            EndContext();
            BeginContext(1311, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1313, 6, false);
#line 37 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
                                 Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 38 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
            }

#line default
#line hidden
            BeginContext(1341, 18, true);
            WriteLiteral("\r\n            <li>");
            EndContext();
            BeginContext(1359, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55c5dff6b86a4583bc3191061435b9f5", async() => {
                BeginContext(1523, 18, true);
                WriteLiteral("Add New Ingredient");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-RecipeID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
                                                                                    WriteLiteral(Model.Recipe.RecipeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RecipeID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-RecipeID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RecipeID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1545, 209, true);
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"container\">\r\n    <div id=\"rDirections\" class=\"mark\">\r\n        <h2><b><u>DIRECTIONS</u></b></h2>\r\n        <ul class=\"list-unstyled\">\r\n");
            EndContext();
#line 51 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
              
                string[] dirList = Model.Recipe.Directions.Split(".");

                foreach (var line in dirList)
                {


#line default
#line hidden
            BeginContext(1912, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1937, 4, false);
#line 57 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"
                   Write(line);

#line default
#line hidden
            EndContext();
            BeginContext(1941, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 58 "C:\Users\eagle\OneDrive\Desktop\Semester 3\COMP229 Web App\A4\RecipeBook\RecipeBook\RecipeBook\Views\Recipe\View.cshtml"

                }
            

#line default
#line hidden
            BeginContext(1984, 37, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
