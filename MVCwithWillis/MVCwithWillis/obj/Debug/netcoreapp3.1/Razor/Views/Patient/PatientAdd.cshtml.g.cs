#pragma checksum "C:\WTW Files\MVCwithWillis\MVCwithWillis\Views\Patient\PatientAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64ad85fcac281c3b88bc10ed2c4d317679176122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_PatientAdd), @"mvc.1.0.view", @"/Views/Patient/PatientAdd.cshtml")]
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
#line 1 "C:\WTW Files\MVCwithWillis\MVCwithWillis\Views\_ViewImports.cshtml"
using MVCwithWillis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WTW Files\MVCwithWillis\MVCwithWillis\Views\_ViewImports.cshtml"
using MVCwithWillis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64ad85fcac281c3b88bc10ed2c4d317679176122", @"/Views/Patient/PatientAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f790aeb73a562ffbeff9bb868cc963cc7493efb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_PatientAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/clientside/JavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\WTW Files\MVCwithWillis\MVCwithWillis\Views\Patient\PatientAdd.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64ad85fcac281c3b88bc10ed2c4d3176791761224243", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64ad85fcac281c3b88bc10ed2c4d3176791761225280", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    
    var patient = new Patient();
    var problemobj = new PatientProblem();
    function UpdatePatient() {
        this.patient.name = $(""#name"").val();
        this.patient.address = $(""#address"").val();
    } 
    function AddProblems() {
        this.problemobj.problem = $(""#problem"").val();
    }
    function AddTreatments() {
        var treatmentobj = new Treatment();
        treatmentobj.medicine_name = $(""#medicine_name"").val();
        treatmentobj.total_times = $(""#totaltimes"").val();
        this.problemobj.treatment.push(treatmentobj);
        $(""#medicine_name"").val("""");
        $(""#totaltimes"").val("""");
    }
    function Submit() {
        this.patient.problems.push(problemobj);
        var check = this.patient;
        $.ajax({
            url: ""/Api/PatientAPI"",
            type: ""POST"",
            data: JSON.stringify(check),
            dataType: ""json"",
            contentType: ""application/json; charset=utf-8"",
            success: function (data) {
                //Displ");
            WriteLiteral(@"aying Table
                $.each(data, function (i, item) {
                    var row = $(""<tr/>"");
                    $.each(item, function (key, value) {
                        row.append($('<td/>').html(value));
                    });
                    $(""#table"").append(row);
                });
            },
            error: function (xhr, ajaxOptions) {
                //$(""#error"").append(xhr.responseText);
                var jsonResponseText = $.parseJSON(xhr.responseText);
                $.each(jsonResponseText, function (name, val) {
                    if (name == ""errors"") {
                        var name2 = $.parseJSON(JSON.stringify(val));
                        $.each(name2, function (name3, val3) {
                            if(name3 == ""name"")
                                $(""#n"").append(val3);
                            if (name3 == ""address"")
                                $(""#a"").append(val3);
                        });
                    }
                        /");
            WriteLiteral(@"/$(""#error"").append(name+"" ""+val);
                });
                
            }
        });
        $(""#name"").val("""");
        $(""#address"").val("""");
        $(""#problem"").val("""");

        this.patient = new Patient();
        this.problemobj = new PatientProblem();
        this.patient.problems = [];
        this.problemobj.treatment = [];
    }
</script>
<!DOCTYPE html>

<html>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64ad85fcac281c3b88bc10ed2c4d3176791761228877", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>PatientAdd</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64ad85fcac281c3b88bc10ed2c4d3176791761229935", async() => {
                WriteLiteral("\n    <center>\n        <h1 style=\"color:red\" id=\"error\"></h1>\n    </center>\n    <p id=\"n\"></p>\n    Patient Name <input type=\"text\" onchange=\"UpdatePatient()\" id=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2841, "\"", 2849, 0);
                EndWriteAttribute();
                WriteLiteral(" /> <br />\n    <p id=\"a\"></p>\n    Patient Address <input type=\"text\" onchange=\"UpdatePatient()\" id=\"address\"");
                BeginWriteAttribute("value", " value=\"", 2958, "\"", 2966, 0);
                EndWriteAttribute();
                WriteLiteral(" /> <br />\n    <br />\n    Problem <input type=\"text\" id=\"problem\"");
                BeginWriteAttribute("value", " value=\"", 3032, "\"", 3040, 0);
                EndWriteAttribute();
                WriteLiteral(" /> <br />\n    <input type=\"button\" name=\"name\" value=\"Add problems\" onclick=\"AddProblems()\" />\n    <br />\n    Medicine Name <input type=\"text\" id=\"medicine_name\"");
                BeginWriteAttribute("value", " value=\"", 3203, "\"", 3211, 0);
                EndWriteAttribute();
                WriteLiteral(" /> <br />\n    Total Days <input type=\"text\" id=\"totaltimes\"");
                BeginWriteAttribute("value", " value=\"", 3272, "\"", 3280, 0);
                EndWriteAttribute();
                WriteLiteral(@" /> <br />
    <input type=""button"" name=""name"" value=""Add Treatment"" onclick=""AddTreatments()"" />
    <br />
    <input type=""button"" name=""name"" value=""Add All"" onclick=""Submit()"" />
    <br />

    <table align=""center""
           id=""table"" border=""1"">
    </table>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
