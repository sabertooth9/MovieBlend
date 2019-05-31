#pragma checksum "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "545be40d5792b5aad79163ecdca68085ac7f448a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PostDetail_Index), @"mvc.1.0.view", @"/Views/PostDetail/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PostDetail/Index.cshtml", typeof(AspNetCore.Views_PostDetail_Index))]
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
#line 1 "F:\ASP.core Project\Final Project\MovieBlend\Views\_ViewImports.cshtml"
using MovieBlend;

#line default
#line hidden
#line 2 "F:\ASP.core Project\Final Project\MovieBlend\Views\_ViewImports.cshtml"
using MovieBlend.Models;

#line default
#line hidden
#line 8 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
using Humanizer;

#line default
#line hidden
#line 9 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
using StmlParsing;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"545be40d5792b5aad79163ecdca68085ac7f448a", @"/Views/PostDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf50ce4c69a94c4db98bb8e4bc85777f4b1af47a", @"/Views/_ViewImports.cshtml")]
    public class Views_PostDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
            BeginContext(63, 240, true);
            WriteLiteral("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/vue/2.3.4/vue.min.js\"></script>\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/axios/0.16.2/axios.min.js\"></script>\r\n<script src=\"https://js.pusher.com/4.4/pusher.min.js\"></script>\r\n");
            EndContext();
            BeginContext(341, 1859, true);
            WriteLiteral(@"<style>
    .user_name {
        font-size: 14px;
        font-weight: bold;
    }

    .comments-list .media {
        border-bottom: 1px dotted #ccc;
    }

    h1 {
        color: snow;
        text-shadow: -1px 0 black, 0 1px black, 1px 0 black, 0 -1px black;
    }

    h3 {
        text-align: center;
        color: snow;
        text-shadow: -1px 0 black, 0 1px black, 1px 0 black, 0 -1px black;
    }

    .poster_name {
        text-align: left;
        color: darkred;
        text-decoration: underline
    }

    section {
        width: 100%;
        float: left;
    }

    .banner-section {
        background-image: url(""https://static.pexels.com/photos/373912/pexels-photo-373912.jpeg"");
        background-size: cover;
        height: 380px;
        left: 0;
        position: absolute;
        top: inherit;
        background-position: 0;
    }

    .post-title-block {
        padding: 100px 0;
    }

        .post-title-block h1 {
            color: #ff");
            WriteLiteral(@"f;
            font-size: 85px;
            font-weight: bold;
            text-transform: capitalize;
        }

        .post-title-block li {
            font-size: 20px;
            color: #fff;
        }

    .image-block {
        float: left;
        width: 100%;
        margin-bottom: 10px;
    }

    .footer-link {
        float: left;
        width: 100%;
        background: #222222;
        text-align: center;
        padding: 30px;
    }

        .footer-link a {
            color: #A9FD00;
            font-size: 18px;
            text-transform: uppercase;
        }

    .div-post {
        margin-top: 45px;
    }
    img{
        all:inherit;
        align-content:center;
        height:380px;
    }
    
</style>
<div>
    <section class=""banner-section"">
        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2200, "\"", 2247, 2);
            WriteAttributeValue("", 2206, "/PostDetail/ViewImage/", 2206, 22, true);
#line 100 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
WriteAttributeValue("", 2228, Model.Cover_pic_id, 2228, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2248, 250, true);
            WriteLiteral("/>\r\n    </section>\r\n    <section class=\"post-content-section\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-12 col-md-12 col-sm-12 post-title-block\">\r\n                    <h1 class=\"text-center\">");
            EndContext();
            BeginContext(2499, 11, false);
#line 106 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
                                       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2510, 32, true);
            WriteLiteral("</h1>\r\n                    <h3> ");
            EndContext();
            BeginContext(2543, 13, false);
#line 107 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
                    Write(Model.Release);

#line default
#line hidden
            EndContext();
            BeginContext(2556, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(2560, 14, false);
#line 107 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
                                     Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(2574, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(2578, 11, false);
#line 107 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
                                                       Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(2589, 182, true);
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"col-lg-9 col-md-9 col-sm-12 div-post\">\r\n                    <p>\r\n                        <h6 class=\"poster_name\">Posted By ");
            EndContext();
            BeginContext(2772, 15, false);
#line 111 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
                                                     Write(Model.User_name);

#line default
#line hidden
            EndContext();
            BeginContext(2787, 62, true);
            WriteLiteral("</h6>\r\n                        <h7 class=\"poster_name\">Posted ");
            EndContext();
            BeginContext(2850, 26, false);
#line 112 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
                                                  Write(Model.Postedate.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(2876, 37, true);
            WriteLiteral("</h7>\r\n                        <br />");
            EndContext();
            BeginContext(2914, 46, false);
#line 113 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
                         Write(Html.Raw(@StmlParser.Parse(Model.Description)));

#line default
#line hidden
            EndContext();
            BeginContext(2960, 178, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <div class=\"fb-comments\" data-href=\"https://localhost:5001/PostDetail/");
            EndContext();
            BeginContext(3139, 8, false);
#line 119 "F:\ASP.core Project\Final Project\MovieBlend\Views\PostDetail\Index.cshtml"
                                                                     Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3147, 51, true);
            WriteLiteral("\" data-width=\"\" data-numposts=\"10\"></div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieData> Html { get; private set; }
    }
}
#pragma warning restore 1591
