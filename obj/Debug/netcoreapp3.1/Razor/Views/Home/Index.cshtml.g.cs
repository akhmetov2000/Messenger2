#pragma checksum "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf6c9b245eec8c668ffe790678299bd2896999b5"
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
#line 1 "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\_ViewImports.cshtml"
using AdditionBonusTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\_ViewImports.cshtml"
using AdditionBonusTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf6c9b245eec8c668ffe790678299bd2896999b5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05e5fa980dc9ee396195fb5670e9fe14747bd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"messageSender\">\r\n    <div class=\"messageSender__top\">\r\n        <img src=\"https://image.freepik.com/free-vector/businessman-character-avatar-isolated_24877-60111.jpg\" class=\"post__avatar\"/>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf6c9b245eec8c668ffe790678299bd2896999b53637", async() => {
                WriteLiteral(@"
            <input 
            class=""messageSender__input""
            placeholder=""Whats up?""
            />
            <input 
            placeholder=""Image URL Optional""
            />
            <button type=""submit"">
                Hidden submit
            </button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""messageSender__bottom"">

        <div class=""messageSender__option"">
            <i class=""fas fa-photo-video"" style=""font-size:30px; color:green""></i>
            <h3>Photo/Gif</h3>
        </div>

        <div class=""messageSender__option"">
            <i class=""far fa-smile"" style=""font-size:30px; color:orange"" ></i>
            <h3>Feeling/Activity</h3>
        </div>
    </div>
</div>

<div class=""post"">
    <div class=""post__top"">
        <img src=""https://image.freepik.com/free-vector/businessman-character-avatar-isolated_24877-60111.jpg"" class=""post__avatar"" />

        <div class=""post__topInfo"">
            <h3>Username</h3>
");
            WriteLiteral(@"            <p>Date</p>
        </div>
    </div>

    <div class=""post__bottom"">
        <p>Its message</p>
    </div>

    <div class=""post__image"">
        <img src=""https://static10.tgstat.ru/channels/_0/66/66de8dadec5fa9d4dbcc0a4beb1cfcf5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1591, "\"", 1597, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>

    <div class=""post__options"">
        <div class=""post__option"">
            <i class=""fas fa-thumbs-up"" style=""font-size:35px""></i>
            <p>Like</p>
        </div>

        <div class=""post__option"">
            <i class=""far fa-comment-dots"" style=""font-size:35px""></i>
            <p>Comment</p>
        </div>

    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591