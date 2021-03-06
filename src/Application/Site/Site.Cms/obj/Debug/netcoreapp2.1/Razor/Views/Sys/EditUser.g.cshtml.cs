#pragma checksum "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d52cb25124468ce57f399d95c8d38b3913b46cd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sys_EditUser), @"mvc.1.0.view", @"/Views/Sys/EditUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sys/EditUser.cshtml", typeof(AspNetCore.Views_Sys_EditUser))]
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
#line 1 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\_ViewImports.cshtml"
using Site.Cms;

#line default
#line hidden
#line 2 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\_ViewImports.cshtml"
using MicBeach.Web.Mvc;

#line default
#line hidden
#line 5 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
using MicBeach.ViewModel.Sys;

#line default
#line hidden
#line 7 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
using MicBeach.Util.Extension;

#line default
#line hidden
#line 8 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
using MicBeach.Application.Identity.User;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d52cb25124468ce57f399d95c8d38b3913b46cd3", @"/Views/Sys/EditUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e5000250b2a0bb9c30615591362c9282acaa0ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Sys_EditUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/editor/ueditor.config.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/editor/ueditor.all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/editor/lang/zh-cn/zh-cn.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
  
    ViewBag.Title = "编辑用户";

#line default
#line hidden
#line 10 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
  
    List<RoleViewModel> roleList = Model?.Roles ?? new List<RoleViewModel>(0);
    bool isAdd = Model == null || Model.SysNo <= 0;

#line default
#line hidden
            BeginContext(345, 134, true);
            WriteLiteral("\r\n<div id=\"pc-body\">\r\n    <div id=\"pc-body-inner\">\r\n        <div class=\"form-con\" id=\"home\">\r\n            <div class=\"form-ingroup\">\r\n");
            EndContext();
            BeginContext(611, 40, true);
            WriteLiteral("                <div class=\"fig-body\">\r\n");
            EndContext();
#line 23 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                     using (Html.AjaxBeginForm("Edituser", "sys", new AjaxFormOptions() { HttpMethod = "Post", OnSuccess = "SuccessCallback", OnFailure = "FailedCallback" }, new { id = "formvalide" }))
                    {
                        

#line default
#line hidden
            BeginContext(902, 48, false);
#line 25 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                   Write(Html.Hidden("SysNo", null, new { id = "SysNo" }));

#line default
#line hidden
            EndContext();
            BeginContext(952, 165, true);
            WriteLiteral("                        <input type=\"hidden\" name=\"userRoles\" id=\"userRoles\" />\r\n                        <table cellpadding=\"0\" cellspacing=\"0\" class=\"form_table\">\r\n");
            EndContext();
#line 28 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                             if (isAdd)
                            {

#line default
#line hidden
            BeginContext(1189, 102, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"txt-right tit\">* ");
            EndContext();
            BeginContext(1292, 30, false);
#line 31 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                                           Write(Html.LabelFor(c => c.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 89, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1412, 71, false);
#line 33 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                   Write(Html.TextBoxFor(a => a.UserName, new { @class = "form-control w-200" }));

#line default
#line hidden
            EndContext();
            BeginContext(1483, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(1526, 84, false);
#line 34 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                   Write(Html.DefaultValidationMessageFor(a => a.UserName, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 37 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1790, 102, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"txt-right tit\">* ");
            EndContext();
            BeginContext(1893, 30, false);
#line 41 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                                           Write(Html.LabelFor(c => c.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1923, 90, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        【");
            EndContext();
            BeginContext(2014, 14, false);
#line 43 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                    Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2028, 85, true);
            WriteLiteral("】\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 46 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                            }

#line default
#line hidden
            BeginContext(2144, 94, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"txt-right tit\">* ");
            EndContext();
            BeginContext(2239, 30, false);
#line 48 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                                       Write(Html.LabelFor(c => c.RealName));

#line default
#line hidden
            EndContext();
            BeginContext(2269, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2351, 71, false);
#line 50 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                               Write(Html.TextBoxFor(a => a.RealName, new { @class = "form-control w-200" }));

#line default
#line hidden
            EndContext();
            BeginContext(2422, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2461, 84, false);
#line 51 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                               Write(Html.DefaultValidationMessageFor(a => a.RealName, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(2545, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 54 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                             if (isAdd)
                            {

#line default
#line hidden
            BeginContext(2693, 102, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"txt-right tit\">* ");
            EndContext();
            BeginContext(2796, 25, false);
#line 57 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                                           Write(Html.LabelFor(c => c.Pwd));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 89, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2911, 67, false);
#line 59 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                   Write(Html.PasswordFor(a => a.Pwd, new { @class = "form-control w-200" }));

#line default
#line hidden
            EndContext();
            BeginContext(2978, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3021, 79, false);
#line 60 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                   Write(Html.DefaultValidationMessageFor(a => a.Pwd, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(3100, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 63 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                            }

#line default
#line hidden
            BeginContext(3215, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 64 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                             if (!Model.SuperUser)
                            {

#line default
#line hidden
            BeginContext(3298, 102, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"txt-right tit\">* ");
            EndContext();
            BeginContext(3401, 28, false);
#line 67 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                                           Write(Html.LabelFor(c => c.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3429, 89, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3519, 130, false);
#line 69 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                   Write(Html.EnumToSelect(a => a.Status, UserStatus.正常, new { @class = "form-control w-200" }, "", "选择状态", ((int)Model.Status).ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(3649, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3692, 82, false);
#line 70 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                   Write(Html.DefaultValidationMessageFor(a => a.Status, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(3774, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 73 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                            }

#line default
#line hidden
            BeginContext(3889, 92, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"txt-right tit\">");
            EndContext();
            BeginContext(3982, 28, false);
#line 75 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                                     Write(Html.LabelFor(c => c.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(4010, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4092, 69, false);
#line 77 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                               Write(Html.TextBoxFor(a => a.Mobile, new { @class = "form-control w-200" }));

#line default
#line hidden
            EndContext();
            BeginContext(4161, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4200, 82, false);
#line 78 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                               Write(Html.DefaultValidationMessageFor(a => a.Mobile, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(4282, 168, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"txt-right tit\">");
            EndContext();
            BeginContext(4451, 27, false);
#line 82 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                                     Write(Html.LabelFor(c => c.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4478, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4560, 68, false);
#line 84 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                               Write(Html.TextBoxFor(a => a.Email, new { @class = "form-control w-200" }));

#line default
#line hidden
            EndContext();
            BeginContext(4628, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4667, 81, false);
#line 85 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                               Write(Html.DefaultValidationMessageFor(a => a.Email, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(4748, 168, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"txt-right tit\">");
            EndContext();
            BeginContext(4917, 24, false);
#line 89 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                                     Write(Html.LabelFor(c => c.QQ));

#line default
#line hidden
            EndContext();
            BeginContext(4941, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5023, 65, false);
#line 91 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                               Write(Html.TextBoxFor(a => a.QQ, new { @class = "form-control w-200" }));

#line default
#line hidden
            EndContext();
            BeginContext(5088, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(5127, 78, false);
#line 92 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                               Write(Html.DefaultValidationMessageFor(a => a.QQ, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(5205, 478, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td class=""txt-right tit"">详情</td>
                                <td>
                                    <script id=""container"" class=""h-400"" name=""content"" type=""text/plain"">
                                    </script>
                                </td>
                            </tr>
                        </table>
");
            EndContext();
#line 103 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                    }

#line default
#line hidden
            BeginContext(5706, 1526, true);
            WriteLiteral(@"
                </div>
            </div>

            <div class=""form-ingroup h-20""></div>
        </div>

        <div class=""form_tabgroup"" style=""height:auto"">
            <ul class=""nav nav-tabs"" role=""tablist"">
                <li role=""presentation"" class=""active"">
                    <a href=""#goodsinfo"" role=""tab"" data-toggle=""tab"" class=""bd-rad-0 bd-lw-0"">用户角色</a>
                </li>
            </ul>
            <div class=""form_tabgconent tab-content bd-lw-0 bd-rw-0 bd-bw-0"">
                <div role=""tabpanel"" class=""tab-pane active"" id=""goodsinfo"">
                    <div class=""panel-body pd-0 b-r-radnone b-l-radnone"">
                        <div class=""panel-body pd-5"">
                            <div class=""lis_lefttool""></div>
                            <div class=""lis_search"">
                                <button type=""button"" class=""btn btn-success"" id=""btn_selectrole""><i class=""glyphicon glyphicon-plus""></i> 选择角色</button>
                            </div>");
            WriteLiteral(@"
                        </div>
                    </div>

                    <table class=""table table-striped table-bordered nowrap wp-100 bd-lw-0"" cellpadding=""0"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th class=""bd-lw-0"">角色名</th>
                                <th width=""65px"">操作</th>
                            </tr>
                        </thead>
                        <tbody id=""roletabe_page_list"">
");
            EndContext();
#line 136 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                             if (roleList.IsNullOrEmpty())
                            {
                            }
                            else
                            {
                                foreach (var role in roleList)
                                {

#line default
#line hidden
            BeginContext(7518, 103, true);
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"b_l_none\">");
            EndContext();
            BeginContext(7622, 9, false);
#line 144 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                                        Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(7631, 117, true);
            WriteLiteral("</td>\r\n                                        <td><button type=\"button\" class=\"btn btn-xs btn-danger btn_removerole\"");
            EndContext();
            BeginWriteAttribute("sysno", " sysno=\"", 7748, "\"", 7767, 1);
#line 145 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
WriteAttributeValue("", 7756, role.SysNo, 7756, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7768, 104, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-trash\"></i> 移除</button></td>\r\n                                    </tr>\r\n");
            EndContext();
#line 147 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(7938, 353, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<div id=""pc-foot"">
    <div class=""txt-right form-submitbtn-con pdr-10"">
        <button class=""btn btn-blue"" id=""btn_submit""><i class=""glyphicon glyphicon-floppy-save""></i> 提交</button>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8308, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8314, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b71034a86a747b3b6643510c76c29f2", async() => {
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
                EndContext();
                BeginContext(8368, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8374, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1a3041727c84cf09a432e08e116ccc4", async() => {
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
                EndContext();
                BeginContext(8425, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8431, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18c879ae194c428ebedf1b08734807e1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8487, 174, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        //BodyScroll = false;\r\n        PositionListTable = false;\r\n        var userRoles = new Object();\r\n        var userDetailUrl = \'");
                EndContext();
                BeginContext(8662, 51, false);
#line 169 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                        Write(Url.Action("AdminUserDetail","Sys",new { id="_id"}));

#line default
#line hidden
                EndContext();
                BeginContext(8713, 800, true);
                WriteLiteral(@"';
        $(function () {
            UE.getEditor('container');
            $(""#btn_submit"").click(function () {
                InitRoleValue();
                $(""#formvalide"").submit();
            });

            //初始化角色数据
            $(""#roletabe_page_list tr"").each(function (i, e) {
                var ele = $(e);
                var removeBtn = ele.find('.btn_removerole');
                var sysNo = $.trim(removeBtn.attr(""sysno""));
                if (sysNo == """") {
                    return true;
                }
                userRoles[sysNo] = { Data: { SysNo: sysNo }, Ele: ele, IsNew: false, Status: true };
            });

            //选择角色
            $(""#btn_selectrole"").click(function () {
                DialogPage({
                    url: '");
                EndContext();
                BeginContext(9514, 40, false);
#line 191 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditUser.cshtml"
                     Write(Url.Action("RoleMultipleSelector","Sys"));

#line default
#line hidden
                EndContext();
                BeginContext(9554, 2843, true);
                WriteLiteral(@"',
                    width: ""300px"",
                    height: ""350px"",
                    title: '选择角色',
                    ok: false,
                    cancel: null
                });
            });

            //移除角色
            $(""body"").on(""click"", "".btn_removerole"", function () {
                RemoveRole($(this).attr(""sysno""));
            });
        });

        //角色选择回调
        function RoleMultipleSelectCallback(roles, roleName) {
            if (!roles) {
                return;
            }
            $(""#role_empty_tr"").remove();
            for (var r in roles) {
                var roleData = roles[r];
                var nowRole = userRoles[roleData.SysNo];
                if (!nowRole) {
                    var ele = $('<tr><td class=""b_l_none"">' + roleData.Name + '</td><td><button type=""button"" class=""btn btn-xs btn-danger btn_removerole"" sysno=""' + roleData.SysNo + '""><i class=""glyphicon glyphicon-trash""></i> 移除</button></td></tr>');
                ");
                WriteLiteral(@"    nowRole = { Data: roleData, Ele: ele, IsNew: true, Status: true };
                    userRoles[roleData.SysNo] = nowRole;
                    $(""#roletabe_page_list"").append(ele);
                } else if (nowRole.Status == 0) {
                    nowRole.Status = 1;
                    $(""#roletabe_page_list"").append(nowRole.Ele);
                }
            }
        }

        //成功回调
        function SuccessCallback(res) {
            if (!res) {
                return;
            }
            res = JSON.parse(res);
            ResultMsg(res);
            if (res.Success) {
                window.top.RedirectCurrentPage(userDetailUrl.replace('_id', res.Data.SysNo), '用户详情');
            }
        }

        //失败回掉
        function FailedCallback() {
            ErrorMsg('提交失败');
        }

        //移除角色
        function RemoveRole(roleId) {
            if (!roleId) {
                return;
            }
            var nowRole = userRoles[roleId];
            i");
                WriteLiteral(@"f (!nowRole) {
                return;
            }
            nowRole.Status = false;
            userRoles[roleId] = nowRole;
            nowRole.Ele.remove();
        }

        //初始化角色
        function InitRoleValue() {
            if (!userRoles) {
                return;
            }
            //var removeRoles = new Array();
            //var newRoles = new Array();
            var nowRoles = new Array();
            for (var r in userRoles) {
                var nowRole = userRoles[r];
                if (!nowRole) {
                    return;
                }
                if (nowRole.Status) {
                    nowRoles.push(r);
                }
            }
            $(""#userRoles"").val(nowRoles.join(','));
        }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
